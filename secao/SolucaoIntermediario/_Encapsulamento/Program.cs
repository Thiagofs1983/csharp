namespace _Encapsulamento
{
    class Program
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.SetNome("Thiago Fonseca");
            Console.WriteLine(pessoa.GetNome());
        }
    }
}