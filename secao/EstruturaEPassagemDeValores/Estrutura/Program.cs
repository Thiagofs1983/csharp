namespace Estrutura
{
    class Program
    {
        static void Main()
        {
            Polegada polegada = new(10);
            Console.WriteLine(polegada.Centimetro());
        }
    }
}