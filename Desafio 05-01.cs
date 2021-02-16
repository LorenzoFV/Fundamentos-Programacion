using System;

namespace Desafio_05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double totalEdades = 0;
            int n;
            int Contador = 0, max = 0, min = 100;

            string NombreMayor = "nn";
            string NombreMenor = "nn";
            //Entrada
            Console.Write("Ingrese el numero de datos (n) =");
            n = int.Parse(Console.ReadLine());

            while (Contador < n)
            {
                Console.Write("Digite el nombre:");
                string Nombre = Console.ReadLine();
                Console.Write("Digite la edad:");
                int Edad = int.Parse(Console.ReadLine());

                if (Edad > max)
                {
                    max = Edad;
                    NombreMayor = Nombre;
                }

                if (Edad < min)
                {
                    min = Edad;
                    NombreMenor = Nombre;
                }


                totalEdades += Edad;
                Contador++;    

            }
            double Promedio = totalEdades / n;
            Console.WriteLine("Promedio =" + Promedio);
            Console.WriteLine("Mayor = " + max);
            Console.WriteLine("Nombre del mayor = " + NombreMayor);
            Console.WriteLine("Menor = " + min);
            Console.WriteLine("Nombre del menor = " + NombreMenor);

            



        }
    }
}
