using System;

namespace appHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Punto2D a;
            a = new Punto2D(-1.45, -2.88);
            Console.WriteLine(a.ToString());

            Punto2D b;
            b = new Punto2D(3.55, 9.02);
            Console.WriteLine(b.ToString()); */

            Punto3D a;
            a = new Punto3D(2, 2, 4);
            Console.WriteLine(a.ToString());

            Punto3D b;
            b = new Punto3D(3, 3, 7);
            Console.WriteLine(b.ToString());

            double d = a.Distancia(b);
            Console.WriteLine("Distancia " + d);

            Console.ReadKey();


        }
    }
}