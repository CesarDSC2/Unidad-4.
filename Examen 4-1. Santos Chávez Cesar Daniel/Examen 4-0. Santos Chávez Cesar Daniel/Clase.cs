using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4_0.Santos_Chávez_Cesar_Daniel
{
    class Clase
    {
        public void Play()
        {
            /*1.-San Francisco ; 2.- Los Angeles ; 3.- Denver ; 4.- Chicago ; 
             * 5.- Boston ; 6.- Nueva York ; 7.- Atlanta ; 8.- Miami*/
            int[,] graph =  { //En esta matriz guardamos la distancia entre cada punto.
                            //1  2  3  4  5  6  7  8
                            { 0, 349, 957, 1855, 0, 2534, 0, 0}, //1 
                            { 349, 0, 834, 0, 0, 2451, 0, 0},//2
                            { 957, 834, 0, 908, 0, 0, 0, 0},//3
                            { 1855, 0,908, 0, 860, 722, 606, 0},//4
                            { 0, 0, 0, 860, 0, 191, 0, 0},//5
                            { 2534, 2451, 0, 722, 191, 0, 760,1090},//6
                            { 0, 0, 0, 606, 0, 760, 0,595},//7
                            { 9, 11, 0, 0, 0, 1090, 595, 0},//8
                            };
            Metodo obj = new Metodo(); //Instanciación de la clase.
        x: //Marca
            Console.WriteLine("\nEnter..");            
            Console.ReadKey();
            Console.Clear();

            Console.Write("¿Qué distancia desea consultar? \n1.-Boston - Los Angeles \n2.-Nueva York - San Francisco" +
                "\n3.-Atlanta - San Francisco \n4.-Denver - Nueva York \n5.-Salir. \nOpción: "); //Menu
            int opc = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Boston - Los Angeles");
                    obj.Algoritmo(graph, 1, 4); //Llamamos al Algoritmo, y mandamos como parámetro la matriz (grafo), el punto origen y el destino.
                    goto x;                    
                case 2:
                    Console.WriteLine("Nueva York - San Francisco");
                    obj.Algoritmo(graph, 0, 5);
                    goto x;
                case 3:
                    Console.WriteLine("Atlanta - San Francisco");
                    obj.Algoritmo(graph, 0, 6);
                    goto x;
                case 4:
                    Console.WriteLine("Denver - Nueva York");
                    obj.Algoritmo(graph, 2, 5);
                    goto x;
                case 5:
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida");
                    goto x;
            }            
        }
        
    }
}
