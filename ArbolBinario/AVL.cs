using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class AVL
    {
        public NodoAVL NodoRaiz { get; set; }

        public AVL()
        {
            NodoRaiz = null;
        }

        public int Altura(NodoAVL nodo)
        {
            return nodo?.Altura ?? 0;
        }

        public int ObtenerFactorBalanceo(NodoAVL nodo)
        {
            if (nodo == null) return 0;
            return Altura(nodo.RamaIzquierda) - Altura(nodo.RamaDerecha);
        }

        public NodoAVL RotarDerecha(NodoAVL y)
        {
            NodoAVL x = y.RamaIzquierda;
            NodoAVL T2 = x.RamaDerecha;

            // Rotar
            x.RamaDerecha = y;
            y.RamaIzquierda = T2;

            // Actualizar alturas
            y.Altura = Math.Max(Altura(y.RamaIzquierda), Altura(y.RamaDerecha)) + 1;
            x.Altura = Math.Max(Altura(x.RamaIzquierda), Altura(x.RamaDerecha)) + 1;

            return x;
        }

        public NodoAVL RotarIzquierda(NodoAVL x)
        {
            NodoAVL y = x.RamaDerecha;
            NodoAVL T2 = y.RamaIzquierda;

            // Rotar
            y.RamaIzquierda = x;
            x.RamaDerecha = T2;

            // Actualizar alturas
            x.Altura = Math.Max(Altura(x.RamaIzquierda), Altura(x.RamaDerecha)) + 1;
            y.Altura = Math.Max(Altura(y.RamaIzquierda), Altura(y.RamaDerecha)) + 1;

            return y;
        }

        public NodoAVL Insertar(NodoAVL nodo, int valor)
        {
            if (nodo == null)
            {
                return new NodoAVL(valor);
            }

            if (valor < nodo.Informacion)
            {
                nodo.RamaIzquierda = Insertar(nodo.RamaIzquierda, valor);
            }
            else if (valor > nodo.Informacion)
            {
                nodo.RamaDerecha = Insertar(nodo.RamaDerecha, valor);
            }
            else
            {
                // Valores duplicados no se permiten en un árbol AVL
                return nodo;
            }

            // Actualizar la altura del nodo ancestro
            nodo.Altura = 1 + Math.Max(Altura(nodo.RamaIzquierda), Altura(nodo.RamaDerecha));

            // Obtener el factor de balanceo de este nodo ancestro
            int balanceo = ObtenerFactorBalanceo(nodo);

            // Si el nodo se desbalanceó, hay 4 casos

            // Rotación a la derecha
            if (balanceo > 1 && valor < nodo.RamaIzquierda.Informacion)
            {
                return RotarDerecha(nodo);
            }

            // Rotación a la izquierda
            if (balanceo < -1 && valor > nodo.RamaDerecha.Informacion)
            {
                return RotarIzquierda(nodo);
            }

            // Rotación a la izquierda-derecha
            if (balanceo > 1 && valor > nodo.RamaIzquierda.Informacion)
            {
                nodo.RamaIzquierda = RotarIzquierda(nodo.RamaIzquierda);
                return RotarDerecha(nodo);
            }

            // Rotación a la derecha-izquierda
            if (balanceo < -1 && valor < nodo.RamaDerecha.Informacion)
            {
                nodo.RamaDerecha = RotarDerecha(nodo.RamaDerecha);
                return RotarIzquierda(nodo);
            }

            // Retornar el nodo (sin cambio)
            return nodo;
        }

        public void RecorridoPreorden(NodoAVL nodo)
        {
            if (nodo == null)
            {
                return;
            }
            Console.Write($" {nodo.Informacion} ");
            RecorridoPreorden(nodo.RamaIzquierda);
            RecorridoPreorden(nodo.RamaDerecha);
        }

        public void RecorridoInorden(NodoAVL nodo)
        {
            if (nodo == null)
            {
                return;
            }
            RecorridoInorden(nodo.RamaIzquierda);
            Console.Write($" {nodo.Informacion} ");
            RecorridoInorden(nodo.RamaDerecha);
        }

        public void RecorridoPostorden(NodoAVL nodo)
        {
            if (nodo == null)
            {
                return;
            }
            RecorridoPostorden(nodo.RamaIzquierda);
            RecorridoPostorden(nodo.RamaDerecha);
            Console.Write($" {nodo.Informacion} ");
        }
    }
}
