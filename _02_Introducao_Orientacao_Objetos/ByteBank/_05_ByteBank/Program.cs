namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente novoCliente = new();  // Variavel novoCliente, referencia para o Objeto Cliente

            novoCliente.Nome = "Gabriela";

            ContaCorrente contaDaGabriela = new();

            contaDaGabriela.Titular = novoCliente;  // Propriedade Titular recebe a Referencia para o Objeto Cliente "novoCliente"

            Console.WriteLine(contaDaGabriela.Titular.Nome);

            Console.WriteLine();

            contaDaGabriela.Titular.Nome = "João";
            contaDaGabriela.Titular.Proficao = "Desenvolvedor C#"; // Atraves da variavel de Referencia Titular podemos acessar propriedades da Classe Cliente

            Console.WriteLine(contaDaGabriela.Titular.Nome);
            Console.WriteLine(contaDaGabriela.Titular.Proficao);

            Console.WriteLine();
        }
    }
}
