using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2.Arboles
{
    class Nodo
    {
        private string dato; //Variables auxiliares.                      
        private Nodo hijo;
        private Nodo hermano;

        public string Dato //Propiedades de la clase. Recibe los valores.                       
        {
            get => dato;
            set => dato = value;
        }
        public Nodo Hijo                           
        {
            get => hijo;
            set => hijo = value;
        }
        public Nodo Hermano                       
        {
            get => hermano;
            set => hermano = value;
        }
        public Nodo() //Constructor de la clase que asigna valores a cada variable.
        {
            dato = "";
            hijo = null;
            hermano = null;
        }
    }
}
