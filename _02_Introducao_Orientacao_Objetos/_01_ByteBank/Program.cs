using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBruna = new ContaCorrente();

            contaDaBruna.Nome = "Bruna";
            contaDaBruna.Agencia = 123;
            contaDaBruna.Numero = 555;
            contaDaBruna.Saldo = 100;

            
        }
    }
}
