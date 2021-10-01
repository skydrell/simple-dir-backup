
namespace simple_dir_backup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceTxt = new System.Windows.Forms.TextBox();
            this.sourceBrowseBtn = new System.Windows.Forms.Button();
            this.destTxt = new System.Windows.Forms.TextBox();
            this.destBrowseBtn = new System.Windows.Forms.Button();
            this.backupBtn = new System.Windows.Forms.Button();
            this.sourceFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.destFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.infoLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destination";
            // 
            // sourceTxt
            // 
            this.sourceTxt.Enabled = false;
            this.sourceTxt.Location = new System.Drawing.Point(115, 51);
            this.sourceTxt.Name = "sourceTxt";
            this.sourceTxt.Size = new System.Drawing.Size(389, 27);
            this.sourceTxt.TabIndex = 1;
            // 
            // sourceBrowseBtn
            // 
            this.sourceBrowseBtn.Location = new System.Drawing.Point(510, 50);
            this.sourceBrowseBtn.Name = "sourceBrowseBtn";
            this.sourceBrowseBtn.Size = new System.Drawing.Size(94, 29);
            this.sourceBrowseBtn.TabIndex = 2;
            this.sourceBrowseBtn.Text = "Browse";
            this.sourceBrowseBtn.UseVisualStyleBackColor = true;
            this.sourceBrowseBtn.Click += new System.EventHandler(this.sourceBrowseBtn_Click);
            // 
            // destTxt
            // 
            this.destTxt.Enabled = false;
            this.destTxt.Location = new System.Drawing.Point(115, 89);
            this.destTxt.Name = "destTxt";
            this.destTxt.Size = new System.Drawing.Size(389, 27);
            this.destTxt.TabIndex = 1;
            // 
            // destBrowseBtn
            // 
            this.destBrowseBtn.Location = new System.Drawing.Point(510, 88);
            this.destBrowseBtn.Name = "destBrowseBtn";
            this.destBrowseBtn.Size = new System.Drawing.Size(94, 29);
            this.destBrowseBtn.TabIndex = 2;
            this.destBrowseBtn.Text = "Browse";
            this.destBrowseBtn.UseVisualStyleBackColor = true;
            this.destBrowseBtn.Click += new System.EventHandler(this.destBrowseBtn_Click);
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(481, 199);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(128, 47);
            this.backupBtn.TabIndex = 3;
            this.backupBtn.Text = "BACKUP";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(13, 125);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(0, 20);
            this.infoLbl.TabIndex = 5;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(22, 165);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 20);
            this.statusLbl.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 199);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(462, 47);
            this.progressBar1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(64, 24);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_clicked);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Directory",
            "Content"});
            this.comboBox1.Location = new System.Drawing.Point(115, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item to copy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 258);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.destBrowseBtn);
            this.Controls.Add(this.sourceBrowseBtn);
            this.Controls.Add(this.destTxt);
            this.Controls.Add(this.sourceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Directory Backup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sourceTxt;
        private System.Windows.Forms.Button sourceBrowseBtn;
        private System.Windows.Forms.TextBox destTxt;
        private System.Windows.Forms.Button destBrowseBtn;
        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.FolderBrowserDialog sourceFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog destFolderDialog;
        private System.Windows.Forms.Label infoLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

