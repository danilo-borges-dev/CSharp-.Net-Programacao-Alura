using System;

namespace _05_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos");

            char primeiraLetraNome = 'D';
            Console.WriteLine(primeiraLetraNome);

            Console.WriteLine();

            // Conversão "Cast" explícita de um valor inteiro para char.    
            primeiraLetraNome = (char)65;  // A conversão resulta em um valor existente na tabela ascii                  
            Console.WriteLine(primeiraLetraNome);

            Console.WriteLine();

            string titulo = "Alura Cursos de Tecnologia " + 2021 + "."; // Concatenação de Caracteres
            Console.WriteLine(titulo);

            Console.WriteLine();

            Console.WriteLine(titulo[0]); // String é um Vetor de Caractere, então, é possível acessar as posições do Vetor de Caracateres e exibir o valor

            Console.WriteLine();

            string mensagem = @"--------------------------------Primeira linha
--------------------------------Segunda Linha
--------------------------------Terceira Linha";

            Console.WriteLine(mensagem);
        }
    }
}
