using System;
using System.Globalization;

namespace _12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcula o fator de rendimento em juros em 12 meses e em 5 anos
            Console.WriteLine("Executando o Projeto 12");
            Console.WriteLine();

            double fatorDeRendimento = 1.0036;
            double valorInvestido = 1_000;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Fator de Rendimento do {i}º ano:");
                for (int j = 1; j <= 12; j++)
                {
                    valorInvestido *= fatorDeRendimento;
                    Console.WriteLine($"Rendimento no {j}º mês(s) R${valorInvestido.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                fatorDeRendimento += 0.0010; // A cada ano o fator de Rendimento aumenta em 0.0010%
                Console.WriteLine();
            }
        }
    }
}
