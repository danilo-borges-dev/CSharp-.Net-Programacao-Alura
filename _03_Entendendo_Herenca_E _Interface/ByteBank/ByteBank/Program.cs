using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new("Maria", "123", 100);

            GerenciadorBonificacao gerenciador = new();
            gerenciador.Registrar(funcionario);

            Funcionario diretorRoberta = new Diretor("Roberta", "123", 2_000);
            gerenciador.Registrar(diretorRoberta);

            Console.WriteLine($"Total de Bonificacoes: R${gerenciador.GetTotalBonificacao()}");
        }
    }
}
