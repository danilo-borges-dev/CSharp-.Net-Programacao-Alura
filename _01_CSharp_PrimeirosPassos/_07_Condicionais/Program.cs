using System;

namespace _07_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 1;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Maior de Idade! Pode Entrar!");
            }
            else
            {
                if (quantidadePessoas > 1)
                {
                    Console.WriteLine("João não é maior de idade mas está acompanhado! Pode Entrar!");
                }
                else
                {
                    Console.WriteLine("Menor de idade! Não Pode Entrar!");
                }
            }
        }
    }
}
