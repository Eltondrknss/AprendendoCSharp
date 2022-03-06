using System;

namespace _2CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaiveis");

            int idade;

            idade = 32;
            Console.WriteLine(idade);
            idade = idade + 10;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine(idade);

            Console.WriteLine("A ordem matematica do VS é: Multiplicação e Divisão, e depois Soma e Subtração");

            Console.WriteLine("José Artordindio tem " + idade + " anos");
            Console.WriteLine(" ");

            Console.WriteLine("Execução finalizada. Tecle ENTER para sair...");
            Console.ReadLine();
        }
    }
}
