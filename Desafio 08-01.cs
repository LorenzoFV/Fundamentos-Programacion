using System;
using System.Collections.Generic;


namespace Desafio_08_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite una frase:");
            string Entrada = Console.ReadLine();
            Console.WriteLine("Digite una palabra:");
            string Palabra = Console.ReadLine();

            string EntradaMayus = Entrada.ToUpper();
            string PalabraMayus = Palabra.ToUpper();
                       
            int ContadorPalabra = 0;

            string[] Frase = EntradaMayus.Split();

            for(int i= 0; i< Frase.Length; i++)
            {
                if(Frase[i] == PalabraMayus)
                {
                    Console.WriteLine("Palabra encontrada en la posición:" + (i + 1));
                    ContadorPalabra++;
                }

               
            }

            Console.WriteLine("La palabra "+ PalabraMayus +" se encuentra " + ContadorPalabra + " veces.");

        }
    }
}
