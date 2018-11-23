using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4_1.Santos_Chávez_Cesar_Daniel
{
    class Clase
    {
        public void Play()
        {
            Arbol raiz = new Arbol();
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
            Arbol i = new Arbol();
            i.dato = "i";
            Arbol j = new Arbol();
            j.dato = "j";
            Arbol k = new Arbol();
            k.dato = "k";
            Arbol l = new Arbol();
            l.dato = "l";
            Arbol m = new Arbol();
            m.dato = "m";
            Arbol n = new Arbol();
            n.dato = "n";
            Arbol o = new Arbol();
            o.dato = "o";
            Arbol p = new Arbol();
            p.dato = "p";
            Arbol q = new Arbol();
            q.dato = "q";
            Arbol r = new Arbol();
            r.dato = "r";
            Arbol s = new Arbol();
            s.dato = "s";

            raiz.izq = b; //Asignamos los sub-árboles de cada lado.
            raiz.mid = c;
            raiz.der = d;

            b.izq = e; //Asignamos los nodos.
            b.mid = f;
            b.der = g;

            d.izq = h;
            d.mid = i;
            d.der = j;

            e.izq = k;
            e.mid = l;
            e.der = m;

            g.mid = n;

            h.mid = o;

            j.izq = p;
            j.der = q;

            n.izq = r;
            n.der = s;

            Console.WriteLine("Impresión PreOrden:"); //Despliege
            raiz.ImprimirPre(raiz); 

            Console.WriteLine("\n\nImpresión PostOrden:");
            raiz.ImprimirPost(raiz);
            Console.ReadKey();
        }
    }
}
