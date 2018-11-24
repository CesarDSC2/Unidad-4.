using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4_0.Santos_Chávez_Cesar_Daniel
{
    class Metodo //Método Dijkstra
    {
        private static int Distancia(int[] distancia, bool[] corto, int vert) //Algoritmo que calcula la distancia
        {
            int min = int.MaxValue;
            int minIn = 0;

            for (int v = 0; v < vert; v++)
            {
                if (corto[v] == false && distancia[v] <= min)
                {
                    min = distancia[v];
                    minIn = v;
                }
            }

            return minIn;
        }

        private static void Imprimir(int[] distancia, int vert) //Método que imprime los puntos.
        {
            Console.WriteLine("Vértice  ~   Distancia del origen");
            for (int i = 0; i < vert; i++)
            {
                Console.WriteLine("{0}\t \t {1}", i + 1, distancia[i]);
            }


        }

        public void Algoritmo(int[,] grafo, int origen, int vert)
        {
            int[] distancia = new int[vert];
            bool[] corto = new bool[vert];

            for (int i = 0; i < vert; i++)
            {
                distancia[i] = int.MaxValue;
                corto[i] = false;
            }

            distancia[origen] = 0;

            for (int i = 0; i < vert - 1; i++)
            {
                int u = Distancia(distancia, corto, vert);
                corto[u] = true;

                for (int v = 0; v < vert; v++)
                    if (!corto[v] && Convert.ToBoolean(grafo[u, v]) && distancia[u] != int.MaxValue && distancia[u] + grafo[u, v] < distancia[v])
                        distancia[v] = distancia[u] + grafo[u, v];
            }

            Imprimir(distancia, vert);
        }
    }
}
