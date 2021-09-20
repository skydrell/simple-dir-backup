using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using simple_dir_backup;
using System.Collections.Generic;

namespace simple_dir_backup
{
    public partial class Form1 : Form
    {
        private string sourcePath;
        private string destPath;
        private int progress;
        private bool isBackuping;
        private int newfile;
        private int modifiedFile;
        private Thread td;
        private Config config;

        public Form1()
        {
            InitializeComponent();
            config = new Config();
            sourcePath = config.lastSourcePath;
            destPath = config.lastDestPath;
            sourceTxt.Text = sourcePath;
            destTxt.Text = destPath;
        }

        private void sourceBrowseBtn_Click(object sender, EventArgs e)
        {
            sourceFolderDialog.ShowDialog();
            sourcePath = sourceFolderDialog.SelectedPath;
            sourceTxt.Text = sourcePath;
        }

        private void destBrowseBtn_Click(object sender, EventArgs e)
        {
            destFolderDialog.ShowDialog();
            destPath = destFolderDialog.SelectedPath;
            destTxt.Text = destPath;
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            if (backupBtn.Text == "BACKUP")
            {
                if (sourcePath == null || destPath == null)
                {
                    MessageBox.Show("Source path and/or destination path is empty");
                }
                else
                {
                    backupBtn.Text = "ABORT";
                    td = new Thread(new ThreadStart(backup2));
                    this.isBackuping = true;
                    td.Start();
                    timer1.Enabled = true;
                }
            }
            else if (backupBtn.Text == "ABORT")
            {
                isBackuping = false;
                timer1.Enabled = false;
                MessageBox.Show("Backup aborted", "Aborted", MessageBoxButtons.OK);
                progressBar1.Value = 0;
                statusLbl.Text = "";
                progress = 0;
                newfile = 0;
                modifiedFile = 0;
                backupBtn.Text = "BACKUP";
            }
            else if (backupBtn.Text == "DONE")
            {
                progressBar1.Value = 0;
                statusLbl.Text = "";
                progress = 0;
                isBackuping = false;
                newfile = 0;
                modifiedFile = 0;
                td = null;
                backupBtn.Text = "BACKUP";
            }
        }

        private void backup(){
            this.isBackuping = true;
            int newFile = 0;
            int modifiedFile = 0;
            int fileDone = 0;
            string[] sourceFilesPath = Directory.GetFileSystemEntries(sourcePath, "*", SearchOption.AllDirectories);
            int fileCount = sourceFilesPath.Length;
            foreach (var file in sourceFilesPath)
            {
                DirectoryInfo sourceFolder = new DirectoryInfo(sourcePath);
                // MessageBox.Show($"file: {file} source: {sourceFolder.Name} dest: {destFolder.Name}");
                string destFilePath = destPath + "\\" + file.Substring(sourcePath.Length + 1);
                if (sourceFolder.Root.ToString() == sourceFolder.Name)
                {
                    destFilePath = destPath + "\\" + file.Substring(2);
                }
                // MessageBox.Show(destFilePath);
                // COPY FILE --> try utk copy, kalau sdh ada file nya, 
                // cek modified time nya dan dibandingin, yg baru yg di keep
                FileInfo destInfo = new FileInfo(destFilePath);
                FileInfo sourceInfo = new FileInfo(file);
                destInfo.Directory.Create();
                try
                {
                    File.Copy(file, destFilePath);
                    newFile++;
                }
                catch (Exception)
                {
                    try
                    {
                        if (sourceInfo.LastWriteTime > destInfo.LastWriteTime && sourceInfo.Exists == true)
                        {
                            File.Copy(file, destFilePath, true);
                            modifiedFile++;
                        }
                    }
                    catch (Exception e)
                    {
                        if (!e.GetType().Equals(typeof(UnauthorizedAccessException)))
                        {
                            MessageBox.Show($"Message: {e.Message}\nStack Trace:\n{e.StackTrace}\nType:{e.GetType().ToString()}");
                            //throw e;
                        }
                    }
                }
                fileDone++;
                float progress = (float)fileDone / (float)fileCount * (float)100;
                this.progress = (int)progress;
            }
            this.newfile = newFile;
            this.modifiedFile = modifiedFile;
            isBackuping = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progress;
            if (statusLbl.Text != "Done" && !isBackuping)
            {
                statusLbl.Text = "Done";
                timer1.Enabled = false;
                string message = $"{newfile} new files and {modifiedFile} modified files copied.";
                backupBtn.Text = "DONE";
                endMessage("finished");
            }
            if (statusLbl.Text != "Backup in progress" && isBackuping)
            {
                statusLbl.Text = "Backup in progress";
            }
        }

        private void endMessage(string message)
        {
            switch (message)
            {
                case "aborted":
                    MessageBox.Show("Backup aborted", "Aborted", MessageBoxButtons.OK);
                    break;
                case "finished":
                    MessageBox.Show($"{newfile} new file(s) and {modifiedFile} modified file(s) copied","Backup Finished", MessageBoxButtons.OK);
                    break;
            }
        }

        private void aboutMenu_clicked(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            isBackuping = false; //this will make the thread finishes their job
            config.saveConfig(sourcePath, destPath);
        }


        private void backup2()
        {
            int newFile = 0;
            int modifiedFile = 0;
            int fileDone = 0;
            string[] sourceFilesPath = Directory.GetFileSystemEntries(sourcePath, "*", SearchOption.AllDirectories);
            int fileCount = sourceFilesPath.Length;
            DirectoryInfo sourceFolder = new DirectoryInfo(sourcePath);
            foreach (var file in sourceFilesPath)
            {
                if (!isBackuping)
                {
                    this.newfile = 0;
                    this.modifiedFile = 0;
                    fileDone = 0;
                    this.progress = 0;
                }
                string destFilePath = destPath + "\\" + file.Substring(sourcePath.Length + 1);
                if (sourceFolder.Root.ToString() == sourceFolder.Name)
                {
                    destFilePath = destPath + "\\" + file.Substring(2);
                }
                FileInfo destInfo = new FileInfo(destFilePath);
                FileInfo sourceInfo = new FileInfo(file);
                destInfo.Directory.Create();
                if (Directory.Exists(file))
                {
                    fileDone++;
                    continue;
                }
                if (!destInfo.Exists)
                {
                    try
                    {
                        File.Copy(file, destFilePath);
                        newFile++;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                } else if (sourceInfo.LastWriteTime <= destInfo.LastWriteTime)
                {
                    fileDone++;
                    float prog = (float)fileDone / (float)fileCount * (float)100;
                    this.progress = (int)prog;
                    continue;
                } else if (sourceInfo.LastWriteTime > destInfo.LastWriteTime)
                {
                    try
                    {
                        File.Copy(file, destFilePath, true);
                        modifiedFile++;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
                fileDone++;
                float progress = (float)fileDone / (float)fileCount * (float)100;
                this.progress = (int)progress;
            }
            this.newfile = newFile;
            this.modifiedFile = modifiedFile;
            isBackuping = false;
        }
    }
}
