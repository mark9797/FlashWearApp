namespace DeviceApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.configLabel9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.configLabel5 = new System.Windows.Forms.Label();
            this.configLabel4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.configLabel8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.configLabel7 = new System.Windows.Forms.Label();
            this.configLabel6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.configLabel3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.configLabel2 = new System.Windows.Forms.Label();
            this.configLabel1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createConfigFileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.configFilePathBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(406, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 48);
            this.label1.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Quit";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(483, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(307, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "Write";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 455);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.sLabel);
            this.tabPage1.Controls.Add(this.minLabel);
            this.tabPage1.Controls.Add(this.hourLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(790, 426);
            this.tabPage1.Text = "Main";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(442, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 30);
            this.label6.Text = "s";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(387, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 30);
            this.label5.Text = "m";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(337, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 30);
            this.label4.Text = "h";
            // 
            // sLabel
            // 
            this.sLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.sLabel.Location = new System.Drawing.Point(411, 40);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(34, 30);
            this.sLabel.Text = "00";
            // 
            // minLabel
            // 
            this.minLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.minLabel.Location = new System.Drawing.Point(358, 40);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(34, 30);
            this.minLabel.Text = "00";
            // 
            // hourLabel
            // 
            this.hourLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.hourLabel.Location = new System.Drawing.Point(305, 40);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(34, 30);
            this.hourLabel.Text = "00";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.configLabel9);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.configLabel5);
            this.tabPage2.Controls.Add(this.configLabel4);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.configLabel8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.configLabel7);
            this.tabPage2.Controls.Add(this.configLabel6);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.configLabel3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.configLabel2);
            this.tabPage2.Controls.Add(this.configLabel1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.createConfigFileButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.configFilePathBox);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(790, 426);
            this.tabPage2.Text = "Config";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(460, 141);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 23);
            this.textBox9.TabIndex = 35;
            this.textBox9.GotFocus += new System.EventHandler(this.textBox9_GotFocus);
            // 
            // configLabel9
            // 
            this.configLabel9.Location = new System.Drawing.Point(302, 144);
            this.configLabel9.Name = "configLabel9";
            this.configLabel9.Size = new System.Drawing.Size(159, 20);
            this.configLabel9.Text = "configLabel9";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(172, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 31;
            this.textBox5.GotFocus += new System.EventHandler(this.textBox5_GotFocus);
            // 
            // configLabel5
            // 
            this.configLabel5.Location = new System.Drawing.Point(14, 185);
            this.configLabel5.Name = "configLabel5";
            this.configLabel5.Size = new System.Drawing.Size(159, 20);
            this.configLabel5.Text = "configLabel5";
            // 
            // configLabel4
            // 
            this.configLabel4.Location = new System.Drawing.Point(14, 141);
            this.configLabel4.Name = "configLabel4";
            this.configLabel4.Size = new System.Drawing.Size(152, 20);
            this.configLabel4.Text = "configLabel4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 30;
            this.textBox4.GotFocus += new System.EventHandler(this.textBox4_GotFocus);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(460, 102);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 20;
            this.textBox8.GotFocus += new System.EventHandler(this.textBox8_GotFocus);
            // 
            // configLabel8
            // 
            this.configLabel8.Location = new System.Drawing.Point(302, 105);
            this.configLabel8.Name = "configLabel8";
            this.configLabel8.Size = new System.Drawing.Size(152, 20);
            this.configLabel8.Text = "configLabel8";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(460, 59);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 19;
            this.textBox7.GotFocus += new System.EventHandler(this.textBox7_GotFocus);
            // 
            // configLabel7
            // 
            this.configLabel7.Location = new System.Drawing.Point(302, 62);
            this.configLabel7.Name = "configLabel7";
            this.configLabel7.Size = new System.Drawing.Size(159, 20);
            this.configLabel7.Text = "configLabel7";
            // 
            // configLabel6
            // 
            this.configLabel6.Location = new System.Drawing.Point(302, 18);
            this.configLabel6.Name = "configLabel6";
            this.configLabel6.Size = new System.Drawing.Size(152, 20);
            this.configLabel6.Text = "configLabel6";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(460, 18);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 18;
            this.textBox6.GotFocus += new System.EventHandler(this.textBox6_GotFocus);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 14;
            this.textBox3.GotFocus += new System.EventHandler(this.textBox3_GotFocus);
            // 
            // configLabel3
            // 
            this.configLabel3.Location = new System.Drawing.Point(14, 105);
            this.configLabel3.Name = "configLabel3";
            this.configLabel3.Size = new System.Drawing.Size(152, 20);
            this.configLabel3.Text = "configLabel3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 11;
            this.textBox2.GotFocus += new System.EventHandler(this.textBox2_GotFocus);
            // 
            // configLabel2
            // 
            this.configLabel2.Location = new System.Drawing.Point(14, 62);
            this.configLabel2.Name = "configLabel2";
            this.configLabel2.Size = new System.Drawing.Size(159, 20);
            this.configLabel2.Text = "configLabel2";
            // 
            // configLabel1
            // 
            this.configLabel1.Location = new System.Drawing.Point(14, 18);
            this.configLabel1.Name = "configLabel1";
            this.configLabel1.Size = new System.Drawing.Size(152, 20);
            this.configLabel1.Text = "configLabel1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            // 
            // createConfigFileButton
            // 
            this.createConfigFileButton.Location = new System.Drawing.Point(671, 383);
            this.createConfigFileButton.Name = "createConfigFileButton";
            this.createConfigFileButton.Size = new System.Drawing.Size(116, 40);
            this.createConfigFileButton.TabIndex = 4;
            this.createConfigFileButton.Text = "Create Config File";
            this.createConfigFileButton.Click += new System.EventHandler(this.createConfigFileButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(229, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.Text = "Config file path";
            // 
            // configFilePathBox
            // 
            this.configFilePathBox.Location = new System.Drawing.Point(333, 397);
            this.configFilePathBox.Name = "configFilePathBox";
            this.configFilePathBox.ReadOnly = true;
            this.configFilePathBox.Size = new System.Drawing.Size(257, 23);
            this.configFilePathBox.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(596, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "Load file";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(0, 0);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 23);
            this.textBox10.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(798, 455);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label configLabel9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label configLabel5;
        private System.Windows.Forms.Label configLabel4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label configLabel8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label configLabel7;
        private System.Windows.Forms.Label configLabel6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label configLabel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label configLabel2;
        private System.Windows.Forms.Label configLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button createConfigFileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox configFilePathBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox10;

    }
}

