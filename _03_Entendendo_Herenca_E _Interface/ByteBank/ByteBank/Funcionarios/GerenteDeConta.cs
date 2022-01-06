using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    internal class GerenteDeConta : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public GerenteDeConta(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario)
        {
            Senha = senha;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
