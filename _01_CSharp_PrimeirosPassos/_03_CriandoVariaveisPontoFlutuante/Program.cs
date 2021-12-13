using System;

namespace _03_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 - Criando Variáveis Ponto Flutuante!\n");

            float numberFloat = 1.50F;
            double salary = 1_200.70;
            double number = 1_000;
            double age = 15 / 2;
            double newAge = 15.0 / 2.0;
            double number2 = 5.0 / 3;

            Console.WriteLine($"Numero Ponto Flutuante Float: {numberFloat}\n");

            Console.WriteLine($"Salário: {salary}\n");

            Console.WriteLine($"Idade: {age}\n");

            Console.WriteLine($"Nova idade: {newAge}\n");

            Console.WriteLine($"Ajuste nas casas decimais: {number2.ToString("F2")}\n");

            Console.WriteLine("Tele Enter para Encerrar!");
            Console.ReadLine();
        }
    }
}
