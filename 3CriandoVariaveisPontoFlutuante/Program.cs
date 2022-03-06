using System;

namespace _3CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine("Meu salário é de " + salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);
            //15 = int, mesmo declarado como double. 15.0 = double

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);




            Console.WriteLine(" ");
            Console.WriteLine("A execução acabou. Tecle ENTER para sair...");
            Console.ReadLine();
        }
    }
}
