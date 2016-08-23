namespace FolderClassification
{
    partial class Form1
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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.cboxExtension = new System.Windows.Forms.ComboBox();
            this.lstSelectedFiles = new System.Windows.Forms.ListBox();
            this.SelectedPathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbFileTypeOption = new System.Windows.Forms.RadioButton();
            this.rdbExtensionOption = new System.Windows.Forms.RadioButton();
            this.cboxFileType = new System.Windows.Forms.ComboBox();
            this.fldOptions = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkboxFileName = new System.Windows.Forms.CheckBox();
            this.txtboxFileName = new System.Windows.Forms.TextBox();
            this.rdbOther = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.lblDestinationPath = new System.Windows.Forms.Label();
            this.btnDestinationFolder = new System.Windows.Forms.Button();
            this.fldOptions.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(6, 18);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(93, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "SelectFolder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboxExtension
            // 
            this.cboxExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxExtension.FormattingEnabled = true;
            this.cboxExtension.Items.AddRange(new object[] {
            "None"});
            this.cboxExtension.Location = new System.Drawing.Point(414, 17);
            this.cboxExtension.Name = "cboxExtension";
            this.cboxExtension.Size = new System.Drawing.Size(86, 20);
            this.cboxExtension.TabIndex = 2;
            // 
            // lstSelectedFiles
            // 
            this.lstSelectedFiles.FormattingEnabled = true;
            this.lstSelectedFiles.ItemHeight = 12;
            this.lstSelectedFiles.Location = new System.Drawing.Point(6, 18);
            this.lstSelectedFiles.Name = "lstSelectedFiles";
            this.lstSelectedFiles.Size = new System.Drawing.Size(546, 208);
            this.lstSelectedFiles.TabIndex = 3;
            // 
            // SelectedPathLabel
            // 
            this.SelectedPathLabel.AutoSize = true;
            this.SelectedPathLabel.Location = new System.Drawing.Point(105, 23);
            this.SelectedPathLabel.Name = "SelectedPathLabel";
            this.SelectedPathLabel.Size = new System.Drawing.Size(0, 12);
            this.SelectedPathLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 5;
            // 
            // rdbFileTypeOption
            // 
            this.rdbFileTypeOption.AutoSize = true;
            this.rdbFileTypeOption.Checked = true;
            this.rdbFileTypeOption.Location = new System.Drawing.Point(6, 18);
            this.rdbFileTypeOption.Name = "rdbFileTypeOption";
            this.rdbFileTypeOption.Size = new System.Drawing.Size(122, 16);
            this.rdbFileTypeOption.TabIndex = 6;
            this.rdbFileTypeOption.TabStop = true;
            this.rdbFileTypeOption.Text = "Search by FileType";
            this.rdbFileTypeOption.UseVisualStyleBackColor = true;
            // 
            // rdbExtensionOption
            // 
            this.rdbExtensionOption.AutoSize = true;
            this.rdbExtensionOption.Location = new System.Drawing.Point(280, 18);
            this.rdbExtensionOption.Name = "rdbExtensionOption";
            this.rdbExtensionOption.Size = new System.Drawing.Size(128, 16);
            this.rdbExtensionOption.TabIndex = 7;
            this.rdbExtensionOption.TabStop = true;
            this.rdbExtensionOption.Text = "Search by Extension";
            this.rdbExtensionOption.UseVisualStyleBackColor = true;
            // 
            // cboxFileType
            // 
            this.cboxFileType.BackColor = System.Drawing.SystemColors.Window;
            this.cboxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFileType.FormattingEnabled = true;
            this.cboxFileType.Items.AddRange(new object[] {
            "None"});
            this.cboxFileType.Location = new System.Drawing.Point(134, 17);
            this.cboxFileType.Name = "cboxFileType";
            this.cboxFileType.Size = new System.Drawing.Size(140, 20);
            this.cboxFileType.TabIndex = 8;
            // 
            // fldOptions
            // 
            this.fldOptions.Controls.Add(this.btnSearch);
            this.fldOptions.Controls.Add(this.groupBox4);
            this.fldOptions.Controls.Add(this.rdbOther);
            this.fldOptions.Controls.Add(this.rdbFileTypeOption);
            this.fldOptions.Controls.Add(this.cboxFileType);
            this.fldOptions.Controls.Add(this.rdbExtensionOption);
            this.fldOptions.Controls.Add(this.cboxExtension);
            this.fldOptions.Location = new System.Drawing.Point(12, 72);
            this.fldOptions.Name = "fldOptions";
            this.fldOptions.Size = new System.Drawing.Size(558, 100);
            this.fldOptions.TabIndex = 9;
            this.fldOptions.TabStop = false;
            this.fldOptions.Text = "2. Select options and search folder";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(442, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 40);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkboxFileName);
            this.groupBox4.Controls.Add(this.txtboxFileName);
            this.groupBox4.Location = new System.Drawing.Point(6, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 46);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Option";
            // 
            // chkboxFileName
            // 
            this.chkboxFileName.AutoSize = true;
            this.chkboxFileName.Location = new System.Drawing.Point(6, 18);
            this.chkboxFileName.Name = "chkboxFileName";
            this.chkboxFileName.Size = new System.Drawing.Size(119, 16);
            this.chkboxFileName.TabIndex = 9;
            this.chkboxFileName.Text = "Filter by FileName";
            this.chkboxFileName.UseVisualStyleBackColor = true;
            this.chkboxFileName.CheckedChanged += new System.EventHandler(this.chkboxFileName_CheckedChanged);
            // 
            // txtboxFileName
            // 
            this.txtboxFileName.Location = new System.Drawing.Point(128, 16);
            this.txtboxFileName.Name = "txtboxFileName";
            this.txtboxFileName.Size = new System.Drawing.Size(296, 19);
            this.txtboxFileName.TabIndex = 12;
            // 
            // rdbOther
            // 
            this.rdbOther.AutoSize = true;
            this.rdbOther.Location = new System.Drawing.Point(506, 18);
            this.rdbOther.Name = "rdbOther";
            this.rdbOther.Size = new System.Drawing.Size(51, 16);
            this.rdbOther.TabIndex = 11;
            this.rdbOther.TabStop = true;
            this.rdbOther.Text = "Other";
            this.rdbOther.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.SelectedPathLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSelectedFiles);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 238);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMove);
            this.groupBox3.Controls.Add(this.lblDestinationPath);
            this.groupBox3.Controls.Add(this.btnDestinationFolder);
            this.groupBox3.Location = new System.Drawing.Point(12, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 53);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Select destination folder and move the selected files";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(459, 18);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(93, 23);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "Move!!";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.lblDestinationPath.Location = new System.Drawing.Point(105, 23);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(0, 12);
            this.lblDestinationPath.TabIndex = 5;
            // 
            // btnDestinationFolder
            // 
            this.btnDestinationFolder.Location = new System.Drawing.Point(6, 18);
            this.btnDestinationFolder.Name = "btnDestinationFolder";
            this.btnDestinationFolder.Size = new System.Drawing.Size(93, 23);
            this.btnDestinationFolder.TabIndex = 2;
            this.btnDestinationFolder.Text = "SelectFolder";
            this.btnDestinationFolder.UseVisualStyleBackColor = true;
            this.btnDestinationFolder.Click += new System.EventHandler(this.btnDestinationFolder_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 497);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fldOptions);
            this.Name = "Form1";
            this.Text = "WakeruKun";
            this.fldOptions.ResumeLayout(false);
            this.fldOptions.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.ComboBox cboxExtension;
        private System.Windows.Forms.ListBox lstSelectedFiles;
        private System.Windows.Forms.Label SelectedPathLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbFileTypeOption;
        private System.Windows.Forms.RadioButton rdbExtensionOption;
        private System.Windows.Forms.ComboBox cboxFileType;
        private System.Windows.Forms.GroupBox fldOptions;
        private System.Windows.Forms.CheckBox chkboxFileName;
        private System.Windows.Forms.RadioButton rdbOther;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtboxFileName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDestinationPath;
        private System.Windows.Forms.Button btnDestinationFolder;
        private System.Windows.Forms.Button btnMove;
    }
}

