using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleExpressionEvaluator;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");

            ExpressionEvaluator expressionEvaluator = new ExpressionEvaluator();
            Console.WriteLine("Podaj wyrażenie: ");
            var expression = Console.ReadLine();
            var result = expressionEvaluator.Evaluate(expression);

            Console.WriteLine("Wynik: {0}", result);


            Console.ReadLine();
        }
    }
}
