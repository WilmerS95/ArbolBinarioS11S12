using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class ABB
    {
        public NodoABB? NodoRaiz { get; set; }

        public ABB()
        {
            NodoRaiz = null;
        }

        public void PoblarABB(NodoABB nodoPadre, NodoABB nuevoNodo)
        {
            if (nodoPadre == null)
            {
                NodoRaiz = nuevoNodo;
                return;
            }

            if (nodoPadre.Informacion > nuevoNodo.Informacion)
            {

                // seleccionar rama izquierda
                if (nodoPadre.RamaIzquierda == null)
                {
                    nodoPadre.RamaIzquierda = nuevoNodo;
                    return;
                }
                else
                {
                    PoblarABB(nodoPadre.RamaIzquierda, nuevoNodo);
                }
            }

            if (nodoPadre.Informacion < nuevoNodo.Informacion)
            {

                // seleccionar rama derecha
                if (nodoPadre.RamaDerecha == null)
                {
                    nodoPadre.RamaDerecha = nuevoNodo;
                    return;
                }
                else
                {
                    PoblarABB(nodoPadre.RamaDerecha, nuevoNodo);
                }
            }
        }

        public (NodoABB nodo, string path) BuscarNodo(NodoABB nodoPadre, int llave, string path = "")
        {
            if (nodoPadre == null)
            {
                return (null, path);
            }

            if (nodoPadre.Informacion == llave)
            {
                return (nodoPadre, path);
            }

            if (nodoPadre.Informacion > llave)
            {
                return BuscarNodo(nodoPadre.RamaIzquierda, llave, path + $" {nodoPadre.Informacion} -> Izquierda");
            }
            else
            {
                return BuscarNodo(nodoPadre.RamaDerecha, llave, path + $" {nodoPadre.Informacion} -> Derecha");
            }
        }

        public NodoABB EliminarNodo(NodoABB nodo, int llave)
        {
            if (nodo == null)
            {
                return null;
            }

            if (llave < nodo.Informacion)
            {
                nodo.RamaIzquierda = EliminarNodo(nodo.RamaIzquierda, llave);
            }
            else if (llave > nodo.Informacion)
            {
                nodo.RamaDerecha = EliminarNodo(nodo.RamaDerecha, llave);
            }
            else
            {
                if (nodo.RamaIzquierda == null)
                {
                    return nodo.RamaDerecha;
                }
                else if (nodo.RamaDerecha == null)
                {
                    return nodo.RamaIzquierda;
                }

                nodo.Informacion = MinValue(nodo.RamaDerecha);
                nodo.RamaDerecha = EliminarNodo(nodo.RamaDerecha, (int)nodo.Informacion);
            }
            return nodo;
        }

        public int MinValue(NodoABB nodo)
        {
            int min = (int)nodo.Informacion;
            while (nodo.RamaIzquierda != null)
            {
                min = (int)nodo.RamaIzquierda.Informacion;
                nodo = nodo.RamaIzquierda;
            }
            return min;
        }

        public void RecorridoPreorden(NodoABB nodo)
        {
            if (nodo == null)
            {
                return;
            }
            Console.Write($" {nodo.Informacion} ");
            RecorridoPreorden(nodo.RamaIzquierda);
            RecorridoPreorden(nodo.RamaDerecha);
        }

        public void RecorridoInorden(NodoABB nodo)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                RecorridoInorden(nodo.RamaDerecha);
                Console.Write($" {nodo.Informacion} ");
                RecorridoInorden(nodo.RamaIzquierda);
            }
        }

        public void RecorridoPostorden(NodoABB nodo)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                RecorridoPostorden(nodo.RamaIzquierda);
                RecorridoPostorden(nodo.RamaDerecha);
                Console.Write($" {nodo.Informacion} ");
            }
        }
    }
}
