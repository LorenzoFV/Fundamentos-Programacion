using System;

namespace Desafio_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //lados
            double w;            
            double t;
            double x;

            //angulos
            double c;
            
            double e;

            //entradas
            Console.WriteLine("Digite w:");
            w = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite t:");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite c:");
            c = double.Parse(Console.ReadLine());

            //proceso 01
                                 
            e = 180 - c;
            double eRad = e * Math.PI / 180;

            double dRad = Math.Asin((Math.Sin(eRad) * t) / w);
            double d = dRad * 180 / Math.PI;

            double b = 180 - d - e;
            double bRad = b * Math.PI / 180;

            //proceso 02

            x = (Math.Sin(bRad) * t) / Math.Sin(dRad);

            Console.WriteLine("x es igual a:"+ x);


        }
    }
}
