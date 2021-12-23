namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente novaConta = new();

            // novaConta.Titular = new Cliente();

            novaConta.Titular.Nome = "Danilo";
            novaConta.Titular.Proficao = "Engenheiro de Software";

            novaConta.Depositar(100_000_000_000);

            Console.WriteLine(novaConta.Titular.Nome);
            Console.WriteLine(novaConta.Titular.Proficao);

            Console.WriteLine();

            ContaCorrente novaConta2 = new();

            novaConta2.Titular.Nome = "Marcos";
            novaConta2.Depositar(1_000_000);
            novaConta2.Titular.Proficao = "Empresário";

            Console.WriteLine(novaConta2.Titular.Nome);
            Console.WriteLine(novaConta2.Titular.Proficao);

            Console.WriteLine();

            Console.WriteLine(novaConta2.GetSaldo());
        }
    }
}
