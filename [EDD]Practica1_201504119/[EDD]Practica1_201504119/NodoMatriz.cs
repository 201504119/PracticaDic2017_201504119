using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201504119
{
    class NodoMatriz
    {
        public NodoMatriz siguientematriz { get; set; }
        public NodoMatriz anteriormatriz { get; set; }
        public NodoMatriz arribamatriz { get; set; }
        public NodoMatriz abajomatriz { get; set; }
        public int posx { get; set; }
        public int posy { get; set; }
        public int valormatriz { get; set; }
    }
}
