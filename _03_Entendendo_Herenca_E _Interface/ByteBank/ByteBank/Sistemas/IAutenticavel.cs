namespace ByteBank.Sistemas
{
    internal interface IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha);
    }
}
