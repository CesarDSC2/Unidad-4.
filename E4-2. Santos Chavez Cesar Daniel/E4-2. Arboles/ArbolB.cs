using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2.Arboles
{
    class ArbolB
    {
        Metodos Arbol = new Metodos();
        public void Play()
        {
            Nodo raiz = Arbol.Insertar("C", null);
            Nodo raiza = Arbol.Insertar("A", raiz);
            Nodo raizb = Arbol.Insertar("B", raiza);
            Arbol.Insertar("E", raizb);
            Arbol.Insertar("D", raiz);
            Arbol.Insertar("F", raiz);
            Arbol.Insertar("G", raiz);
            Arbol.Acomodar(raiz);
            Console.WriteLine("\nLa altura del arbol es: {0}\nEl nivel del arbol es: {1}\n", Arbol.Altura() - 1, 3);
            Console.WriteLine("La ruta mas larga es hacia E: \nC -> A -> B -> E");
        }
    }
}
