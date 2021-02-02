using System;

namespace Desafio_03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su salario");
            double Salario = double.Parse(Console.ReadLine());

            double SalarioMinimo = 1014980;


            if (Salario <= (SalarioMinimo*2))
            {
                Console.WriteLine("Su tarifa es A ");
                Console.WriteLine("Su cuota moderadora es de 3500$");

            }
            else if ((SalarioMinimo * 2) <= Salario && Salario <= (SalarioMinimo * 5))
            {
                Console.WriteLine("Su tarifa es B ");
                Console.WriteLine("Su cuota moderadora es de 14000$");

            }
            else
            {
                Console.WriteLine("Su tarifa es C ");
                Console.WriteLine("Su cuota moderadora es de 36800$");

            }


        }
    }
}
