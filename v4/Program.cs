using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v4
{
    class Program
    {
        delegate double Operation(double x);
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число та номер операції (0, 1 або 2), розділені пробілом:");
            Console.WriteLine("0 -- sqrt(abs(x))");
            Console.WriteLine("1 -- x^3");
            Console.WriteLine("2 -- x + 3.5");


            Operation[] operation = {
                x => Math.Sqrt(Math.Abs(x)),
                x => Math.Pow(x, 3),
                x => x + 3.5
            };


            while (true)
            {
                try
                {
                    string[] input = Console.ReadLine().Split();

                    int operationIndex = int.Parse(input[0]);
                    double number = double.Parse(input[1]);


                    double result = operation[operationIndex](number);
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.ReadKey();
                    break;
                }

            }
        }

    }
}
