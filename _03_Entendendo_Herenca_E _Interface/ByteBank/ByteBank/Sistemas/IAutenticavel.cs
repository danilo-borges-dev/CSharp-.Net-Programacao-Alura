namespace ByteBank.Sistemas
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }
        bool Autenticar(string senha);
    }
}
