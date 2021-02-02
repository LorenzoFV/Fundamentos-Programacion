using System;

namespace Desafio_03_03v3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite su salario mensual");
            double Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite su contrato: 1(Independiente) o 2(Dependiente)");
            int Contrato = int.Parse(Console.ReadLine());

            

            if(Contrato == 1)
            {
                int Riesgo;
                double BaseCotización = Salario * 0.4;
                double SMMLV = 908526;
                double ARL;

                double Base;
                double Pension;
                double EPS;

                if (BaseCotización > SMMLV)
                {
                    Base = BaseCotización;
                    Pension = BaseCotización * 0.16;
                    EPS = BaseCotización * 0.125;
                }
                else
                {
                    Base = SMMLV;
                    Pension = SMMLV * 0.16;
                    EPS = SMMLV * 0.125;
                }


                Console.WriteLine("Ingrese un número de 1 a 5 según a su clase de riesgo");
                Riesgo = int.Parse(Console.ReadLine());

                if(Riesgo == 1)
                {
                    ARL = (Base *0.522) / 100;
                }
                else if (Riesgo == 2)
                {
                    ARL = (Base * 1.044) / 100;
                }
                else if (Riesgo == 3)
                {
                    ARL = (Base * 2.436) / 100;
                }
                else if (Riesgo == 4)
                {
                    ARL = (Base * 4.350) / 100;
                }
                else
                {
                    ARL = (Base * 6.960) / 100;
                }

                double SalarioRealMensual = (Salario - Pension - EPS - ARL);
                double SalarioAnual = (SalarioRealMensual * 12);

                Console.WriteLine("Su salario real mensual es de:" + SalarioRealMensual);
                Console.WriteLine("Su salario anual es de:" + SalarioAnual);
                Console.WriteLine("Sus deducciones son de:" + (Pension + EPS + ARL));                
            }
            else
            {
                double BaseCotización = Salario * 0.4;
                double SMMLV = 908526;
                                
                double Pension;
                double EPS;

                if (BaseCotización > SMMLV)
                {
                    Pension = BaseCotización * 0.04;
                    EPS = BaseCotización * 0.04;
                }
                else
                {
                    Pension = SMMLV * 0.04;
                    EPS = SMMLV * 0.04;
                }

                double SalarioRealMensual = (Salario - Pension - EPS);
                double SalarioAnual = ((SalarioRealMensual * 12) + Salario);

                Console.WriteLine("Su salario real mensual es de:" + SalarioRealMensual);
                Console.WriteLine("Su salario anual es de:" + SalarioAnual);
                Console.WriteLine("Sus deducciones son de:" + (Pension + EPS));
                Console.WriteLine("Su prima:" + Salario);

            }






        }
    }
}
