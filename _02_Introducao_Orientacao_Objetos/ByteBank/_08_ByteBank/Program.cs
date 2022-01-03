namespace _08_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new(123, 123);
            ContaCorrente novaConta = new(123, 123);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas); // Propriedade Estatica da classe ContaCorrente
        }
    }
}
