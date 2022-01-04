using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GerenciadorBonificacao gerenciador = new();

            Diretor diretorRoberta = new("Roberta", "123", 2_000);
            gerenciador.Registrar(diretorRoberta);

            Console.WriteLine($"Bonificacao Diretor R${diretorRoberta.GetBonificacao()}");
            Console.WriteLine($"Total de Bonificacoes: R${gerenciador.GetTotalBonificacao()}");
        }
    }
}
