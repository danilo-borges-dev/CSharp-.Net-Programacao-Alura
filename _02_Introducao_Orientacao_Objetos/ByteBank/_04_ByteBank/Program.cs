namespace _01_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new();

            contaDoBruno.Titular = "Bruno";
            contaDoBruno.Saldo = 100;

            Console.WriteLine();

            contaDoBruno.Sacar(50);
            contaDoBruno.Sacar(100);

            Console.WriteLine();

            contaDoBruno.Depositar(600);
            contaDoBruno.Depositar(-50);

            Console.WriteLine();

            ContaCorrente contaDaGabriela = new();
            contaDaGabriela.Titular = "Gabriela";

            contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine($"\nConta {contaDaGabriela.Titular} - R${contaDaGabriela.Saldo.ToString("F2")}");

        }
    }
}