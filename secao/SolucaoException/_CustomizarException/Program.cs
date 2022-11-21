namespace _CustomizarException
{
    class Program
    {
        static void Main()
        {
            try
            {
                throw new MinhaException("1");
            } catch (MinhaException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}