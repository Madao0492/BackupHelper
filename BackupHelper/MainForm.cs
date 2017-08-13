using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BackupHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region Formイベント
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (GetDriveName().Count != 0)
            {
                comboBox_Drive.DataSource = new BindingSource(GetDriveName(), null);
                comboBox_Drive.ValueMember = "Value";
                comboBox_Drive.DisplayMember = "Key";
            }
            LoadBackupListFile();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            SelectFolder sFolder = new SelectFolder();
            sFolder.ShowDialog();
            AddBackupFolder(sFolder.GetBackupFolder());
            sFolder.Dispose();
            MakeBackupListFile();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dataGridView_BackupFolder.SelectedCells)
            {
                dataGridView_BackupFolder.Rows.RemoveAt(c.RowIndex);
                MakeBackupListFile();
            }
        }

        private void button_Backup_Click(object sender, EventArgs e)
        {
            if (comboBox_Drive.Text == "")
            {
                MessageBox.Show("バックアップ先が選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(dataGridView_BackupFolder.RowCount <= 0)
            {
                MessageBox.Show("バックアップ対象が選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> bFolderList = new List<string>();
            string bDestination = "";

            for(int i = 0; i < dataGridView_BackupFolder.RowCount; i++)
            {
                bFolderList.Add(dataGridView_BackupFolder.Rows[i].Cells[0].Value.ToString());
            }

            bDestination = comboBox_Drive.Text;

            BackupWindow bWindow = new BackupWindow(bFolderList, bDestination);
            //BackupWindow bWindow = new BackupWindow(bFolderList, @"C:\Users\Kitajima\Desktop\");
            bWindow.ShowDialog();
            bWindow.Dispose();
        }
        #endregion

        #region データ生成
        private Dictionary<string, string> GetDriveName()
        {
            string[] drives = Directory.GetLogicalDrives();
            string dLetter_tmp = "";
            DriveInfo dInfo;
            Dictionary<string, string> dList = new Dictionary<string, string>();

            foreach (string s in drives)
            {
                dLetter_tmp = s.Substring(0, 1);
                dInfo = new DriveInfo(dLetter_tmp);

                if ((dInfo.DriveType == DriveType.Fixed || dInfo.DriveType == DriveType.Removable) && dInfo.IsReady && dLetter_tmp != "C")
                //if (dInfo.DriveType == DriveType.Fixed && dInfo.IsReady)
                {
                    if (dInfo.VolumeLabel != "")
                    {
                        dList.Add(dInfo.VolumeLabel + " - " + s, s);
                    }
                    else
                    {
                        dList.Add(s, s);
                    }
                }
            }

            return dList;
        }

        private void AddBackupFolder(Dictionary<string, string> d)
        {
            if (d.Count > 0)
            {
                foreach (KeyValuePair<string, string> item in d)
                {
                    dataGridView_BackupFolder.Rows.Add(item.Value, item.Key);
                }
            }
        }

        #endregion

        #region バックアップリスト関係
        private void LoadBackupListFile()
        {
            string[] rLine;
            if (File.Exists("BackupList.log"))
            {
                StreamReader sr = new StreamReader("BackupList.log", Encoding.GetEncoding("shift_jis"));
                while (sr.Peek() > -1)
                {
                    if((rLine = sr.ReadLine().Split(',')).Length > 1)
                    {
                        dataGridView_BackupFolder.Rows.Add();
                        int idx = dataGridView_BackupFolder.Rows.Count - 1;
                        dataGridView_BackupFolder.Rows[idx].Cells[0].Value = rLine[0];
                        dataGridView_BackupFolder.Rows[idx].Cells[1].Value = rLine[1];
                    }
                }
                sr.Close();
            }
        }

        private void MakeBackupListFile()
        {
            List<string> listFile = new List<string>();
            if (dataGridView_BackupFolder.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_BackupFolder.RowCount; i++)
                {
                    listFile.Add(dataGridView_BackupFolder.Rows[i].Cells[0].Value + ", " + dataGridView_BackupFolder.Rows[i].Cells[1].Value);
                }
            }

            WriteLog(listFile);
        }

        private void WriteLog(List<string> str)
        {
            StreamWriter sw = new StreamWriter("BackupList.log", false, System.Text.Encoding.GetEncoding("shift_jis"));
            for (int i = 0; i < str.Count; i++)
            {
                sw.WriteLine(str[i]);
            }
            sw.Close();
        }
        #endregion

    }
}
