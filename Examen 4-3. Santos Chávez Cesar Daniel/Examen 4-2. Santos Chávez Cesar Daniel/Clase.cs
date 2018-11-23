using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4_2.Santos_Chávez_Cesar_Daniel
{
    class Clase
    {
        public void Play()
        {
            Arbol raiz = new Arbol(); //Creamos un objeto para cada nodo.
            raiz.dato = "a";
            Arbol b = new Arbol();
            b.dato = "b";
            Arbol c = new Arbol();
            c.dato = "c";
            Arbol d = new Arbol();
            d.dato = "d";
            Arbol e = new Arbol();
            e.dato = "e";
            Arbol f = new Arbol();
            f.dato = "f";
            Arbol g = new Arbol();
            g.dato = "g";
            Arbol h = new Arbol();
            h.dato = "h";

            raiz.izq = b; //Asignamos los sub-árboles de cada lado.
            raiz.der = e;

            b.izq = c; //Asignamos los nodos.
            b.der = d;

            e.izq = f;

            f.izq = g; 
            f.der = h;            

            Console.WriteLine("Impresión PreOrden:"); //Despliege
            raiz.ImprimirPre(raiz);

            Console.WriteLine("\n\nImpresión PostOrden:");
            raiz.ImprimirPost(raiz);
            Console.ReadKey();
        }
    }
}
