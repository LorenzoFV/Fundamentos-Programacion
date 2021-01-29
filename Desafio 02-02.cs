using System;

namespace Desafio_02_02
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
            Console.WriteLine("Digite t:");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a:");
            a = double.Parse(Console.ReadLine());

            //Proceso 01
            c = 180 - a - 90;

            double cRad= c * Math.PI /180 ;
            double aRad = a * Math.PI / 180;

            //Proceso 02

            z = (Math.Sin(cRad) * t);
           
            y = (Math.Sin(aRad)*z)/Math.Sin(cRad);

            //Salidas
            Console.WriteLine("Y es igual a:"+ y);
            Console.WriteLine("Z es igual a:"+ z);
            Console.WriteLine("C es igual a:" + c);
        }
    }
}
