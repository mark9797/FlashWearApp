
namespace FileFlashTest
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.writeSizeBox = new System.Windows.Forms.TextBox();
            this.writesizelabel = new System.Windows.Forms.Label();
            this.nbrThreadsBox = new System.Windows.Forms.TextBox();
            this.nbrthreadslabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.fileCountBox = new System.Windows.Forms.TextBox();
            this.filecountlabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.savelabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.startButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(445, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(321, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "Write";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(198, 289);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 60);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.savelabel);
            this.tabPage2.Controls.Add(this.writeSizeBox);
            this.tabPage2.Controls.Add(this.writesizelabel);
            this.tabPage2.Controls.Add(this.nbrThreadsBox);
            this.tabPage2.Controls.Add(this.nbrthreadslabel);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.fileCountBox);
            this.tabPage2.Controls.Add(this.filecountlabel);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.pathTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // writeSizeBox
            // 
            this.writeSizeBox.Location = new System.Drawing.Point(93, 90);
            this.writeSizeBox.Name = "writeSizeBox";
            this.writeSizeBox.Size = new System.Drawing.Size(90, 20);
            this.writeSizeBox.TabIndex = 16;
            // 
            // writesizelabel
            // 
            this.writesizelabel.AutoSize = true;
            this.writesizelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writesizelabel.Location = new System.Drawing.Point(8, 91);
            this.writesizelabel.Name = "writesizelabel";
            this.writesizelabel.Size = new System.Drawing.Size(66, 16);
            this.writesizelabel.TabIndex = 15;
            this.writesizelabel.Text = "write_size";
            // 
            // nbrThreadsBox
            // 
            this.nbrThreadsBox.Location = new System.Drawing.Point(93, 52);
            this.nbrThreadsBox.Name = "nbrThreadsBox";
            this.nbrThreadsBox.Size = new System.Drawing.Size(90, 20);
            this.nbrThreadsBox.TabIndex = 14;
            // 
            // nbrthreadslabel
            // 
            this.nbrthreadslabel.AutoSize = true;
            this.nbrthreadslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrthreadslabel.Location = new System.Drawing.Point(8, 53);
            this.nbrthreadslabel.Name = "nbrthreadslabel";
            this.nbrthreadslabel.Size = new System.Drawing.Size(79, 16);
            this.nbrthreadslabel.TabIndex = 13;
            this.nbrthreadslabel.Text = "nbr_threads";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(343, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 43);
            this.button5.TabIndex = 11;
            this.button5.Text = "Load";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // fileCountBox
            // 
            this.fileCountBox.Location = new System.Drawing.Point(93, 19);
            this.fileCountBox.Name = "fileCountBox";
            this.fileCountBox.Size = new System.Drawing.Size(90, 20);
            this.fileCountBox.TabIndex = 10;
            this.fileCountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fileCountBox_KeyPress);
            // 
            // filecountlabel
            // 
            this.filecountlabel.AutoSize = true;
            this.filecountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filecountlabel.Location = new System.Drawing.Point(8, 20);
            this.filecountlabel.Name = "filecountlabel";
            this.filecountlabel.Size = new System.Drawing.Size(64, 16);
            this.filecountlabel.TabIndex = 9;
            this.filecountlabel.Text = "file_count";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(691, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(605, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(397, 20);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(190, 20);
            this.pathTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // savelabel
            // 
            this.savelabel.AutoSize = true;
            this.savelabel.Location = new System.Drawing.Point(340, 330);
            this.savelabel.Name = "savelabel";
            this.savelabel.Size = new System.Drawing.Size(0, 13);
            this.savelabel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filecountlabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox fileCountBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox writeSizeBox;
        private System.Windows.Forms.Label writesizelabel;
        private System.Windows.Forms.TextBox nbrThreadsBox;
        private System.Windows.Forms.Label nbrthreadslabel;
        private System.Windows.Forms.Label savelabel;
    }
}

