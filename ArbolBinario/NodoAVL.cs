using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class NodoAVL
    {
        public int Informacion { get; set; }
        public NodoAVL RamaIzquierda { get; set; }
        public NodoAVL RamaDerecha { get; set; }
        public int Altura { get; set; }

        public NodoAVL(int informacion)
        {
            Informacion = informacion;
            RamaIzquierda = null;
            RamaDerecha = null;
            Altura = 1;
        }
    }
}
