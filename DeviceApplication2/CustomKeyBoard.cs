using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DeviceApplication2
{
    public partial class CustomKeyBoard : UserControl
    {
        public EventHandler<CustomKeyBoardPressEventArgs> CustomKeyBoardKeyPress;
        private CustomKeyBoardPressEventArgs args;
        public CustomKeyBoard()
        {
            InitializeComponent();
            args = new CustomKeyBoardPressEventArgs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            args.KeyVal = 1;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            args.KeyVal = 0;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            args.KeyVal = 3;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            args.KeyVal = 2;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            args.KeyVal = 6;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            args.KeyVal = 5;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            args.KeyVal = 4;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            args.KeyVal = 9;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            args.KeyVal = 8;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            args.KeyVal = 7;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void buttonBS_Click(object sender, EventArgs e)
        {
            args.KeyVal = 10;
            CustomKeyBoardKeyPress(sender, args);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            args.KeyVal = 11;
            CustomKeyBoardKeyPress(sender, args);
        }
    }

    public class CustomKeyBoardPressEventArgs : EventArgs
    {
        private int keyVal = 0;

        public int KeyVal
        {
            get { return keyVal; }
            set { keyVal = value; }
        }
    }
}