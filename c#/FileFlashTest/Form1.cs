using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace FileFlashTest
{
    public partial class Form1 : Form
    {
        int val;
        private readonly int SETTINGS_COUNT = 3;
        bool ticktimer = false;
        List<Thread> runningThreads;
        private string path = "C:\\Users\\marku\\Desktop\\FlashWearApp-main\\DeviceApplication2\\DeviceApplication2\\Files";
        private string config_path;
        private delegate void UpdateGUI();

        public Form1()
        {
            InitializeComponent();
            val = 0;
            runningThreads = new List<Thread>();
        }

        public void updateAsynch()
        {
            if (InvokeRequired)
            {
                Invoke(new UpdateGUI(update));
            }
        }

        private void update()
        {
            System.Diagnostics.Trace.WriteLine("Update! Val: " + val);
            //Console.WriteLine("UPDATE");
            val += 1;
            label1.Text = Convert.ToString(val);
            label1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Thread t in runningThreads)
            {
                t.Join();
            }
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            FileThread ft = new FileThread(this, path);
            ft.Mode = 0;
            Thread t = new Thread(new ThreadStart(ft.FileProc));
            runningThreads.Add(t);
            t.Start();
            System.Diagnostics.Trace.WriteLine("Started create!");
            ticktimer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pathTextBox.Text = path;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            path = pathTextBox.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FileThread ft = new FileThread(this, path);
            ft.Mode = 1;
            Thread t = new Thread(new ThreadStart(ft.FileProc));
            runningThreads.Add(t);
            t.Start();
            System.Diagnostics.Trace.WriteLine("Started write!");
            ticktimer = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileThread ft = new FileThread(this, path);
            ft.Mode = 2;
            Thread t = new Thread(new ThreadStart(ft.FileProc));
            runningThreads.Add(t);
            t.Start();
            System.Diagnostics.Trace.WriteLine("Started delete!");
            ticktimer = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog ofd = (OpenFileDialog)sender;
            config_path = ofd.FileName;
            List<string> vals = new List<string>();
            foreach (string line in System.IO.File.ReadLines(config_path))
            {
                string[] splitres = line.Split('=');
                if(splitres.Length > 1)
                {
                    string val = splitres[1];
                    vals.Add(val);
                }
            }

            fileCountBox.Text = vals[0];
            nbrThreadsBox.Text = vals[1];
            writeSizeBox.Text = vals[2];
            Config.Filecount = Convert.ToInt32(vals[0]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.OpenFile();
            DialogResult d = this.openFileDialog1.ShowDialog();
            string s = "";
        }

        private void fileCountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                TextBox tb = (TextBox)sender;
                switch(tb.Name)
                {
                    case "fileCountBox":
                        Config.Filecount = Convert.ToInt32(fileCountBox.Text);
                        break;
                }
                File.WriteAllText(config_path, String.Empty);
                string[] lines = new string[] { filecountlabel.Text + "=" + Config.Filecount, nbrthreadslabel.Text+"="+nbrThreadsBox.Text,
                                            writesizelabel.Text+"="+nbrThreadsBox.Text};
                File.WriteAllLines(config_path, lines);
                savelabel.Text = "Save to file completed.";
            }
            
           
        }
    }
}
