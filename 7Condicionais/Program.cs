using System;

namespace _7Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            
            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade. Pode acessar");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João é menor de idade porém está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("João é menor de idade. Sai daqui moleque");
                }
            }

            Console.ReadLine();

        }
    }
}