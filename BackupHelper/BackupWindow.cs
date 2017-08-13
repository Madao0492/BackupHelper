using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupHelper
{
    public partial class BackupWindow : Form
    {
        bool isCopying = true, isCanceled = false;
        int bCount = 0, fCount = 0;
        string bDestination_tmp = "";

        public BackupWindow(List<string> bFolderList, string bDestination)
        {
            InitializeComponent();

            Task.Run(() => BackupProcess(bFolderList, bDestination));
        }

        #region Formイベント
        delegate void SetProgressMaximum(int max);
        delegate void SetProgressValue(int value);
        delegate void CloseWindow();
        delegate void SetFileCount(string text);

        private void SetProgressBarMaximum(int max)
        {
            progressBar_File.Maximum = max;
        }

        private void SetProgressBarValue(int value)
        {
            progressBar_File.Value = value;
        }

        private void CloseFormWindow()
        {
            Close();
        }

        private void SetFileCountLabel(string str)
        {
            label_File.Text = str;
        }


        private void button_Cancel_Click(object sender, EventArgs e)
        {
            isCopying = false;
        }
        #endregion

        #region Task本体
        private void BackupProcess(List<string> bFolderList, string bDestination)
        {
            DateTime dt = DateTime.Now;
            bDestination_tmp = bDestination + "backup_" + dt.ToString("yyyyMMddHHmmss");

            for (int i = 0; i < bFolderList.Count; i++)
            {
                CountFiles(bFolderList[i]);
            }

            try
            {
                Invoke(new SetProgressMaximum(SetProgressBarMaximum), fCount);
            }
            catch (Exception)
            {
            }

            for(int j = 0; j < bFolderList.Count; j++)
            { 
                CopyDirectory(bFolderList[j], bDestination_tmp + "\\" + bFolderList[j].Split('\\')[Path.GetDirectoryName(bFolderList[j]).Split('\\').Length]);
                if (isCopying)
                {
                    try
                    {
                        MessageBox.Show("終了しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Invoke(new CloseWindow(CloseFormWindow));
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
        #endregion

        #region ファイル操作メソッド
        private void CountFiles(string sourceDirName)
        {
            //コピー元のディレクトリにあるファイルを数える
            string[] files = Directory.GetFiles(sourceDirName);
            foreach (string file in files)
            {
                fCount++;
            }

            //コピー元のディレクトリにあるディレクトリについて、再帰的に呼び出す
            string[] dirs = Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
            {
                CountFiles(dir);
            }
        }

        private void CopyDirectory(string sourceDirName, string destDirName)
        {
            //コピー先のディレクトリがないときは作る
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            //コピー先のディレクトリ名の末尾に"\"をつける
            if (destDirName[destDirName.Length - 1] != Path.DirectorySeparatorChar)
                destDirName = destDirName + Path.DirectorySeparatorChar;

            //コピー元のディレクトリにあるファイルをコピー
            string[] files = Directory.GetFiles(sourceDirName);
            foreach (string file in files)
            {
                if (isCopying)
                {
                    try
                    {
                        File.Copy(file, destDirName + Path.GetFileName(file), true);
                        bCount++;
                        Invoke(new SetProgressValue(SetProgressBarValue), bCount);
                        Invoke(new SetFileCount(SetFileCountLabel), bCount + " / " + fCount);
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    try
                    {
                        Directory.Delete(bDestination_tmp, true);
                        if (!isCanceled)
                        {
                            MessageBox.Show("キャンセルされました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            isCanceled = true;
                            Invoke(new CloseWindow(CloseFormWindow));
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            //コピー元のディレクトリにあるディレクトリについて、再帰的に呼び出す
            string[] dirs = Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
                CopyDirectory(dir, destDirName + Path.GetFileName(dir));
        }

        #endregion


    }
}
