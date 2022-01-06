using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    internal class Diretor : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public Diretor(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario)
        {
            Senha = senha;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15; // Salario = Salario * 1.15;
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
