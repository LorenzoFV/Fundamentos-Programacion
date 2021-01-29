using System;

namespace Desafio_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //lados
            double z;
            double y;
            double t;
            //Angulos
            double c;
            double a;

            //Entrada
            Console.WriteLine("Digite z:");
            z = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite y:");
            y = double.Parse(Console.ReadLine());

            //Proceso 01 (hipotenusa)

            t = Math.Sqrt((z * z) + (y * y));

            //Proceso 02 (calcular angulo c)

            c = Math.Asin(3 / 3.61);
            double cGrados = c * 180 / Math.PI;

            //Proceso 03 (calcular angulo a)

            a = 180 - cGrados - 90;

            //Salidas

            Console.WriteLine("a es igual a:" + a + "°");

            Console.WriteLine("c es igual a:"+cGrados + "°");

            Console.WriteLine("t es igual a:" + t);


        }
    }
}
