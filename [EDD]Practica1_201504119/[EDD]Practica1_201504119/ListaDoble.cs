using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Practica1_201504119
{
    class ListaDoble
    {
        public ListaDoble anterior { get; set; }
        public ListaDoble siguiente { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        
        public NodoCola enlaceparacola { get; set; }
        public NodoPila enlaceparapila { get; set; }
    }

   
}
