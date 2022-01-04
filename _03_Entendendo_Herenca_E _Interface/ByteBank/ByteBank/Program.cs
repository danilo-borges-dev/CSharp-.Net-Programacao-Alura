using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new();

            Diretor marcio = new("Mario", "123", 5_000);
            Designer dani = new("Dani", "123", 3_000);
            GerenteDeConta mateus = new("Mateus", "123", 4_000);
            Auxiliar jessica = new("Jessica", "123", 2_000);

            Console.WriteLine($"\n# Diretor {marcio.Nome}");
            Console.WriteLine($"Salario atual R${marcio.GetSalario().ToString("F2")}");
            Console.WriteLine($"Total da Bonificacao R${marcio.GetBonificacao().ToString("F2")}");
            marcio.AumentarSalario();
            Console.WriteLine($"Novo Salario R${marcio.GetSalario().ToString("F2")}");


            Console.WriteLine($"\n# Designer {dani.Nome}");
            Console.WriteLine($"Salario atual R${dani.GetSalario().ToString("F2")}");
            Console.WriteLine($"Total da Bonificacao R${dani.GetBonificacao().ToString("F2")}");
            dani.AumentarSalario();
            Console.WriteLine($"Novo Salario R${dani.GetSalario().ToString("F2")}");

            Console.WriteLine($"\n# Gerente de Conta {mateus.Nome}");
            Console.WriteLine($"Salario atual R${mateus.GetSalario().ToString("F2")}");
            Console.WriteLine($"Total da Bonificacao R${mateus.GetBonificacao().ToString("F2")}");
            mateus.AumentarSalario();
            Console.WriteLine($"Novo Salario R${mateus.GetSalario().ToString("F2")}");

            Console.WriteLine($"\n# Auxiliar {jessica.Nome}");
            Console.WriteLine($"Salario atual R${jessica.GetSalario().ToString("F2")}");
            Console.WriteLine($"Total da Bonificacao R${jessica.GetBonificacao().ToString("F2")}");
            jessica.AumentarSalario();
            Console.WriteLine($"Novo Salario R${mateus.GetSalario().ToString("F2")}");

            gerenciador.Registrar(marcio);
            gerenciador.Registrar(dani);
            gerenciador.Registrar(mateus);
            gerenciador.Registrar(jessica);

            Console.WriteLine($"\n\nTotal de Bonificacoes R${gerenciador.GetTotalBonificacao().ToString("F2")}");

            Console.ReadLine();
        }
    }
}
