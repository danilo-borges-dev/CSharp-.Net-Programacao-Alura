namespace _08_ByteBank
{
    internal class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular = new();
        private int _numero;
        private int _agencia;
        private double _saldo;
        public ContaCorrente(int numero, int agencia)
        {
            if (numero < 0)
            {
                Console.WriteLine("Número inválido para Conta!");
            }
            else
            {
                _numero = numero;
            }
            if (agencia < 0)
            {
                Console.WriteLine("Número inválido para Agência!");
            }
            else
            {
                _agencia = agencia;
            }
            TotalDeContasCriadas++;
        }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Valor Inválido para Depósito!");
                }
                _saldo += value;
            }
        }
        public bool Sacar(double valor)
        {
            if (valor > _saldo)  // Existe um retorno, portanto é comum chamar de Função
            {
                Console.WriteLine($"_saldo Insuficiente - _saldo Atual R${_saldo.ToString("F2")}");
                return false;
            }
            _saldo -= valor;
            Console.WriteLine($"Saque Realizado com Sucesso - Novo _saldo em Conta R${_saldo.ToString("F2")}");
            return true;
        }
        public void Depositar(double valor)  // Método
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor Inválido para Depósito!");
            }
            _saldo += valor;
            Console.WriteLine($"Depósito  realizado com Sucesso! - Novo _saldo em Conta R${_saldo}");
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor > _saldo)
            {
                Console.WriteLine($"_saldo Insuficiente para Transferir - _saldo Atual em Conta R${_saldo}");
                return false;
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine($"Transferência Realizada com Sucesso! - Titular {Titular} - _saldo Atual em Conta R${_saldo}");
            return true;
        }
    }
}
