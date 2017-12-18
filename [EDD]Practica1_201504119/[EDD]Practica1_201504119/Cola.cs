using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201504119
{
    class Cola
    {
        private NodoCola primerocola;
        private NodoCola ultimocola;

        public NodoCola GetPrimeroCola { get { return primerocola; } }
        public NodoCola GetUltimoCola { get { return ultimocola; } }

        public Cola()
        {
            primerocola = null;
            ultimocola = null;

        }

        public void Encolar(int paramientras) {
            
    NodoCola nueva = new NodoCola();
            nueva.valorcola = paramientras;


            if (primerocola == null)
            {
                primerocola = nueva;
                primerocola.siguientecola = null;
                ultimocola = primerocola;
            }
            else
            {
              ultimocola.siguientecola = nueva;
                nueva.siguientecola = null;
                ultimocola = nueva;
            }
            

        }

        public void MostrarCola() {


            NodoCola actual = new NodoCola();
            actual = primerocola;
            if (primerocola != null)
            {

                
                while (actual != null)
                {
                    Console.WriteLine("valor nodo cola: "+actual.valorcola);


                    actual = actual.siguientecola;
                }
              
            }
            else
            {
                Console.WriteLine("Cola esta vacia");
            }

        

    }
    
    }
}
