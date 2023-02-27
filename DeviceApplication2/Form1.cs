using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DeviceApplication2
{
    public partial class Form1 : Form
    {
        int val;
        TimeHandler tm;
        bool ticktimer = false;
        List<Thread> runningThreads;
        private delegate void UpdateGUI();
        public Form1()
        {
            InitializeComponent();
            val = 0;
            tm = new TimeHandler(this);
            runningThreads = new List<Thread>();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticktimer)
            {
                tm.incSec();
                //Console.WriteLine("TICK");
                updateAsynch();
            }
        }
    }
}
