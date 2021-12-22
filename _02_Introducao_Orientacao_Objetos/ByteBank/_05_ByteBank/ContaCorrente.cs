namespace _05_ByteBank
{
    internal class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo;
        public bool Sacar(double valor)
        {
            if(valor > Saldo)  // Existe um retorno, portanto é comum chamar de Função
            {
                Console.WriteLine($"Saldo Insuficiente - Saldo Atual R${Saldo.ToString("F2")}");
                return false;
            }
            Saldo -= valor;
            Console.WriteLine($"Saque Realizado com Sucesso - Novo Saldo em Conta R${Saldo.ToString("F2")}");
            return true;
        }
        public void Depositar(double valor)  // Método
        {
            if(valor < 0)
            {
                Console.WriteLine("Valor Inválido para Depósito!");
            }
            Saldo += valor;
            Console.WriteLine($"Depósito  realizado com Sucesso! - Novo Saldo em Conta R${Saldo}");
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(valor > Saldo)
            {
                Console.WriteLine($"Saldo Insuficiente para Transferir - Saldo Atual em Conta R${Saldo}");
                return false;
            }
            Saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine($"Transferência Realizada com Sucesso! - Titular {Titular} - Saldo Atual em Conta R${Saldo}");
            return true;
        }
    }
}
