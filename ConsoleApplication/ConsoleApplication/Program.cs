using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");


            Console.WriteLine("Podaj liczbę a:");
            var val1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę b:");
            var val2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("a + b = {0}", val1 + val2);

            Console.ReadLine();
        }
    }
}
