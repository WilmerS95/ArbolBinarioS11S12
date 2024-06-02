using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class ArbolBinario2
    {
        public NodoArbol? NodoRaiz { get; set; }
        string respuesta;

        public ArbolBinario2()
        {
            NodoRaiz = null;
        }

        bool ArbolVacio() => NodoRaiz == null;

        NodoArbol CrearNodo()
        {
            NodoArbol nuevoNodo = new NodoArbol();

            if (ArbolVacio())
            {
                Console.WriteLine("Ingrese el dato para el nodo raíz: ");
                nuevoNodo.Informacion = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ingrese el dato para el nodo: ");
                nuevoNodo.Informacion = Console.ReadLine();
            }

            return nuevoNodo;
        }

        public void PoblarArbol(NodoArbol nodo)
        {
            if (ArbolVacio())
            {
                nodo = CrearNodo();
                NodoRaiz = nodo;
            }

            Console.WriteLine($"Existe nodo por la izq. de {nodo.Informacion}");
            respuesta = Console.ReadLine().ToString().Trim().ToLower();

            if (respuesta.Equals("s"))
            {
                NodoArbol nuevoNodo = new NodoArbol();
                nuevoNodo = CrearNodo();

                nodo.RamaIzquierda = nuevoNodo;

                PoblarArbol(nodo.RamaIzquierda);


            }

            // rama derecha
            Console.WriteLine($"Existe nodo por la der. de {nodo.Informacion}");
            respuesta = Console.ReadLine().ToString().Trim().ToLower();

            if (respuesta.Equals("s"))
            {
                NodoArbol nuevoNodo = new NodoArbol();
                nuevoNodo = CrearNodo();

                nodo.RamaDerecha = nuevoNodo;

                PoblarArbol(nodo.RamaDerecha);


            }

        }

        public void RecorridoPreorden(NodoArbol nodo)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                Console.WriteLine($"{nodo.Informacion} > ");
                RecorridoPreorden(nodo.RamaIzquierda);
                RecorridoPreorden(nodo.RamaDerecha);
            }

        }

        public void RecorridoInorden(NodoArbol nodo)
        {
            if (nodo == null)
            {
                return;
            }
            else
            {
                RecorridoPreorden(nodo.RamaIzquierda);
                Console.WriteLine($"{nodo.Informacion} > ");
                RecorridoPreorden(nodo.RamaDerecha);
            }

        }
    }
}
