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

        public Config()
        {
            try
            {
                string[] configFileContent = File.ReadAllLines("config");
                lastSourcePath = configFileContent[0];
                lastDestPath = configFileContent[1];
            } catch (Exception)
            {
                string[] a = { "", "" };
                File.WriteAllLines("config", a);
            }
        }

        public void saveConfig(string source, string dest)
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
    }
}
