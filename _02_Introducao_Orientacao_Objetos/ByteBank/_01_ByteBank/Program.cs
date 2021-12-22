namespace _01_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBruna = new ContaCorrente();

            contaDaBruna.Titular = "Bruna";

            Console.WriteLine(contaDaBruna.Titular);
        }
    }
}