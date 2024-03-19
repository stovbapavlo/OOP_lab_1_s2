using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v3
{
    class Program
    {
        delegate double Calculator(int n);

        static double CalculateSeriesSum(Calculator calulator, double precision)
        {
            double sum = 0.0;
            double term = 0.0;
            int n = 0;

            do
            {
                term = calulator(n);
                sum += term;
                n++;
                Console.WriteLine($"Iteration {n}: Term = {term}, Sum = {sum}");
            } while (Math.Abs(term) >= precision);


            return sum;
        }

/*        static double Term1(int n)
        {
            return 1.0 / Math.Pow(2, n); 
        }
        static double Term2(int n)
        {
            return 1.0 / Factorial(n + 1); 
        }
        static double Term3(int n) 
        {
            return Math.Pow(-1, n) / Math.Pow(2, n);
        }*/

        static int Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            double precision = 0.0001;
            Calculator calc1 = n => 1.0 / Math.Pow(2, n);
            double sum1 = CalculateSeriesSum(calc1, precision);

            Console.WriteLine($"Sum of series 1: {sum1}");

            Calculator calc2 = n => 1.0 / Factorial(n + 1);
            double sum2 = CalculateSeriesSum(calc2, precision);

            Console.WriteLine($"Sum of series 2: {sum2}");

            Calculator calc3 = n => Math.Pow(-1, n) / Math.Pow(2, n);
            double sum3 = CalculateSeriesSum(calc3, precision);

            Console.WriteLine($"Sum of series 3: {sum3}");




/*            double series1Sum = CalculateSeriesSum(Series1Term, precision);
            Console.WriteLine("Sum of series 1: " + series1Sum);

            double series2Sum = CalculateSeriesSum(Series2Term, precision);
            Console.WriteLine("Sum of series 2: " + series2Sum);

            double series3Sum = CalculateSeriesSum(Series3Term, precision);
            Console.WriteLine("Sum of series 3: " + series3Sum);*/


            Console.ReadKey();
        }
    }
}
