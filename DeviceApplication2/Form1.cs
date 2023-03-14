using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace DeviceApplication2
{
    public partial class Form1 : Form
    {
        int val;
        TimeHandler tm;
        bool ticktimer = false;
        List<Thread> runningThreads;
        private CustomKeyBoard keyboard;
        private TextBox selectedTextBox;

        private int filesCreated = 0;
        private int iteration = 0;
        private int major_iteration = 0;
        private int bytes_written = 0;
        private delegate void UpdateGUI();

        public Form1()
        {
            InitializeComponent();
            val = 0;
            tm = new TimeHandler(this);
            runningThreads = new List<Thread>();
            keyboard = new CustomKeyBoard();
            keyboard.CustomKeyBoardKeyPress += CustomKeyBoardKeyPressed;
          //  this.Controls.Add(keyboard);
           // keyboard.BringToFront();
            keyboard.Visible = false;
            keyboard.Location = new Point(627, 27);
            if (File.Exists(Config.ConfigFilePath))
            {
                createConfigFileButton.Enabled = false;
                createConfigFileButton.Visible = false;
                configFilePathBox.Text = Config.ConfigFilePath;
                updateConfigValues();
            }
            else
            {
                configFilePathBox.Text = "N/A";
            }
            createConfigLabels();
            setTextBoxValues();
        }

        private void updateConfigValues()
        {
            using (StreamReader sr = new StreamReader(Config.ConfigFilePath))
            {
                for (int i = 0; i < Config.headers.Length; i++)
                {
                    string line = sr.ReadLine();
                    string[] splitVal = line.Split('=');
                    if (splitVal.Length > 1)
                    {
                        int val = Convert.ToInt32(splitVal[1]);
                        Config.current_values[i] = val;
                    }
                    else {
                        Config.current_values[i] = 0;
                    }
                }
            }
        }

        private void setTextBoxValues()
        {
            textBox1.Text = Config.current_values[0].ToString();
            textBox2.Text = Config.current_values[1].ToString();
            textBox3.Text = Config.current_values[2].ToString();
            textBox4.Text = Config.current_values[3].ToString();
            textBox5.Text = Config.current_values[4].ToString();
            textBox6.Text = Config.current_values[5].ToString();
            textBox7.Text = Config.current_values[6].ToString();
            textBox8.Text = Config.current_values[7].ToString();
            textBox9.Text = Config.current_values[8].ToString();

        }
        private void createConfigLabels()
        {
            configLabel1.Text = Config.headers[0];
            configLabel2.Text = Config.headers[1];
            configLabel3.Text = Config.headers[2];
            configLabel4.Text = Config.headers[3];
            configLabel5.Text = Config.headers[4];
            configLabel6.Text = Config.headers[5];
            configLabel7.Text = Config.headers[6];
            configLabel8.Text = Config.headers[7];
            configLabel9.Text = Config.headers[8];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileThread ft = new FileThread(this);
            ft.Mode = 0;
            Thread t = new Thread(new ThreadStart(ft.FileProc));
            runningThreads.Add(t);
            t.Start();
            System.Diagnostics.Trace.WriteLine("Started create!");
            ticktimer = true;
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Thread t in runningThreads)
            {
                t.Join();
            }
            Application.Exit();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            FileThread ft = new FileThread(this);
            ft.Mode = 1;
            Thread t = new Thread(new ThreadStart(ft.FileProc));
            runningThreads.Add(t);
            t.Start();
            System.Diagnostics.Trace.WriteLine("Started write!");
            ticktimer = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FileThread ft = new FileThread(this);
            ft.Mode = 2;
            Thread t = new Thread(new ThreadStart(ft.FileProc));
            runningThreads.Add(t);
            t.Start();
            System.Diagnostics.Trace.WriteLine("Started delete!");
            ticktimer = true;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            updateConfigFilePath(configFilePathBox.Text);

        }

        private void updateConfigFilePath(string newPath)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            Config.ConfigFilePath = path;
            configFilePathBox.Text = path;
        }

        private void createConfigFileButton_Click(object sender, EventArgs e)
        {
            createConfigFile();
        }

        private void createConfigFile()
        {
            try
            {
                FileStream fs = File.Create(Config.ConfigFilePath);
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Exception thrown when creating file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            using(StreamWriter sw = File.CreateText(Config.ConfigFilePath)) {
                for (int i = 0; i < Config.headers.Length; i++)
                {
                    try
                    {
                        sw.WriteLine(Config.headers[i] + Convert.ToString(Config.default_values[i]));
                    }
                    catch
                    {
                        MessageBox.Show("Exception thrown when creating file and writing to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        break;
                    }
                }
            }
            configFilePathBox.Text = Config.ConfigFilePath;
            createConfigFileButton.Enabled = false;
            createConfigFileButton.Visible = false;
        }

        private void CustomKeyBoardKeyPressed(object sender, CustomKeyBoardPressEventArgs e) {
            if (e.KeyVal < 10)
            {
                selectedTextBox.Text = selectedTextBox.Text + Convert.ToString(e.KeyVal);
            }
            else if(e.KeyVal == 10)
            {
                if (selectedTextBox.Text.Length > 0)
                {
                    selectedTextBox.Text = selectedTextBox.Text.Remove(selectedTextBox.Text.Length - 1, 1);
                }
            }
            else if (e.KeyVal == 11)
            {
                keyBoardOkPressed();
            } 
        }

        private void handleTextBoxClick(object sender, EventArgs e)
        {
            if (keyboard.Visible == true)
            {
                return;
            }
            TextBox tb = (TextBox)sender;
            System.Diagnostics.Trace.WriteLine("Textbox: " + tb.Name + " clicked!");
            selectedTextBox = tb;
            tb.Text = "";
            this.Controls.Add(keyboard);
            keyboard.Visible = true;
            keyboard.BringToFront();
            //keyboard.Show();
        }

        private void keyBoardOkPressed()
        {
            keyboard.Visible = false;
            if (selectedTextBox.Text == String.Empty)
            {
                selectedTextBox.Text = "0";
            }

            switch(selectedTextBox.Name) {
                case "textBox1":
                    Config.current_values[0] = Convert.ToInt32(selectedTextBox.Text);
                    break;
                case "textBox2":
                    Config.current_values[1] = Convert.ToInt32(selectedTextBox.Text);
                    break;
                case "textBox3":
                    Config.current_values[2] = Convert.ToInt32(selectedTextBox.Text);
                    break;
                case "textBox4":
                    Config.current_values[3] = Convert.ToInt32(selectedTextBox.Text);
                    break;
                case "textBox5":
                    Config.current_values[4] = Convert.ToInt32(selectedTextBox.Text);
                    break;
                case "textBox6":
                    Config.current_values[5] = Convert.ToInt32(selectedTextBox.Text);
                    break;
                case "textBox7":
                    Config.current_values[6] = Convert.ToInt32(selectedTextBox.Text);
                    break;
                case "textBox8":
                    Config.current_values[7] = Convert.ToInt32(selectedTextBox.Text);
                    break;
                case "textBox9":
                    Config.current_values[8] = Convert.ToInt32(selectedTextBox.Text);
                    break;
            }
            updateConfigFile();
        }

        private void updateConfigFile()
        {
            using (StreamWriter sw = File.CreateText(Config.ConfigFilePath)) {
                sw.Write(String.Empty);
                for (int i = 0; i < Config.headers.Length; i++)
                {
                    sw.WriteLine(Config.headers[i] + Config.current_values[i]);
                }

            }
        }

        public void incFilesCreatedAsynch()
        {
            if (InvokeRequired)
            {
                Invoke(new UpdateGUI(incFilesCreated));
            }
        }

        private void incFilesCreated()
        {
            this.filesCreated += 1;
            filesCreatedBox.Text = Convert.ToString(filesCreated);
        }

        public void incIterationAsynch(int val)
        {
            this.iteration = val;
            if (InvokeRequired)
            {
                Invoke(new UpdateGUI(incIteration));
            }
        }

        private void incIteration()
        {
            iterationBox.Text = Convert.ToString(iteration);
        }

        public void incMajorIterationAsynch(int val)
        {
            this.major_iteration = val;
            if (InvokeRequired)
            {
                Invoke(new UpdateGUI(incMajorIteration));
            }
        }

        private void incMajorIteration()
        {
            majIterationBox.Text = Convert.ToString(major_iteration);
        }

        public void incBytesWrittenAsynch(int val)
        {
            this.bytes_written += val;
            if (InvokeRequired)
            {
                Invoke(new UpdateGUI(incBytesWritten));
            }
        }

        private void incBytesWritten()
        {
            bytesWrittenBox.Text = Convert.ToString(bytes_written);
            if (bytes_written + Config.File_size > Config.Total_data_amount && Config.Total_data_amount > 0)
            {
                foreach (Thread t in runningThreads)
                {
                    t.Abort();
                }
                stopClock();
                MessageBox.Show("Test stopped since max total of written bytes (" + Convert.ToString(Config.Total_data_amount) + ") was reached.", "Max byte reached", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            FileThread ft = new FileThread(this);
            ft.Mode = 0;
            Thread t = new Thread(new ThreadStart(ft.FileProc));
            runningThreads.Add(t);
            t.Start();
            System.Diagnostics.Trace.WriteLine("Started create!");
            ticktimer = true;
       

        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Thread t in runningThreads)
            {
                t.Abort();
            }
            stopClock();
            System.Diagnostics.Trace.WriteLine("Test aborted!");

        }

        //Timer clock function handle
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

        public void updateTime(string s, string m, string h)
        {
            this.hourLabel.Text = h;
            this.minLabel.Text = m;
            this.sLabel.Text = s;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticktimer)
            {
                tm.incSec();
                //Console.WriteLine("TICK");
                updateAsynch();
            }
        }

        public void stopClock()
        {
            ticktimer = false;
            tm.reset();
        }
        //Got focus TextBox functions

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            handleTextBoxClick(sender, e);
        }

        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            handleTextBoxClick(sender, e);
        }

        private void textBox3_GotFocus(object sender, EventArgs e)
        {
            handleTextBoxClick(sender, e);
        }

        private void textBox4_GotFocus(object sender, EventArgs e)
        {
            handleTextBoxClick(sender, e);
        }

        private void textBox5_GotFocus(object sender, EventArgs e)
        {
            handleTextBoxClick(sender, e);
        }

        private void textBox6_GotFocus(object sender, EventArgs e)
        {
            handleTextBoxClick(sender, e);
        }

        private void textBox7_GotFocus(object sender, EventArgs e)
        {
            handleTextBoxClick(sender, e);
        }

        private void textBox8_GotFocus(object sender, EventArgs e)
        {
            handleTextBoxClick(sender, e);
        }

        private void textBox9_GotFocus(object sender, EventArgs e)
        {
            handleTextBoxClick(sender, e);
        }



    }
}
