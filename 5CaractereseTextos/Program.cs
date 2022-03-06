using System;

namespace _5CaractereseTextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) 65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "To com tanta fome que comeria 1 quilo de batata frita " + 2022;
            string cursosProgramacao =
@"linha 1
linha 2
linha 3
linha 4";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine(titulo);

            string vazia = "";



            

            Console.ReadLine();
        }
    }
}
