namespace _01_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBruna = new ContaCorrente();

            contaDaBruna.Titular = "Bruna";
            contaDaBruna.Agencia = 12552;
            contaDaBruna.Numero = 1589365;
            contaDaBruna.Saldo = 100;

            Console.WriteLine($"Titular: {contaDaBruna.Titular}");
            Console.WriteLine($"Agencia: {contaDaBruna.Agencia}");
            Console.WriteLine($"Numero: {contaDaBruna.Numero}");
            Console.WriteLine($"Saldo R${contaDaBruna.Saldo}\n\n");

            ContaCorrente contaDaGabriela = new ContaCorrente();

            Console.WriteLine($"Titular: {contaDaGabriela.Titular}");
            Console.WriteLine($"Agencia: {contaDaGabriela.Agencia}");
            Console.WriteLine($"Numero: {contaDaGabriela.Numero}");
            Console.WriteLine($"Saldo R${contaDaGabriela.Saldo}\n\n");

            Console.WriteLine(contaDaBruna == contaDaGabriela);  // Estamos tentando comparar os valoes de referencia, logicamente sao diferentes, resultado False

            int idade = 28;
            int idade2 = 28;

            Console.WriteLine(idade == idade2);  // Comparacao de Tipo, resultado True

            Console.WriteLine("\n\n");

            contaDaBruna = contaDaGabriela;

            Console.WriteLine(contaDaGabriela == contaDaBruna);

            contaDaGabriela.Saldo = 300;

            Console.WriteLine($"\n\nSaldo R${contaDaBruna.Saldo}\n");
            Console.WriteLine($"Saldo R${contaDaGabriela.Saldo}\n");
        }
    }
}