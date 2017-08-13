namespace BackupHelper
{
    partial class SelectFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Folder = new System.Windows.Forms.TextBox();
            this.button_Reference = new System.Windows.Forms.Button();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "バックアップ対象フォルダの選択";
            // 
            // textBox_Folder
            // 
            this.textBox_Folder.BackColor = System.Drawing.Color.White;
            this.textBox_Folder.Location = new System.Drawing.Point(13, 37);
            this.textBox_Folder.Name = "textBox_Folder";
            this.textBox_Folder.ReadOnly = true;
            this.textBox_Folder.Size = new System.Drawing.Size(370, 19);
            this.textBox_Folder.TabIndex = 1;
            // 
            // button_Reference
            // 
            this.button_Reference.Location = new System.Drawing.Point(389, 35);
            this.button_Reference.Name = "button_Reference";
            this.button_Reference.Size = new System.Drawing.Size(75, 23);
            this.button_Reference.TabIndex = 2;
            this.button_Reference.Text = "参　照";
            this.button_Reference.UseVisualStyleBackColor = true;
            this.button_Reference.Click += new System.EventHandler(this.button_Reference_Click);
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(12, 68);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(89, 12);
            this.label_Description.TabIndex = 3;
            this.label_Description.Text = "説明（必須項目）";
            // 
            // textBox_Description
            // 
            this.textBox_Description.BackColor = System.Drawing.Color.White;
            this.textBox_Description.Location = new System.Drawing.Point(12, 92);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(452, 19);
            this.textBox_Description.TabIndex = 4;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(97, 124);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "O　K";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(304, 124);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "キャンセル";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // SelectFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 164);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.button_Reference);
            this.Controls.Add(this.textBox_Folder);
            this.Controls.Add(this.label1);
            this.Name = "SelectFolder";
            this.Text = "SelectFolder - BackupHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Folder;
        private System.Windows.Forms.Button button_Reference;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}