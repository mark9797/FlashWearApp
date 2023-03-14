using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;


namespace DeviceApplication2
{
    public class FileThread
    {
        Form1 f;
        int mode;

        private readonly string LTR1024 = @"OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
                                            OOOOOOOOOOOOOOOOOOOOOOOO"; 
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
            //Stopwatch stopWatch = new Stopwatch();
           // stopWatch.Start();

            for (int i = 1; i <= Config.Major_iterations; i++)
            {
                f.incMajorIterationAsynch(i);
                for (int j = 1; j <= Config.Iterations; j++)
                {
                    String pathname = "Storage Card/test" + i + "_" + j + ".raw";
                    createFile(pathname);
                    writeFile(pathname);
                    f.incIterationAsynch(j);

                }
            }
            f.stopClock();
           // stopWatch.Stop();
           // System.Diagnostics.Trace.WriteLine("Done in: " + stopWatch.ElapsedMilliseconds.ToString());
        }
        /*
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
              */
        //f.updateAsynch();
        //createFile(pathname);
        //deleteFile(pathname);   
        //Thread.Sleep(1000);
        public void createFile(string name)
        {
            try
            {
                FileStream fs = File.Create(name);
                //File.OpenWrite(pathname);
                //File.WriteAllText(pathname, "hello world");
                fs.Close();
                System.Diagnostics.Trace.WriteLine("Created file " + name);
                f.incFilesCreatedAsynch();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception thrown when creating file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            


        }

        public void writeFile(string name)
        {
            //System.Diagnostics.Trace.WriteLine("ENTEREED WRITE FUNC");
            if (File.Exists(name)) { 
                using (StreamWriter writer = new StreamWriter(name, true, Encoding.UTF8, 102400))
                {
                    int mutl = Config.File_size / 1024;
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < mutl; i++)
                    {
                        writer.Write(LTR1024);
                       // sb.Append(LTR1024);
                    }
                    //System.Diagnostics.Trace.WriteLine("BEGIN WRITE");
                    writer.Write(sb.ToString());
                    //System.Diagnostics.Trace.WriteLine("WRITE DONE");

                    f.incBytesWrittenAsynch(Config.File_size);
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
