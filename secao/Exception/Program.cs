using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Exception
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("digite um numero");
            try
            {
            int numero = int.Parse(Console.ReadLine());
            } catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadKey();
        }
    }
}