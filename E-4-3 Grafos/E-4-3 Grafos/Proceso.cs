using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_3_Grafos
{
    class Proceso
    {
        public void Play()
        {            
            Clase grafo = new Clase(8);
            Console.WriteLine("1 = A , 2 = B , 3 = C , 4 = D , 5 = E , 6 = F , 7 = G.");
            Console.WriteLine("Camino para llegar al último elemento.");
            grafo.Añadir(1, 1); //Añadimos las conexiones.
            grafo.Añadir(1, 2);
            grafo.Añadir(2, 3);
            grafo.Añadir(2, 7);
            grafo.Añadir(3, 4);
            grafo.Añadir(3, 7);
            grafo.Añadir(4, 5);
            grafo.Añadir(4, 6);
            grafo.Añadir(5, 6);
            grafo.Añadir(6, 7);
            grafo.Busqueda(1); //Mandamos como parámetro la posición inicial.
            Console.WriteLine("\nTrayectorias simples \nA->B->C->D->E \nA->A->B->C->D->E \nA->A->B->G->F->E \nA->B->C->G->F->D->E \nA->B->G->C->D->F->E"); //Impresión manual.
            Console.ReadKey(true);

        }
    }
}
