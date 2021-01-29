using System;

namespace Desafio_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //lados
            double t;
            double z;
            double y;

            //angulos
            double a;
            double c;

            //Entradas
            Console.WriteLine("Digite c:");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite z:");
            z = double.Parse(Console.ReadLine());

            //Proceso 01
            a = 180 - c - 90;

            double cRad = c * Math.PI / 180;
            double aRad = a * Math.PI / 180;

            //Proceso 02

            y = (Math.Sin(aRad) * z) / Math.Sin(cRad);

            //Proceso 03

            t=Math.Sqrt((z * z) + (y * y));

            //Salidas
            Console.WriteLine("a es igual a:"+ a);
            Console.WriteLine("y es igual a:" + y);
            Console.WriteLine("t es igual a:" + t);
        }
    }
}
