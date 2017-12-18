using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201504119
{
    class Pila
    {
        public NodoPila primeropila;
        public NodoPila ultimopila;
        private int tamaniopila;

        public NodoPila GetPrimeroPila { get { return primeropila; } }
        public NodoPila GetUltimoPila { get { return ultimopila; } }

        public Pila()
        {
            primeropila = null;
            ultimopila = null;

        }
    

    public void Apilar(int valor) {
     
        NodoPila nuevo = new NodoPila();
       
        nuevo.valorpila = valor;
       
        if (primeropila == null)
        {
                primeropila = nuevo;
        }
        
        else
        {
                nuevo.siguientepila = primeropila;
                primeropila = nuevo;
        }
       
        tamaniopila++;
    }

        public void MostarPila()
        {
            
            NodoPila aux = primeropila;
            if (primeropila != null)
            {
                while (aux != null)
                {
                    Console.WriteLine("valor nodo pila: " + aux.valorpila);

                    aux = aux.siguientepila;
                }
            }
            else {
                Console.WriteLine("Pila esta vacia");
            }
        }
    }
}
