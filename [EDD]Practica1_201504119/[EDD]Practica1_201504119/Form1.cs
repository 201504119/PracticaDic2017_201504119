using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _EDD_Practica1_201504119
{
    public partial class Form1 : Form
    {
        CicularDoble ingreso = new CicularDoble();
        public Form1()
        {
            
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CicularDoble listadoblecircular = new CicularDoble();
            //listadoblecircular.InsertarCircular("usuario1", "1");
            //listadoblecircular.InsertarCircular("usuario2", "2");
            //listadoblecircular.InsertarCircular("usuario3", "3");
            ////listadoblecircular.InsertarCircular("usuario4", "4");
            ////listadoblecircular.InsertarCircular("usuario5", "5");
            //listadoblecircular.MostrarCircular();


            ////Cola elementocola = new Cola();
            ////elementocola.Encolar(00);
            ////elementocola.Encolar(11);
            ////elementocola.Encolar(22);
            ////elementocola.Encolar(33);
            ////elementocola.MostrarCola();

            ////Pila elementopila = new Pila();
            ////elementopila.Apilar(000);
            ////elementopila.Apilar(111);
            ////elementopila.Apilar(222);
            ////elementopila.Apilar(333);
            ////elementopila.MostarPila();

            //listadoblecircular.InsertarEnlazadosCola("usuario1",18);
            //listadoblecircular.InsertarEnlazadosPila("usuario1", 19);
            //listadoblecircular.InsertarEnlazadosCola("usuario2", 20);
            //listadoblecircular.InsertarEnlazadosPila("usuario2", 21);
            //listadoblecircular.InsertarEnlazadosCola("usuario3", 22);
            //listadoblecircular.InsertarEnlazadosPila("usuario3", 23);

            //Matriz a = new Matriz();
           //a.CrearMatriz(5, 2, 0 );
            //listadoblecircular.MostrarEnlazadosCola();
            //listadoblecircular.MostrarEnlazadosPila();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

         //   getUserName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void getUserName() {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string usuario = "";
            string password = "";
            usuario = textBox4.Text;
            password = textBox3.Text;
            ingreso.InsertarCircular(usuario, password);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            string usuario = "";
            string password = "";
            usuario = textBox1.Text;
            password = textBox2.Text;

            if (ingreso.Buscar(usuario) && ingreso.BuscarPass(password))
            {
                MessageBox.Show("Acceso Correcto");
                this.Hide();
                Form2 yainiciado = new Form2();
                yainiciado.Show();
            }
            else {
                MessageBox.Show("Acceso Incorrecto");
            }
          
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            ////System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + @"dot.exe -T jpg C:\Users\lizzi\Desktop\graph.txt -o C:\Users\lizzi\Desktop\graph.jpg");
            ////procStartInfo.RedirectStandardOutput = true;
            ////procStartInfo.UseShellExecute = false;
            ////procStartInfo.CreateNoWindow = false;
            ////System.Diagnostics.Process proc = new System.Diagnostics.Process();
            ////proc.StartInfo = procStartInfo;
            ////proc.Start();

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            ingreso.MostrarCircular();
        }
    }
}
