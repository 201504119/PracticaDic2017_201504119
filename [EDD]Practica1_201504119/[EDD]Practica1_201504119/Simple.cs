using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201504119
{
    class Simple
    {
    
        private NodoSimple primerosimple;
        private NodoSimple ultimosimple;

        public NodoSimple GetPrimero { get { return primerosimple; } }
        public NodoSimple GetUltimo { get { return ultimosimple; } }

        public Simple()
        {
            primerosimple = null;
            ultimosimple = null;

        }

        public void InsertaSimple(string usuario , string password) {
            NodoSimple nuevo = new NodoSimple();
            nuevo.usuario = usuario;
            nuevo.password = password;
           
            if (primerosimple == null)
            {
                primerosimple = nuevo;
               
            }
            else
            {
                nuevo.siguientesimple = primerosimple;
                primerosimple = nuevo;
                
            }
        }

        public void MostrarSimple()
        {
           NodoSimple actual = new NodoSimple();
            actual = primerosimple;
            if (primerosimple != null)
            {
                do
                {
                    Console.WriteLine(actual.usuario);
                    Console.WriteLine(actual.password);

                    actual = actual.siguientesimple;
                } while (actual != null);
                
            }
            else
            {
                Console.WriteLine("la lista se encuentra vacia");
            }
          
        }
       public void BuscarSimple(string usuariobuscado, string passwordbuscado) {


            NodoSimple aux = primerosimple;
            int encontrar = 0;
            if (primerosimple != null)
            {
                while (aux != null && encontrar != 1)
                {
                    if (aux.usuario == usuariobuscado)
                    {
                        if (aux.password == passwordbuscado) { }
                        Console.WriteLine( "Usuario Correcto" );
                        //return "Usuario Correcto";
                        encontrar = 1;
                    }
                    aux = aux.siguientesimple;

                }
                if (encontrar == 0)
                {
                    Console.WriteLine("Usuario Incorrecto");
                }
            }
            else
            {
               Console.WriteLine("No Hay Usuarios Registrados");
            }

        }

    }
}
