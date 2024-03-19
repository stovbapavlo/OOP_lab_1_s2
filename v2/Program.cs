using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate bool FilterDelegate(int number, int k);

namespace v2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Enter k elemet:");
            int k = int.Parse(Console.ReadLine());

            int[] filter1 = FilterArrayWhitWhere(array, k);
            PrintArray(filter1);

            int[] filter2 = FilterArrayWhithoutWere(array, k);
            PrintArray(filter2);

            Console.ReadKey();

        }


        static int[] FilterArrayWhitWhere(int[] array, int k)
        {
            FilterDelegate filter = (number, divisor) => number % divisor == 0;
            return Array.FindAll(array, x => filter(x, k));
        }

        static int[] FilterArrayWhithoutWere(int[] array, int k)
        { 
            FilterDelegate filter = (number, divisior) => number % divisior == 0;
            int[] result =  new int[array.Length];
            int count = 0;

            for (int i = 0; i < array.Length; i++) 
            {
                if (filter(array[i], k))
                {
                    result[count] = array[i];
                    count++;
                }
                
            }
            Array.Resize(ref result, count);
            return result;
        }
        static void PrintArray(int[] array) 
        {
            Console.Write("filtered array: ");
            foreach (var item in array) { Console.Write(item + " "); }
            Console.WriteLine();
        }
    }
}
