using System;
using System.Globalization;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

            double valorInvestido = 1_000;
            double valorAtualizado = 0.0;

            valorAtualizado = valorInvestido + (valorInvestido * 0.05);

            Console.WriteLine($"Valor Investido R${valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor Investido em 01 Mês R${valorAtualizado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
