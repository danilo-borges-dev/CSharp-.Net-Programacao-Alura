using System;

namespace _02_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Projeto 2 - Criando Variáveis.");

            int idade = 28;

            Console.WriteLine($"Minha Idade é {idade}\n");

            idade += 10;

            Console.WriteLine(idade + "\n");

            Console.WriteLine("Tecle Enter para Sair!");
            Console.ReadLine();
        }
    }
}
