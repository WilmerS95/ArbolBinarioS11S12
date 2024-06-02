using System;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            ABB abb = new ABB();
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar Nodo");
                Console.WriteLine("2. Buscar Nodo");
                Console.WriteLine("3. Eliminar Nodo");
                Console.WriteLine("4. Recorrido Preorden");
                Console.WriteLine("5. Recorrido Inorden");
                Console.WriteLine("6. Recorrido Postorden");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingrese el valor del nodo: ");
                        int valor = int.Parse(Console.ReadLine());
                        abb.PoblarABB(abb.NodoRaiz, new NodoABB(valor));
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese el valor a buscar: ");
                        int valorBuscar = int.Parse(Console.ReadLine());
                        var resultadoBusqueda = abb.BuscarNodo(abb.NodoRaiz, valorBuscar);
                        if (resultadoBusqueda.nodo != null)
                        {
                            Console.WriteLine($"Nodo encontrado: {resultadoBusqueda.nodo.Informacion}");
                            Console.WriteLine($"Ruta: Raíz{resultadoBusqueda.path} -> {resultadoBusqueda.nodo.Informacion}");
                        }
                        else
                        {
                            Console.WriteLine("Nodo no encontrado");
                        }
                        Console.ReadKey();
                        break;
                    //Console.Clear();
                    //Console.Write("Ingrese el valor a buscar: ");
                    //int valorBuscar = int.Parse(Console.ReadLine());
                    //NodoABB nodoBuscado = abb.BuscarNodo(abb.NodoRaiz, valorBuscar);
                    //Console.WriteLine($"Nodo buscado: {(nodoBuscado != null ? nodoBuscado.Informacion.ToString() : "No existe")}");
                    //Console.ReadKey();
                    //break;
                    case 3:
                        Console.Clear();
                        Console.Write("Ingrese el valor a eliminar: ");
                        int valorEliminar = int.Parse(Console.ReadLine());
                        abb.NodoRaiz = abb.EliminarNodo(abb.NodoRaiz, valorEliminar);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Recorrido Preorden:");
                        abb.RecorridoPreorden(abb.NodoRaiz);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Recorrido Inorden:");
                        abb.RecorridoInorden(abb.NodoRaiz);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Recorrido Postorden:");
                        abb.RecorridoPostorden(abb.NodoRaiz);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        salir = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

//using ArbolBinario;

////ArbolBinario2 arbolBinario = new ArbolBinario2();

////arbolBinario.PoblarArbol(arbolBinario.NodoRaiz);

////arbolBinario.RecorridoPreorden(arbolBinario.NodoRaiz);

//ABB abb = new ABB();

//abb.PoblarABB(abb.NodoRaiz, new NodoABB(120));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(87));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(43));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(22));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(65));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(56));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(99));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(93));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(140));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(130));
//abb.PoblarABB(abb.NodoRaiz, new NodoABB(135));

//abb.RecorridoInorden(abb.NodoRaiz);

//NodoABB nodoBuscado = abb.BuscarNodo(abb.NodoRaiz, 99);

//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine($"Nodo buscado: {(nodoBuscado != null ? nodoBuscado.Informacion : "No existe!!!")}");

//Console.ReadKey();