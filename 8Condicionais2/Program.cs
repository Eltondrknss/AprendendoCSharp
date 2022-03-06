using System;

namespace _8Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 18;
            //int quantidadePessoas = 0;
            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = false;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                {
                    Console.WriteLine("Sai daqui moleque");

                }
            }
            Console.ReadLine();
        }
    }
}
