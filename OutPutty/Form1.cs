using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace OutPutty
{
    public partial class Form1 : Form
    {
        List<MyData> data;
        BindingSource src = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            data = new List<MyData>();

        }

        class MyData
        { 
            public string Adress { get; set; }
            //public string Cmd { get; set; }
            public string BytesRead { get; set; }
            public string BytesWritten { get; set; }

            public MyData(string adress, string bytesRead, string bytesWritten)
            {
                this.Adress = adress;
                this.BytesRead = bytesRead;
                this.BytesWritten = bytesWritten;
            }

            

        }

        int myDataCompare(MyData a, MyData b)
        {
            MyData temp1 = (MyData)a;
            MyData temp2 = (MyData)b;

            return temp1.Adress.CompareTo(temp2.Adress);


        }

        void addMyData(string add, string br, string bw)
        {
            MyData temp = null;
            foreach (MyData d in data)
            {
                if (d.Adress == add)
                {
                    temp = d;
                    break;
                }
            }
            if (temp == null)
            {
                temp = new MyData(add, br, bw);
                data.Add(temp);
            }
            else
            {
                int br_temp = Convert.ToInt32(temp.BytesRead);
                int bw_temp = Convert.ToInt32(temp.BytesWritten);
                temp.BytesRead = (br_temp + Convert.ToInt32(br)).ToString();
                temp.BytesWritten = (bw_temp + Convert.ToInt32(bw)).ToString();
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
          
            

             string[] lst, fin_lst;
            MyData temp_data;
              
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog1.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog1.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        //fileContent = reader.ReadToEnd();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                          
                            if (line.Contains(';'))
                            {
                                lst = line.Split(';');
                                fin_lst = lst[1].Split('|');
                                int bytesRead = 0;
                                int bytesWritten = 0;
                                string cmd = fin_lst[0];
                                if (cmd == "17" || cmd == "18")
                                {
                                    bytesRead = Convert.ToInt32(fin_lst[2]) * Convert.ToInt32(fin_lst[3]);
                                }
                                if (cmd == "24" || cmd == "25")
                                {
                                    bytesWritten = Convert.ToInt32(fin_lst[2]) * Convert.ToInt32(fin_lst[3]);
                                }
                                addMyData(fin_lst[1], bytesRead.ToString(), bytesWritten.ToString());
                                //temp_data = new MyData(fin_lst[1], bytesRead.ToString(), bytesWritten.ToString());
                                //data.Add(temp_data);

                                //dataGridView1.Refresh();
                            }

                        }
                        data.Sort(myDataCompare);
                        src.DataSource = data;
                        
                        dataGridView1.DataSource = src;
                      
                        
                    }
                }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
