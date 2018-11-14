using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2.Arboles
{
    class ArbolA
    {
        Metodos Arbol = new Metodos();
        public void Play()
        {
            Nodo raiz = Arbol.Insertar("E", null); 
            Arbol.Insertar("F", raiz);
            Nodo raiza = Arbol.Insertar("A", raiz);
            Arbol.Insertar("C", raiza);
            Arbol.Insertar("B", raiza);
            Arbol.Insertar("D", raiza);
            Arbol.Acomodar(raiz);
            Console.WriteLine("\nLa altura del arbol es: {0}\nEl nivel del arbol es: {1}\n", Arbol.Altura(), 2);
            Console.WriteLine("La ruta mas larga es hacia C, B y D: \nE -> A -> C\nE -> A -> B\nE -> A -> D");
        }
    }
}
