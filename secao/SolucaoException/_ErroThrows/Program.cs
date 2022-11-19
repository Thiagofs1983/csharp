namespace _ErroThrows
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o numero 1: ");
            string digitado = Console.ReadLine();

            if (digitado == "1")
            {
                Console.WriteLine("Correto");
            } else
            {
                throw new Exception("O valor digitado não é valido");
            }
        }
    }
}