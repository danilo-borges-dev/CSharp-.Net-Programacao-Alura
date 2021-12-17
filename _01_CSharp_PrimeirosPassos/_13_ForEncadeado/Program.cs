using System;

namespace _13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 13");

            /* Crie um código utilizando um loop de repeticao For que exiba no console a seguinte imagem:
             *  *
             *  **
             *  ***
             *  ****
             *  *****
             *  ******
             *  *******
             *  ********
            */

            string caractere = "*";

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 1; j++)  // Este For exibe 1 vez a mensagem (caracteres *) e retorna para o For externo
                {
                    Console.Write(caractere);
                }
                Console.WriteLine();
                caractere += "*";
            }

            Console.WriteLine();

            // Outra forma de resolver o problema com a adição do comando Condicional if e comando break

            caractere = "*"; // Defini um novo valor para a variável caractere

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(caractere);
                    if (j >= i)  // O contato i representa as linhas, enquanto o contador j representa as colunas, então, quando o número de colunas for maior ou igual ao número de linhas, faça:
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
