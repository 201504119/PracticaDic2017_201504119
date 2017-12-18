using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201504119
{

    public class ArchivoJson
    {
        public Archivo archivo { get; set; }
    }

    public class Archivo
    {
        public Pilas pila { get; set; }
        public Colas cola { get; set; }
    }

    public class Pilas
    {
        public Matrices matrices { get; set; }
    }

    public class Matrices
    {
        public Matrix[] matriz { get; set; }
    }

    public class Matrix
    {
        public string size_x { get; set; }
        public string size_y { get; set; }
        public Valores valores { get; set; }
    }

    public class Valores
    {
        public Valor[] valor { get; set; }
    }

    public class Valor
    {
        public string pos_x { get; set; }
        public string pos_y { get; set; }
        public string dato { get; set; }
    }

    public class Colas
    {
        public Matrices1 matrices { get; set; }
    }

    public class Matrices1
    {
        public Matriz1[] matriz { get; set; }
    }

    public class Matriz1
    {
        public string size_x { get; set; }
        public string size_y { get; set; }
        public Valores1 valores { get; set; }
    }

    public class Valores1
    {
        public Valor1[] valor { get; set; }
    }

    public class Valor1
    {
        public string pos_x { get; set; }
        public string pos_y { get; set; }
        public string dato { get; set; }
    }

}
