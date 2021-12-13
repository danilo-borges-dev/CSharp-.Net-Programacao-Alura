using System;

namespace _04_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4\n");

            double salary = 2_000.52;

            Console.WriteLine($"Salário: {salary}\n");

            int newSalary = (int)salary;

            Console.WriteLine($"Cast Salário: {newSalary}\n"); // Apresenta um número inteiro, perde-se a precisão

            /*Tipos para se trabalhar com números:
             * byte - consegue armazenar 8 bits (1 Byte)
             * shot - consegue armazenar 16 bits (2 Bytes)
             * int - consegue armazenar 32 bits (4 Bytes)
             * long - consegue armazenar 64 bits (8 Bytes)
             * float - consegue armazenar 32 bits (2 Bytes)
             * double - consegue armazenar 64 bits (4 Bytes)
             * decimal - consegue armazenar 128 bits (8 Bytes)
            */

            byte n1 = 100;
            short n2 = 1_0000;
            int n3 = 1_000_000;
            long n4 = 1_000_000_000_000_000_000;
            float n5 = 1.5F;
            double n6 = 1.6666666666666666;
            decimal n7 = 99999999999999999;

            Console.WriteLine("Tecle Enter para Encerrar!");
        }
    }
}
