using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2.Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
        x:
            Console.WriteLine("Enter");
            Console.ReadKey();
            Console.Clear();
            int opc;
            Console.Write("Qué arbol desea ejecutar?: \n1.-Arbol A. \n2.-Arbol B. \n3.-Arbol C. \n4.-Salir. \nOpción: "); 
            opc = int.Parse(Console.ReadLine());
            switch (opc) //Menú.
            {
                case 1:
                    ArbolA obj1 = new ArbolA(); //Se crea un objeto de la clase ArbolA.
                    obj1.Play(); //Se llama al método a través del objeto.
                    goto x;
                    
                case 2:
                    ArbolB obj2 = new ArbolB();
                    obj2.Play();
                    goto x;
                    
                case 3:
                    ArbolC obj3 = new ArbolC();
                    obj3.Play();
                    goto x;
                    
                case 4:
                    Console.WriteLine("Enter");
                    goto y;
                    
                default:
                    Console.WriteLine("Ingrese una opción válida.");
                    goto x;   
            }
            y:
            Console.ReadKey();
        }
    }
}
