using System;

namespace Desafio_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //entradas 

            Console.WriteLine("Digite su salario:");
            double Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Escoja su tipo de contrato 1.Independiente , 2.Dependiente:");
            int Contrato = int.Parse(Console.ReadLine());

            //variables

            double Pensión = 0;
            double EPS  = 0;
            double ARL = 0;
            double BaseCotización;
            double SMMLV = 908526;
            
            bool Cotizacion = (0.4 * Salario) > SMMLV;

            switch (Cotizacion)
            {
                case (true):
                    BaseCotización = 0.4 * Salario;
                    break;

                case (false):
                    BaseCotización = SMMLV;
                    break;


            }
                        
            switch (Contrato)
            {
                case (1):
                    Console.WriteLine("Digite un numero del 1 al 5 dependiendo su clase de riesgo");
                    int Riesgo = int.Parse(Console.ReadLine());

                    Pensión = 0.16 * BaseCotización;
                    EPS = 0.125 * BaseCotización;
                    

                    switch (Riesgo)
                    {
                        case (1): ARL = 0.0522 * BaseCotización; break;
                        case (2): ARL = 0.01044 * BaseCotización; break;
                        case (3): ARL = 0.02436 * BaseCotización; break;
                        case (4): ARL = 0.04350 * BaseCotización; break;
                        case (5): ARL = 0.06960 * BaseCotización; break;
                    }
                    
                    break;

                case (2):

                    Pensión = 0.04 * BaseCotización;
                    EPS = 0.04 * BaseCotización;

                    Console.WriteLine("Prima:" + Salario);

                    break;


            }

           
            //proceso
            
            double Deducciones = EPS + Pensión + ARL;
            double SalarioRealMensual = Salario - Deducciones;
            double SalarioAnual = (SalarioRealMensual * 12)+ Salario;

            //salidas

            Console.WriteLine("Su salario real:" + SalarioRealMensual);
            Console.WriteLine("Su salario anual:" + SalarioAnual);
            Console.WriteLine("Sus deducciones:" + Deducciones);


        }
    }
}
