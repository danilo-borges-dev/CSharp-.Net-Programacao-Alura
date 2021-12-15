using System;

namespace _09_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 9 - Escopo");

            int idadeJoao = 16;
            int quantidadePessoas = 1;
            bool acompanhado;
            string mensagemAdicional;

            acompanhado = quantidadePessoas > 1 ? true : false;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado!";
            }
            if (idadeJoao < 18 && acompanhado == true)
            {
                Console.WriteLine("João não é maior de idade mas " + mensagemAdicional + " Pode Entrar!");
            }
            else
            {
                if (idadeJoao >= 18)
                {
                    Console.WriteLine("João é maior de idade! Pode Entrar!");
                    Console.WriteLine(mensagemAdicional);
                }
                else
                {
                    Console.WriteLine("Menor de idade! Não Pode Entrar!");
                    Console.WriteLine(mensagemAdicional);
                }
            }
        }
    }
}
