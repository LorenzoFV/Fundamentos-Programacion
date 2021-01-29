using System;

namespace Desafio_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //lados
            double w;
            double x;
            double t;
            double y;

            //angulos
            double d;
            

            //entradas
            Console.WriteLine("Digite w:");
            w = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite d:");
            d = double.Parse(Console.ReadLine());

            double dRad = d * Math.PI / 180;

            //proceso 01

            t = Math.Sqrt((w * w) + (x * x)-2*5*2*Math.Cos(dRad));

            double bRad = Math.Asin(Math.Sin(dRad) * 2 / t);
            double b = bRad * 180 / Math.PI;

            //proceso 02
            double e = 180 - b - d;
            double c = 180 - e;

            double a = 180 - c - 90;
            double aRad = a * Math.PI / 180;

            //proceso 03
            y = (Math.Sin(aRad) * t);

            Console.WriteLine("y es igual a:"+ y);


        }
    }
}
