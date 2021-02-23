using System;

namespace Desafio_06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            double euler = 0;

            Console.WriteLine("Digite x:");

            x = int.Parse(Console.ReadLine());

            int n = 100;

            for(int i= 0;i <n;i++)
            {
               euler += (Math.Pow(x, i))/(Factorial(i));
                

            }

            Console.WriteLine(euler); 
        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);


        }
    }
}
