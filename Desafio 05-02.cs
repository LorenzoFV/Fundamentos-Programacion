using System;

namespace Desafio_05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables

            Random Numero = new Random();
            string continuar = "s";
            int dado1 = 0;
            int dado2 = 0;
            
            int valortotal = dado1 + dado2;

            int Seises = 0;
            int Turnos = 0;
            double PorcentajeSeis = 0;

            int DoblesConsecutivos = 0;

            //Entradas

                      
            while (continuar == "s" && (dado1 + dado2) != 2 && valortotal <100)
            {
                Turnos++;

                dado1 = Numero.Next(1, 7);
                dado2 = Numero.Next(1, 7);
                valortotal += dado1 + dado2;
                Console.WriteLine("El valor del dado 1 es: " + dado1);
                Console.WriteLine("El valor del dado 2 es: " + dado2);

                if(dado1 == dado2)
                {
                    DoblesConsecutivos++;
                }

                if((dado1 + dado2) > 6 )
                {
                    Seises++;
                }

                PorcentajeSeis = (100 * Seises) / Turnos;

                if (valortotal > 99 || DoblesConsecutivos > 2)
                {
                    Console.WriteLine("El total es: " + valortotal);
                    Console.WriteLine("El porcentaje de rondas donde sacó más de 6 es: " + PorcentajeSeis + "%");
                    Console.WriteLine("Freiner, ganaste");
                }

                if ((dado1 + dado2) != 2 && valortotal < 100)
                {
                    Console.WriteLine("El total es: " + valortotal);
                    Console.Write("Si desea seguir tirando presione (s) de lo contrario, presione (n): ");
                    continuar = Console.ReadLine();
                }


            }

            if(valortotal< 99)
            {
                Console.WriteLine("Hasta luego jon alexis");
                Console.WriteLine("El porcentaje de turnos donde sacó más de 6 es: " + PorcentajeSeis + "%");
            }

            




        }
    }
}

