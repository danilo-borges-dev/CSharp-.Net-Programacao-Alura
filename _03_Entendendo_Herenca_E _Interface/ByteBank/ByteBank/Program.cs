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

            Console.WriteLine($"\nTotal de Funcionarios: {Funcionario.TotalDeFuncionarios}");

            Console.WriteLine($"\nSalario atual do Diretor R${diretorRoberta.GetSalario()}");

            diretorRoberta.AumentarSalario();
            Console.WriteLine($"\nNovo Salario do Diretor R${diretorRoberta.GetSalario()}");

        }
    }
}
