using System;

namespace Tutoría_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Random aleatorio = new Random();

            int jugador = 0;
            int n = 0;

            int Ganador = 0;

            Console.WriteLine("Digite la cantidad de jugadores qué van a jugar (2-5 max)");
            n = int.Parse(Console.ReadLine());

            while (n <2 || n > 5)
            {
                Console.WriteLine("Esa no es una cantidad válida de jugadores, vuelva a intentarlo:");
                n = int.Parse(Console.ReadLine());
            }

            while (jugador < n)
            {
                Console.WriteLine("Bienvenido jugador" + jugador);

                int Carta = 0, totalValorCartas = 0;
                string Continuar = "s";


                int CartaI1 = 0;
                int CartaI2 = 0;

                CartaI1 = aleatorio.Next(1, 10);
                CartaI2 = aleatorio.Next(1, 10);

                totalValorCartas = CartaI2 + CartaI1;

                Console.WriteLine("Cartas iniciales:");
                Console.WriteLine(CartaI1);
                Console.WriteLine(CartaI2);

                Console.WriteLine("Total de cartas:" + totalValorCartas);

                //Ciclo
                Console.Write("Desea Continuar (s/n):");
                Continuar = Console.ReadLine();

                while(Continuar != "s" && Continuar != "n")
                {
                    Console.WriteLine("Respuesta no válida, vuelva a intentarlo:");
                    Continuar = Console.ReadLine();

                }

                while (Continuar == "s" && totalValorCartas < 22)
                {
                    Carta = aleatorio.Next(1, 10);
                    Console.WriteLine("Carta =" + Carta);

                    totalValorCartas += Carta;

                    if(totalValorCartas == 21)
                    {
                        Console.WriteLine("Ganaste el juego");
                        break;

                    }
                    
                    if (totalValorCartas > 21)
                    {
                        Console.WriteLine("Lo sentimos");
                    }
                    else
                    {
                        if (totalValorCartas > Ganador) Ganador = jugador;

                        Console.WriteLine("Total = " + totalValorCartas);
                        Console.Write("Desea Continuar (s/n):");
                        Continuar = Console.ReadLine();

                        while (Continuar != "s" && Continuar != "n")
                        {
                            Console.WriteLine("Respuesta no válida, vuelva a intentarlo:");
                            Continuar = Console.ReadLine();

                        }

                    }

                }

                Console.WriteLine("Su total fue de:" + totalValorCartas);
                Console.WriteLine("Pa tu casa Jonaidel");

                jugador++;

                
            }

            Console.WriteLine("El ganador fue: " + Ganador);
            Console.WriteLine("Muchas gracias por jugar");

        }
    }
}
