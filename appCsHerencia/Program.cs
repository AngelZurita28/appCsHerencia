using System;

namespace appHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Punto2D a;
            a = new Punto2D(98, 76);
            Console.WriteLine(a.ToString());

            Punto a2;
            a2 = new Punto(5.99);*/

            Punto3D a3;
            a3 = new Punto3D(8, 7, 9);
            Console.WriteLine(a3.ToString());

            Console.ReadKey();


        }
    }
}