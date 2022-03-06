using System;

namespace _9Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }

            //caso o ELSE tiver apenas 1 comando não precisa de chaves

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
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
