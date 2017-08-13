using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupHelper
{
    public partial class SelectFolder : Form
    {
        Dictionary<string, string> bFolder = new Dictionary<string, string>();

        public SelectFolder()
        {
            InitializeComponent();
        }

        #region Formイベント
        private void button_Reference_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            fbd.SelectedPath = @"C:\";
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = false;

            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダを表示する
                textBox_Folder.Text = fbd.SelectedPath;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_Folder.Text == "")
            {
                MessageBox.Show("フォルダを選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_Description.Text == "")
            {
                MessageBox.Show("説明を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bFolder.Add(textBox_Description.Text, textBox_Folder.Text);
                Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region DictionaryのGet
        public Dictionary<string, string> GetBackupFolder()
        {
            return bFolder;
        }
        #endregion

    }
}
