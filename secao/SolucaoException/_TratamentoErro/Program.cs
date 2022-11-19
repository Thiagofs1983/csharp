namespace _TratamentoErro
{
    class Program
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa();
            try
            {
                pessoa.SetCEP("32530060");
                Console.WriteLine(pessoa.getCep());

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}