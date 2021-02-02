using System;

namespace Desafio_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su salario");
            double Salario = double.Parse(Console.ReadLine());

            if (Salario < 2029960)
            {
                Console.WriteLine("Tarifa A");
            }
            else if (2029960 <= Salario && Salario <= 4059920)
            {
                Console.WriteLine("Tarifa B");
            }
            else 
            {
                Console.WriteLine("Tarifa C");
            }

        }
    }
}
