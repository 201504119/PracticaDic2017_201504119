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
        string JSONFile;

        public Form2()
        

      
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JSONFile = File.ReadAllText(@"C:\Users\lizzi\Desktop\ejemplo1.json");
           
            ExtraerArchivoJSON(JSONFile);



        }

        public void ExtraerArchivoJSON(string contenido)
        {
            try
            {
                var jUsuario = JsonConvert.DeserializeObject<ArchivoJson>(contenido);
                Console.WriteLine("Objeto JSON: " + jUsuario.ToString());


               
                foreach (var cadamatrizenpila in jUsuario.archivo.pila.matrices.matriz)
                {
                    
                    //Console.WriteLine("tamano de matriz de pila: " + cadamatrizenpila.size_x.ToString() + "-" + cadamatrizenpila.size_y.ToString() + "\n");
                   
                    foreach (var cadamatrizenpilasc in cadamatrizenpila.valores.valor)
                    {
                        //Console.Write(" Posicion y valor de matriz pila: " + cadamatrizenpilasc.dato.ToString() + "-" + cadamatrizenpilasc.pos_x.ToString() + "-" + cadamatrizenpilasc.pos_y.ToString() + "\n");
                        
                    }

                }

                

                
                foreach (var cadamatrizencola in jUsuario.archivo.cola.matrices.matriz)
                {
                    
                    //Console.WriteLine("tamano de matriz de cola: " + cadamatrizencola.size_x.ToString() + "-" + cadamatrizencola.size_y.ToString() + "\n");
                    
                    foreach (var cadamatrizencolas in cadamatrizencola.valores.valor)
                    {
                       // Console.Write(" Posicion y valor de matriz cola: " + cadamatrizencolas.dato.ToString() + "-" + cadamatrizencolas.pos_x.ToString() + "-" + cadamatrizencolas.pos_y.ToString() + "\n");
                       
                    }
                  
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
