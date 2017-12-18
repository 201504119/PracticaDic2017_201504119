using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _EDD_Practica1_201504119
{
     class CicularDoble
    {
        private ListaDoble primero;
        private ListaDoble ultimo;
        public string usuariocapturado;
    public ListaDoble GetPrimero { get { return primero; } }
    public ListaDoble GetUltimo { get { return ultimo; } }

        public CicularDoble() {
            

        }

        public void InsertarCircular(string usuario,string password ) {

            ListaDoble nuevo = new ListaDoble();
            nuevo.usuario = usuario;
            nuevo.password = password;
            

            if (primero == null)
            {
                primero = nuevo;
                primero.siguiente = primero;
                ultimo = primero;
                primero.anterior = ultimo;

            }
            else {
                ultimo.siguiente = nuevo;

                nuevo.siguiente = primero;
                nuevo.anterior = ultimo;
                primero.anterior = nuevo;
                ultimo = nuevo;
            }
            usuariocapturado = nuevo.usuario;

        }

        public void MostrarCircular() {
            var Doc = File.Create(@"C:\Users\lizzi\Desktop\Circular.txt");
            Doc.Close();
            StreamWriter tok = new StreamWriter(@"C:\Users\lizzi\Desktop\Circular.txt");
            tok.WriteLine(" digraph Grafo ");
            tok.WriteLine("{");
            ListaDoble actual = new ListaDoble();
           
            actual = primero;
           
            if (primero != null)
            {
                do
                {
                    Console.WriteLine (actual.usuario+"_"+ actual.password);
                    tok.WriteLine(actual.usuario + "->" + actual.siguiente.usuario);
                    Console.WriteLine(actual.usuario + "->" + actual.siguiente.usuario);
                    tok.WriteLine(actual.siguiente.anterior.usuario + "->" + actual.usuario);
                    Console.WriteLine(actual.siguiente.anterior.usuario + "->" + actual.usuario);
                    actual = actual.siguiente;
                } while (actual != primero);

            }
            else
            {
                Console.WriteLine("la lista se encuentra vacia");
            }
            tok.WriteLine(primero.anterior.usuario + "->" + ultimo.usuario);
            Console.WriteLine(primero.anterior.usuario + "->" + ultimo.usuario);
            tok.WriteLine(ultimo.siguiente.usuario + "->" + primero.usuario);
            Console.WriteLine(ultimo.siguiente.usuario + "->" + primero.usuario);
            tok.WriteLine("}");
            tok.Close();
        }
        public void InsertarEnlazadosCola(string usuario, int value) {

           NodoCola nuevo = new NodoCola();
            nuevo.valorcola = value;
           
            ListaDoble NodoCircular = new ListaDoble();
            NodoCircular = primero;
            int x = 0;
            while (NodoCircular.siguiente != primero)
            {
                if (NodoCircular.usuario == usuario)
                {
                    x = 1;
                    break;
                }
                NodoCircular = NodoCircular.siguiente;
            }
            if (x == 0)
            {
                if (NodoCircular.usuario == usuario)
                {
                    x = 1;
                }
            }
            if (x == 1)
            {
                if (NodoCircular.enlaceparacola == null)
                {
                    NodoCircular.enlaceparacola = nuevo;

                    Console.WriteLine("Valor circular " + NodoCircular.usuario +"_"+ NodoCircular.password);
                    Console.WriteLine("lo inserto en la Cola enlazada " + NodoCircular.enlaceparacola.valorcola);
                   
                }
                else
                {
                    NodoCola temporal = new NodoCola();
                    temporal = NodoCircular.enlaceparacola;
                    while (temporal.siguientecola != null)
                    {
                        temporal = temporal = temporal.siguientecola;
                    }
                    Console.WriteLine( "lo inserto en la Cola enlazada" + temporal.valorcola );
                    
                    temporal.siguientecola = nuevo;

                }
            }
        }

        public void MostrarEnlazadosCola() {
            ListaDoble actual = new ListaDoble();
            actual = primero;
            int x = 0;
            while (actual != primero || x == 0)
            {
                x = 1;
                Console.WriteLine( actual.usuario);
                if (actual.enlaceparacola != null)
                {
                    NodoCola actualcola = new NodoCola();
                    Console.WriteLine(actual.enlaceparacola.valorcola);


                    actualcola = actual.enlaceparacola;
                    while (actualcola.siguientecola != null)
                    {
                        actualcola = actualcola.siguientecola;
                        Console.WriteLine(actualcola.valorcola );
                       


                    }
                    actualcola = actual.enlaceparacola;
                }
                actual = actual.siguiente;
            }
        }



        public void InsertarEnlazadosPila(string usuario, int value)
        {

            NodoPila nuevo = new NodoPila();
            nuevo.valorpila = value;

            ListaDoble NodoCircular = new ListaDoble();
            NodoCircular = primero;
            int x = 0;
            while (NodoCircular.siguiente != primero)
            {
                if (NodoCircular.usuario == usuario)
                {
                    x = 1;
                    break;
                }
                NodoCircular = NodoCircular.siguiente;
            }
            if (x == 0)
            {
                if (NodoCircular.usuario == usuario)
                {
                    x = 1;
                }
            }
            if (x == 1)
            {
                if (NodoCircular.enlaceparapila == null)
                {
                    NodoCircular.enlaceparapila = nuevo;
                    Console.WriteLine("Valor circular " + NodoCircular.usuario+ "_"+ NodoCircular.password);
                    Console.WriteLine("lo inserto en la Pila enlazada " + NodoCircular.enlaceparapila.valorpila);

                }
                else
                {
                    NodoPila temporal = new NodoPila();
                    temporal = NodoCircular.enlaceparapila;
                    while (temporal.siguientepila != null)
                    {
                        temporal = temporal = temporal.siguientepila;
                    }
                    Console.WriteLine("lo inserto en la Pila enlazada" + temporal.valorpila);

                    temporal.siguientepila = nuevo;

                }
            }
        }

        public void MostrarEnlazadosPila()
        {
            ListaDoble actual = new ListaDoble();
            actual = primero;
            int x = 0;
            while (actual != primero || x == 0)
            {
                x = 1;
                Console.WriteLine(actual.usuario);
                if (actual.enlaceparapila != null)
                {
                    NodoPila actualpila = new NodoPila();
                    Console.WriteLine(actual.enlaceparapila.valorpila);


                    actualpila = actual.enlaceparapila;
                    while (actualpila.siguientepila != null)
                    {
                        actualpila = actualpila.siguientepila;
                        Console.WriteLine(actualpila.valorpila);

                        

                    }
                    actualpila = actual.enlaceparapila;
                }
                actual = actual.siguiente;
            }
        }
        public bool Buscar(string dato){
        int buscadores = 0;
        ListaDoble actual = primero;

    if (primero != null){
    do{
                    if (actual.usuario == dato)
                    {
                        Console.Write("nodo encontrado en lista circular");

                        buscadores = 1;
                         
                        
                    }
                    actual = actual.siguiente;
                }while(actual != primero && buscadores != 1);


        if(buscadores == 0){
                    Console.Write("nodo NO encontrado" );
                    return false;
        }
    }else{
                Console.Write("la lista se encuentra vacia");
                return false;
                
    }
            return true;
    
    }
        public bool BuscarPass(string pass)
        {
            int buscadores = 0;
            ListaDoble actual = primero;

            if (primero != null)
            {
                do
                {
                    if (actual.password == pass)
                    {
                        Console.Write("nodo encontrado en lista circular");

                        buscadores = 1;


                    }
                    actual = actual.siguiente;
                } while (actual != primero && buscadores != 1);


                if (buscadores == 0)
                {
                    Console.Write("nodo NO encontrado");
                    return false;
                }
            }
            else
            {
                Console.Write("la lista se encuentra vacia");
                return false;

            }
            return true;

        }

    }
    }

