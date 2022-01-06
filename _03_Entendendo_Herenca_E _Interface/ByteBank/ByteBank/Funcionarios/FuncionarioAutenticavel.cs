using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    internal abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario)
        {

        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
