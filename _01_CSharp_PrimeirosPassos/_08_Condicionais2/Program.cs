using System;

namespace _08_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao > 18 || quantidadePessoas > 1)
            {
                Console.WriteLine("João não é maior de idade mas está acompanhado! Pode Entrar!");
            }
            else
            {
                if (idadeJoao >= 18)
                {
                    Console.WriteLine("João é maior de idade! Pode Entrar!");
                }
                else
                {
                    Console.WriteLine("Menor de idade! Não Pode Entrar!");
                }
            }
        }
    }
}

