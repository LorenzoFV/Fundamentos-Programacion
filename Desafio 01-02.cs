using System;

namespace Desafio_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //lados
            double z;
            double y;
          
            //angulos
            double b;
            double c;
            double e;
            double d;
            double a;

            //entradas
            Console.WriteLine("Digite d:");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite y:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite b:");
            b = double.Parse(Console.ReadLine());

            //procesos 01

            e = 180 - b - d;

            c = 180 - e;
            double cRad = c * Math.PI / 180;

            a = 180 - c - 90;
            double aRad = a * Math.PI / 180;

            //proceso 02

            
            z = (y * Math.Tan(cRad));

            Console.WriteLine("z es igual a:"+z);


        }
    }
}
