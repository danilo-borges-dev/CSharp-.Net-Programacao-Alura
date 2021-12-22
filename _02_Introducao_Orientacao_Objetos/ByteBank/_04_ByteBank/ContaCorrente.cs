namespace _01_ByteBank
{
    internal class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo;
        public bool Sacar(double valor)
        {
            if(valor > Saldo)
            {
                Console.WriteLine($"Saldo Insuficiente - Saldo Atual R${Saldo.ToString("F2")}");
                return false;
            }
            Saldo -= valor;
            Console.WriteLine($"Saque Realizado com Sucesso - Novo Saldo em Conta R${Saldo.ToString("F2")}");
            return true;
        }
    }
}
