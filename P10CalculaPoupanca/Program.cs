using System;

namespace P10CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;


            while(contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;

                if(contadorMes == 1)
                {
                    Console.WriteLine("Após " + contadorMes + " mês você terá " + valorInvestido.ToString("C"));
                }
                else
                {
                    Console.WriteLine("Após " + contadorMes + " meses você terá " + valorInvestido.ToString("C"));
                }


                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }
                        
            Console.ReadLine();
        }
    }
}
