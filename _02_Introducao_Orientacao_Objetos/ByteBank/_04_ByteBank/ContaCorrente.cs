namespace _01_ByteBank
{
    internal class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo = 100;
        public bool Sacar(double valor)
        {
            if(valor > Saldo)
            {
                return false;
            }
            return true;
        }
    }
}
