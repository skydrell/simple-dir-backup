using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace simple_dir_backup
{
    class Config
    {
        public string lastSourcePath;
        public string lastDestPath;
        public byte copyMode;

        public Config()
        {
            /*try
            {
                string[] configFileContent = File.ReadAllLines("config");
                lastSourcePath = configFileContent[0];
                lastDestPath = configFileContent[1];
            } catch (Exception)
            {
                string[] a = { "", "" };
                File.WriteAllLines("config", a);
            }*/
            readConfig();
        }

        public void readConfig()
        {
            this.lastSourcePath = Properties.Settings.Default.source;
            this.lastDestPath = Properties.Settings.Default.destination;
            this.copyMode = Properties.Settings.Default.copyMode;
        }

        public void saveConfigOld(string source, string dest)
        {
            try
            {
                string[] content = { source, dest };
                File.WriteAllLines("config", content);
            } catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Failed to write to file");
            }
        }

        public void saveConfig(string source, string destination, byte copyMode)
        {
            Properties.Settings.Default.source = source;
            Properties.Settings.Default.destination = destination;
            Properties.Settings.Default.copyMode = copyMode;
            Properties.Settings.Default.Save();
        }
    }
}
