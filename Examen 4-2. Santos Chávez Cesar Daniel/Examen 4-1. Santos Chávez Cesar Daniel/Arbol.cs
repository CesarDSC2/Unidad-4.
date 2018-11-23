using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4_1.Santos_Chávez_Cesar_Daniel
{
    public class Arbol
    {
        public string dato { get; set; } //Guarda el valor del nodo.
        public Arbol izq { get; set; } //Se asigna valor al nodo izquierdo.
        public Arbol mid { get; set; } //Se asigna valor al nodo medio.
        public Arbol der { get; set; } //Se asigna valor al nodo derecho.

        public Arbol()
        {
            this.dato = ""; //Guarda el valor de cada nodo.
            this.izq = null; //Se asigna valor nulo porque el dato no existe.
            this.mid = null;
            this.der = null;
        }

        public void ImprimirPre(Arbol nodoActual) //Método para imprimir el árbol
        {
            if (nodoActual != null) //Mientras que el nodo tenga un valor..
            {

                Console.Write("{0} ", nodoActual.dato); //Imprime cada nodo.
                ImprimirPre(nodoActual.izq); //Imprimirá Raíz, Izquierda, Derecha.
                ImprimirPre(nodoActual.der);
            }
        }
        public void ImprimirPost(Arbol nodoActual) //Método para imprimir el árbol en PostOrden.
        {
            if (nodoActual != null) //Mientras que el nodo tenga un valor
            {
                ImprimirPost(nodoActual.izq); //Imprimirá Izquierda, Derecha, Raíz.
                ImprimirPost(nodoActual.der);
                Console.Write("{0} ", nodoActual.dato); //Imprime cada nodo.
            }
        }
    }
}