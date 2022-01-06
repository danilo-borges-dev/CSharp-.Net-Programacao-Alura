using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculaBonificacao();

            UsarSistema();

            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new();
            Diretor marcio = new("Mario", "123", 5_000, "123");
            sistemaInterno.Logar(marcio, "123");
            sistemaInterno.Logar(marcio, "abc\n");

            GerenteDeConta mateus = new("Mateus", "123", 4_000, "123");
            sistemaInterno.Logar(mateus, "123");

            Console.WriteLine();

            ParceiroComercial parceiroComercial = new("abc");
            sistemaInterno.Logar(parceiroComercial, "abc");
            sistemaInterno.Logar(parceiroComercial, "123");
        }
        #region Calcula a Bonificacao de Todos os Funcionarios
        public static void CalculaBonificacao()
        {
            GerenciadorBonificacao gerenciador = new();

            Diretor marcio = new("Mario", "123", 5_000, "123");
            Designer dani = new("Dani", "123", 3_000);
            GerenteDeConta mateus = new("Mateus", "123", 4_000, "123");
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
        }
        #endregion
    }
}
