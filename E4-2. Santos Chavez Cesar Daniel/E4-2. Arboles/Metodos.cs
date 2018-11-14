using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2.Arboles
{
    class Metodos
    {
        private Nodo raiz; //Variables auxiliares.
        private Nodo trabajo;     
        private int i = 0;        
        public int altura = 0;     

        public Metodos() { raiz = new Nodo(); } //Se inicializa el nodo raiz
        public Nodo Insertar(string Pdato, Nodo Pnodo) //Este método es para insertar nuevos nodos
        {
            if (Pnodo == null) //Si el nodo no existe aún, se asigna como raíz.
            {
                raiz = new Nodo();
                raiz.Dato = Pdato;
                raiz.Hijo = null;
                raiz.Hermano = null;
                return raiz;
            }
            if (Pnodo.Hijo == null) //Si el nodo ya no puede ser raíz, será hijo.
            {
                Nodo temporal = new Nodo();
                temporal.Dato = Pdato;
                Pnodo.Hijo = temporal;
                return temporal;
            }
            else 
            {
                trabajo = Pnodo.Hijo;
                while (trabajo.Hermano != null) { trabajo = trabajo.Hermano; }
                Nodo temporal = new Nodo();
                temporal.Dato = Pdato;
                trabajo.Hermano = temporal;
                return temporal;
            }
        }
        public void Acomodar(Nodo Pnodo) //Acomoda el árbol.
        {
            if (Pnodo == null) { return; }
            for (int j = 0; j < i; j++) { Console.Write("~"); }
            Console.WriteLine(Pnodo.Dato);
            if (Pnodo.Hijo != null)
            {
                i++;
                Acomodar(Pnodo.Hijo);
                i--;
            }
            if (Pnodo.Hermano != null) { Acomodar(Pnodo.Hermano); }
        }
        private void Calculo(Nodo hoja, int e) //Calcula la altura del árbol.
        {                                      
            if (hoja != null)
            {
                if (e <= altura)
                {
                    altura = e;
                    Calculo(hoja.Hijo, e);
                    altura++;
                }
            }
        }
        public int Altura() //Asigna altura.
        {
            altura = 1;
            Calculo(raiz, altura);
            return altura;
        }
    }
}
