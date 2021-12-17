using System;
using System.Globalization;

namespace _11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11 - Calcula Poupança");

            double valorInvestido = 1_000;

            Console.WriteLine($"Valor Investido R${valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");

            for (int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.0036; // valorInvestido += 1_000 * 1.0036 - Em Multiplicação refere que qualquer número multiplicado por "1" mantém a sua identidade (fica igual)
                Console.WriteLine($"Valor Investido em {i} Mês(s) R${valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
