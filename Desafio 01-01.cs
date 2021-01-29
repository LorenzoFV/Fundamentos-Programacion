using System;

namespace Desafio_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //lados
            double z;
            double y;
            double t;

            //angulos
            double b;
            double c;
            double e;
            double d;

            //entradas
            Console.WriteLine("Digite z:");
            z = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite y:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite b:");
            b = double.Parse(Console.ReadLine());

            double bRad = b * Math.PI / 180;

            //proceso 01 (hipotenusa triangulo 1)

            t = Math.Sqrt((z * z) + (y * y));

            //proceso 02 (conocer angulo c)

            c = Math.Asin(z / t);
            double cGrados = c * 180 / Math.PI;

            //proceso 03 (conocer angulo e)

            e = 180 - cGrados;

            //proceso 04 (conocer d)

            d = 180 - e - b;
            double dRad = d * Math.PI / 180;

            //proceso 05 (conocer x)

            double x = (Math.Sin(bRad) * t) / Math.Sin(dRad);

            

            Console.WriteLine("x es igual a:"+ x);

        }
    }
}
