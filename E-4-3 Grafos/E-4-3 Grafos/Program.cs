using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_3_Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Grafos.";
            Proceso obj = new Proceso(); //Instanciamos un objeto de la clase Proceso.
            obj.Play(); //Ejecutamos el método "Play" a través del objeto.
        }
    }
}
