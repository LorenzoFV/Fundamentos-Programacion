using System;

namespace Desafio_06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;

            double Seno = 0;

            Console.WriteLine("Digite x:");

            x = double.Parse(Console.ReadLine());

            int n = 100;

            for (int i = 0; i < n; i++)
            {
                Seno += ((Math.Pow(-1, i)) / (Factorial((2*i)+1))) * (Math.Pow(x,(2*i)+1));


            }

            Console.WriteLine(Seno);

        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);


        }
    }
}
