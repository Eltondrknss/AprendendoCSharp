using System;

namespace ZIG_ZAG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
