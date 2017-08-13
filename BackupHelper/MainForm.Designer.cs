namespace BackupHelper
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView_BackupFolder = new System.Windows.Forms.DataGridView();
            this.Drive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Drive = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Backup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BackupFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Remove);
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.dataGridView_BackupFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Drive);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "バックアップの設定";
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(300, 272);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 5;
            this.button_Remove.Text = "削　除";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(86, 272);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "追　加";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView_BackupFolder
            // 
            this.dataGridView_BackupFolder.AllowUserToAddRows = false;
            this.dataGridView_BackupFolder.AllowUserToDeleteRows = false;
            this.dataGridView_BackupFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_BackupFolder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drive,
            this.Description});
            this.dataGridView_BackupFolder.Location = new System.Drawing.Point(7, 105);
            this.dataGridView_BackupFolder.Name = "dataGridView_BackupFolder";
            this.dataGridView_BackupFolder.RowHeadersVisible = false;
            this.dataGridView_BackupFolder.RowTemplate.Height = 21;
            this.dataGridView_BackupFolder.Size = new System.Drawing.Size(448, 153);
            this.dataGridView_BackupFolder.TabIndex = 3;
            // 
            // Drive
            // 
            this.Drive.FillWeight = 30F;
            this.Drive.Frozen = true;
            this.Drive.HeaderText = "ドライブ名";
            this.Drive.Name = "Drive";
            this.Drive.ReadOnly = true;
            this.Drive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Drive.Width = 224;
            // 
            // Description
            // 
            this.Description.FillWeight = 70F;
            this.Description.Frozen = true;
            this.Description.HeaderText = "説明";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.Width = 224;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "バックアップ対象";
            // 
            // comboBox_Drive
            // 
            this.comboBox_Drive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Drive.FormattingEnabled = true;
            this.comboBox_Drive.Location = new System.Drawing.Point(7, 45);
            this.comboBox_Drive.Name = "comboBox_Drive";
            this.comboBox_Drive.Size = new System.Drawing.Size(448, 20);
            this.comboBox_Drive.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "バックアップ先ドライブ";
            // 
            // button_Backup
            // 
            this.button_Backup.Location = new System.Drawing.Point(206, 328);
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.Size = new System.Drawing.Size(75, 23);
            this.button_Backup.TabIndex = 6;
            this.button_Backup.Text = "バックアップ";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.button_Backup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 365);
            this.Controls.Add(this.button_Backup);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Main - BackupHelper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BackupFolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_BackupFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Drive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button button_Backup;
    }
}

