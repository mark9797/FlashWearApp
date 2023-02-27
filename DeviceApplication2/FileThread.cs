using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;


namespace DeviceApplication2
{
    public class FileThread
    {
        Form1 f;
        int mode;
        public FileThread(Form1 f)
        {
            this.f = f;
        }

        public int Mode
        {
            get { return this.mode; }
            set { mode = value; }
        }

        public void FileProc()
        {
            for (int i = 0; i < 10; i++)
            {                
                String pathname = "Storage Card/test" + i;
                switch (mode)
                {
                    case 0: //Create 
                        createFile(pathname);
                        break;
                    case 1: //Write
                        writeFile(pathname);
                        break;
                    case 2: //Delete
                        deleteFile(pathname);
                        break;
                    default: //Nothing
                        break;
                }
                //f.updateAsynch();
                //createFile(pathname);
                //deleteFile(pathname);   
                Thread.Sleep(1000);

            }
        }

        public void createFile(string name)
        {
            try
            {
                FileStream fs = File.Create(name);
                //File.OpenWrite(pathname);
                //File.WriteAllText(pathname, "hello world");
                fs.Close();
                System.Diagnostics.Trace.WriteLine("Created file " + name);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception thrown when creating file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            


        }

        public void writeFile(string name)
        {
            if (File.Exists(name)) { 
                using (StreamWriter writer = File.CreateText(name))
                {
                    writer.WriteLine("hello world");
                }
                System.Diagnostics.Trace.WriteLine("Wrote file " + name);
            }
            else
            {
                MessageBox.Show("File " + name + " does not exist.", "No file when writing", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }
        public void deleteFile(string name)
        {
            if (File.Exists(name))
            {
                if (File.Exists(name))
                {
                    File.Delete(name);
                }
                System.Diagnostics.Trace.WriteLine("Deleted file " + name);
            }
            else
            {
                MessageBox.Show("File " + name + " does not exist.", "No file when deleting", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
           
        }

    }
}
