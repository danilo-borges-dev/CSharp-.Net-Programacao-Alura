namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoJose = new();

            contaDoJose.Titular = new Cliente();  // O Objeto contaDoJose possui uma Propriedade (variavel) que esta apotando (referencia) para as Propriedades da Classe Cliente.

            contaDoJose.Titular.Nome = "José";
            contaDoJose.Titular.Proficao = "Programador C#";

            Console.WriteLine(contaDoJose.Titular.Nome);
            Console.WriteLine(contaDoJose.Titular.Proficao);
        }
    }
}
