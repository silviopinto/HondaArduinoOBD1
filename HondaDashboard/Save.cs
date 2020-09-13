using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HondaDashboard
{

    public class Save
    {

        public string path = @"C:\Temp\";
        public string file = "config.cfg";

        public bool VerifySave()
        {
            bool saveExist = false;

            if (File.Exists(path + file))
            {
                saveExist = true;
            }
            return saveExist;
        }


        public string ReadSave()
        {
            string config = File.ReadAllText(path + file);
            
            return config;

        }


        public void WriteSave(string configtext)
        {
            
            bool exists = System.IO.Directory.Exists(path);

                if (!exists)
                    System.IO.Directory.CreateDirectory(path);
            try
            {
                File.WriteAllText(path+file, configtext);
                System.Windows.Forms.MessageBox.Show("Saved with success!");
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Something went wrong when try save");
                Console.WriteLine(e);
            }
                        
            
        }
    }
}
