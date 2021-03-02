using System;

namespace Desafio_07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random valor = new Random();
            int dado = valor.Next(1, 6);
            int dadoAnterior = 0;
            int valortotal = dado;
            string continuar = "s";

            int CantidadDadoEspecial = 2;
            string DadoEspecial = "e";

            Console.WriteLine("el valor de su dado es de: " + dado);
            Console.WriteLine("El valor total que lleva es de: " + valortotal);
            Console.WriteLine("Si desea continua prsione s. de lo contrario presiones n.");            

            
            continuar = Console.ReadLine();
            int vidas = 3;
            int contadorunos = 0;                                           

            while (continuar == "s" && valortotal < 100 && vidas > 0)
            {
                dado = valor.Next(1, 6);
                Console.WriteLine("El valor de su dado es de: " + dado);
                valortotal += dado;

                Console.WriteLine("El valor total que lleva es de: " + valortotal);
                Console.WriteLine("Si desea continua prsione s. de lo contrario presiones n.");
                Console.WriteLine("Si desea tirar dado especial, presione dos veces: e.");
                continuar = Console.ReadLine();
                DadoEspecial = Console.ReadLine();


                if (dado == 1)
                {
                    contadorunos++;

                    if (contadorunos % 2 == 0)
                    {
                        vidas -= 1;
                        valortotal -= 10 + dado;
                        Console.WriteLine("Vidas restantes:" + vidas);

                    }
                }                            

                if(dadoAnterior == 6 && dado == 6 && vidas<3)
                {
                    vidas++;
                }

                dadoAnterior = dado;

                while (DadoEspecial == "e" && CantidadDadoEspecial > 0)
                {
                    int dadoEspecial = valor.Next(1, 12);
                    Console.WriteLine("El valor de su dado es de: " + dado);

                    valortotal += dadoEspecial;
                    Console.WriteLine("El valor total que lleva es de: " + valortotal);

                    CantidadDadoEspecial--;

                    Console.WriteLine("Si desea tirar dado especial: e.");


                    Console.WriteLine("Si desea continuar con dados normales, presione s. de lo contrario presiones n.");

                    DadoEspecial = Console.ReadLine();
                    continuar = Console.ReadLine();

                    if (CantidadDadoEspecial < 1)
                    {
                        Console.WriteLine("Te quedaste sin dados especiales");
                        continuar = "s";

                    }
                }

            }

            if (continuar != "s")
            {
                Console.WriteLine("Te fuiste");
            }
            else if (vidas == 0)
            {
                Console.WriteLine("Chao");
            }

            if( valortotal > 99)
            {
                Console.WriteLine("Ganaste");
            }
        }
    }
}
