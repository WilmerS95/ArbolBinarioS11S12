using System;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            ABB abb = new ABB();
            AVL avl = new AVL();
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar Nodo en ABB");
                Console.WriteLine("2. Buscar Nodo en ABB");
                Console.WriteLine("3. Eliminar Nodo en ABB");
                Console.WriteLine("4. Recorrido Preorden en ABB");
                Console.WriteLine("5. Recorrido Inorden en ABB");
                Console.WriteLine("6. Recorrido Postorden en ABB");
                Console.WriteLine("7. Insertar Nodo en AVL");
                Console.WriteLine("8. Recorrido Preorden en AVL");
                Console.WriteLine("9. Recorrido Inorden en AVL");
                Console.WriteLine("10. Recorrido Postorden en AVL");
                Console.WriteLine("11. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingrese el valor del nodo: ");
                        int valorABB = int.Parse(Console.ReadLine());
                        abb.PoblarABB(abb.NodoRaiz, new NodoABB(valorABB));
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
                        Console.Write("Ingrese el valor del nodo para AVL: ");
                        int valorAVL = int.Parse(Console.ReadLine());
                        avl.NodoRaiz = avl.Insertar(avl.NodoRaiz, valorAVL);
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Recorrido Preorden en AVL:");
                        avl.RecorridoPreorden(avl.NodoRaiz);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Recorrido Inorden en AVL:");
                        avl.RecorridoInorden(avl.NodoRaiz);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Recorrido Postorden en AVL:");
                        avl.RecorridoPostorden(avl.NodoRaiz);
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 11:
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