namespace _01_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        { 
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.Titular = "Bruno";
            contaDoBruno.Saldo = 100;
            contaDoBruno.Sacar(50);
            contaDoBruno.Sacar(100);

            Console.WriteLine();

            contaDoBruno.Depositar(600);
            contaDoBruno.Depositar(-50);
        }
    }
}