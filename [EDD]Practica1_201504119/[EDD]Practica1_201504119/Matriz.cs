using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _EDD_Practica1_201504119
{
    class Matriz
    {
        private NodoMatriz primeromatriz;
        private NodoMatriz ultimomatriz;
        public int sizex, sizey;

        public NodoMatriz GetPrimeroM { get { return primeromatriz; } }
        public NodoMatriz GetUltimoM { get { return ultimomatriz; } }

        public Matriz()
        {
            //this.sizex = sizex;
            //this.sizey = sizey;
            primeromatriz = null;
            ultimomatriz = null;
            //CrearMatriz();

        }
        public void CrearMatriz(int sizex, int sizey, int valor) {
            int columna = 0;
            int fila = 0;

            while (fila < sizex) {
                while (columna < sizey) {
                    NodoMatriz nuevo = new NodoMatriz();
                    nuevo.valormatriz = valor;
                    if (primeromatriz == null)
                    {
                        primeromatriz = nuevo;
                         Console.WriteLine(nuevo.valormatriz);
                    }
                    else {
                        NodoMatriz auxiliar1 = new NodoMatriz();
                        auxiliar1 = primeromatriz;
                        if (fila == 0)
                        {
                            while (auxiliar1.siguientematriz != null)
                            {
                                auxiliar1 = auxiliar1.siguientematriz;
                            }
                            auxiliar1.siguientematriz = nuevo;
                            nuevo.anteriormatriz = auxiliar1;
                            //Console.WriteLine(nuevo.valormatriz);

                        }
                        else if (columna == 0)
                        {
                            while (auxiliar1.abajomatriz != null)
                            {
                                auxiliar1 = auxiliar1.abajomatriz;
                            }
                            auxiliar1.abajomatriz = nuevo;
                            nuevo.arribamatriz = auxiliar1;
                             //Console.WriteLine(nuevo.valormatriz);
                        }
                        else {
                            while (auxiliar1.abajomatriz != null) {
                                auxiliar1 = auxiliar1.abajomatriz;
                            }
                            NodoMatriz auxiliar2 = new NodoMatriz();
                            auxiliar2 = auxiliar1.arribamatriz;
                            while (auxiliar1.siguientematriz != null) {
                                auxiliar1 = auxiliar1.siguientematriz;
                                auxiliar2 = auxiliar2.siguientematriz;
                            }
                            auxiliar1.siguientematriz = nuevo;
                            nuevo.anteriormatriz = auxiliar1;
                            auxiliar2.siguientematriz.abajomatriz = nuevo;
                            nuevo.arribamatriz = auxiliar2.siguientematriz;
                            //Console.WriteLine(nuevo.valormatriz);
                        }
                    }
                    // Console.WriteLine(nuevo.valormatriz);
                }
                columna++;
                //Console.WriteLine(nuevo.valormatriz);
            }
            fila++;

            columna = 0;
        }


        public void ReccorrerMatriz() {
            var Doc = File.Create(@"C:\Users\lizzi\Desktop\Matriz.txt");
            Doc.Close();
            StreamWriter tok = new StreamWriter(@"C:\Users\lizzi\Desktop\Matriz.txt");
            int columna = 0;
            int fila = 0;
            NodoMatriz aux = new NodoMatriz();
            aux = primeromatriz;
            tok.WriteLine(" graph Grafo ");
            tok.WriteLine("{");
            while (fila < sizex)
            {
                while (columna < sizey)
                {
                    if (primeromatriz != null)
                    {

                        NodoMatriz auxiliar1 = new NodoMatriz();
                        auxiliar1 = primeromatriz;
                        if (fila == 0)
                        {
                            while (auxiliar1.siguientematriz != null)
                            {
                                auxiliar1 = auxiliar1.siguientematriz;
                                tok.WriteLine(auxiliar1 + "->" + auxiliar1.siguientematriz);
                                tok.WriteLine(auxiliar1.siguientematriz.anteriormatriz + "->" + auxiliar1);
                            }
                           

                        }
                        else if (columna == 0)
                        {
                            while (auxiliar1.abajomatriz != null)
                            {
                                auxiliar1 = auxiliar1.abajomatriz;
                                tok.WriteLine(auxiliar1 + "->" + auxiliar1.abajomatriz);
                                tok.WriteLine(auxiliar1.abajomatriz.arribamatriz + "->" + auxiliar1);
                            }
                          
                        }
                        else
                        {
                            while (auxiliar1.abajomatriz != null)
                            {
                                auxiliar1 = auxiliar1.abajomatriz;
                            }
                            NodoMatriz auxiliar2 = new NodoMatriz();
                            auxiliar2 = auxiliar1.arribamatriz;
                            while (auxiliar1.siguientematriz != null)
                            {
                                auxiliar1 = auxiliar1.siguientematriz;
                                auxiliar2 = auxiliar2.siguientematriz;
                                tok.WriteLine(auxiliar1 + "->" + auxiliar1.siguientematriz);
                                tok.WriteLine(auxiliar1.siguientematriz.anteriormatriz + "->" + auxiliar1);
                                tok.WriteLine(auxiliar1.siguientematriz.arribamatriz + "->" + auxiliar2.siguientematriz);
                                tok.WriteLine(auxiliar2.siguientematriz.abajomatriz + "->" + auxiliar1.siguientematriz);
                            }
                         


                        }

                    }
                    else
                    {
                        Console.WriteLine("Matriz Vacia");


                    }
                }
                    columna++;
            }
            fila++;
        }

    } }
