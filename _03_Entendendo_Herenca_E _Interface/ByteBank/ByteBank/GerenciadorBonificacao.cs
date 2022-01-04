using ByteBank.Funcionarios;

namespace ByteBank
{
    internal class GerenciadorBonificacao // Esta Classe apenas registra o total de bonificacoes
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
