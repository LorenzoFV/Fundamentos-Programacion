using System;

namespace Desafio_07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random valor = new Random();
            int dado = valor.Next(1, 6);
            int vidas = 3;
            int valortotal = dado;
            int turnos = 0;
            string continuar = "s";
            Console.WriteLine("El valor de su dado es de: " + dado);
            Console.WriteLine("El valor total que lleva es de: " + valortotal);
            Console.WriteLine("Si desea continua presione s. de lo contrario presione n.");
            continuar = Console.ReadLine();

            while (continuar == "s" && vidas > 0 && valortotal < 100)
            {
               dado = valor.Next(1, 6);
               valortotal += dado;
               Console.WriteLine("El valor de su dado es de: " + dado);
               Console.WriteLine("El valor total que lleva es de: " + valortotal);
               Console.WriteLine("Vidas restantes: " + vidas);

               Console.WriteLine("Si desea continua presione s. de lo contrario presione n.");
               continuar = Console.ReadLine();

                turnos++;

                if(turnos%3 == 0)
                {
                    int dado1 = valor.Next(1, 6);
                    int dado2 = valor.Next(1, 6);
                    valortotal += dado1 + dado2;
                    Console.WriteLine("El valor de su dado es de: " + dado1);
                    Console.WriteLine("El valor de su dado es de: " + dado2);
                    Console.WriteLine("El valor total que lleva es de: " + valortotal);

                    if(dado1 == dado2)
                    {
                        vidas++;
                        Console.WriteLine("Has ganado una vida");


                    }
                }

                if(turnos%2 == 0)
                {
                    vidas--;
                    Console.WriteLine("Has perdido una vida");

                }

                if(vidas == 0)
                {
                    Console.WriteLine("Has perdido");
                    break;
                }

            }

        }
    }
}
