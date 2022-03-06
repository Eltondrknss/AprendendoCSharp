using System;

namespace _4ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            //int é usado pra valores até 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //long é usado pra numeros gigantes (64 bits)
            long idade = 2600000000000000;
            Console.WriteLine(idade);

            //short é um tipod e variavel de 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            //float é uma variavel com pouca precisão e precisa colocar o "f" depois do valor
            float altura = 1.80f;
            Console.WriteLine(altura);
            
            Console.ReadLine();
        }
    }
}
