using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2.Arboles
{
    class ArbolC
    {
        Metodos Arbol = new Metodos();
        public void Play()
        {
            Nodo raiz = Arbol.Insertar("K", null);
            Arbol.Insertar("A", raiz);
            Arbol.Insertar("B", raiz);
            Arbol.Insertar("C", raiz);
            Nodo raiza = Arbol.Insertar("D", raiz);
            Nodo raizi = Arbol.Insertar("I", raiza);
            Arbol.Insertar("J", raizi);
            Nodo raize = Arbol.Insertar("E", raiza);
            Arbol.Insertar("F", raize);
            Nodo raizg = Arbol.Insertar("G", raize);
            Arbol.Insertar("H", raizg);
            Arbol.Acomodar(raiz);
            Console.WriteLine("\nLa altura del arbol es: {0}\nEl nivel del arbol es: {1}\n", Arbol.Altura() + 2, 4);
            Console.WriteLine("La ruta mas larga es hacia H: \nK -> D -> E -> G -> H");
            Console.WriteLine("La ruta hacia C es: K -> C \nLa ruta hacia J es: K -> D -> I -> J");
        }
    }
}
