using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_3_Grafos
{
    public class Clase
    {
        private int vert; //Variable que guarda el total de vértices.
        private List<int>[] list; //Lista que almacena datos.
        public Clase(int V) //Constructor de la clase "Clase".
        {
            vert = V; //Asignamos el total de vértices en el constructor.
            list = new List<Int32>[V];
            for (int i = 0; i < V; i++) //Ciclo "for" que recorre cada posición.
            {
                list[i] = new List<int>();
            }
        }
        public void Añadir(int C, int V) //Conecta los nodos, recibe como parámetro el nodo conector y el nodo conectado.
        {
            list[C].Add(V);
        }
        public void Busqueda(int V)//Método que buscará e imprimirá los nodos, recibe como parámetro el nodo de la posición inicial.
        {
            bool[] Visitado = new bool[vert]; //Array de tipo bool para determinar si el nodo ya fué visitado.
            Stack<int> Pila = new Stack<int>(); //En una pila guardaremos los nodos ya visitados.
            Visitado[V] = true;
            Pila.Push(V);
            while (Pila.Count != 0)
            {
                V = Pila.Pop();
                Console.Write("-> " + V); //Se imprime el nodo visitado.
                foreach (int i in list[V])
                {
                    if (!Visitado[i]) //Si el grafo no ha sido visitado, entonces lo visita y lo agrega a la pila.
                    {
                        Visitado[i] = true;
                        Pila.Push(i);
                    }
                }
            }

        }
    }
}
