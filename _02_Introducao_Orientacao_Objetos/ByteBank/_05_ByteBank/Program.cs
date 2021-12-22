namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente novoCliente = new();

            novoCliente.Nome = "Gabriela";

            ContaCorrente contaDaGabriela = new();

            contaDaGabriela.Titular = novoCliente;

            Console.WriteLine(contaDaGabriela.Titular.Nome);
        }
    }
}
