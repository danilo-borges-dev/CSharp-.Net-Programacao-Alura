namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new();

            #region Populando propriedades do Objeto conta
            conta.Titular.Nome = "Danilo Borges";
            conta.Titular.Cpf = "123.123.123.12";
            conta.Titular.Proficao = "Desenvolvedor C#";

            Console.WriteLine(conta.Titular.Nome);

            Console.WriteLine(conta.Titular);

            if(conta.Titular == null)
            {
                Console.WriteLine("A referência para o campo titular é Nulo");
            }
            #endregion
            conta.Saldo = 100;
            Console.WriteLine(conta.Saldo);
        }
    }
}
