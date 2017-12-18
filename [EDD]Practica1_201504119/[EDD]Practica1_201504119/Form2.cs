using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace _EDD_Practica1_201504119
{
    public partial class Form2 : Form
    {
        public Form2()

      
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("C:\\Users\\lizzi\\Desktop\\file.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("{0} {1}", item.temp, item.vcc);
                }

            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                int count = 0;
                int count2 = 0;
                int inOrOut = 0;
                int nRecords = 1;
                JsonTextReader reader = new JsonTextReader(new StreamReader("C:\\Users\\lizzi\\Desktop\\file.json"));
                string[] rawData = new string[5];
                while (reader.Read())
                {
                    if (reader.Value != null)
                        if (inOrOut == 1)
                        {
                            if (count == 6)
                            {
                                nRecords++;
                                Array.Resize(ref rawData, nRecords);
                                //textBox1.Text += "\r\n";
                                count = 0;
                            }
                            rawData[count2] += reader.Value + ","; //+"\r\n"
                            inOrOut = 0;
                            count++;
                            if (count2 == 500)
                            {
                                MessageBox.Show(rawData[499]);
                            }
                        }
                        else
                        {
                            inOrOut = 1;
                        }
                }
            for (int i =0; i< rawData.Length;i++) {
                Console.WriteLine(rawData[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Simple mostrar = new Simple();
            mostrar.MostrarSimple();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 entrar = new Form1();
            entrar.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
