namespace _08_ByteBank
{
    internal class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string Cpf
        {
            get
            { 
                return _cpf;
            }

            set
            {
                // Minha validacao de CPF
            }
        }
        public string Proficao { get; set; }

    }
}
