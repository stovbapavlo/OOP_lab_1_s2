using System;
using System.IO;

namespace v6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("RandomArray10k.txt");
            int[] testArray = Array.ConvertAll(lines, int.Parse);

            long etalonTime, studentTime;

            bool selectionSortResult = SortingChecker.CheckSortingAndTime(Etalon.SelectionSort, StudentSorting.SelectionSort,
                testArray, out etalonTime, out studentTime);

            String selectionSortResultStr = selectionSortResult ? "OK" : "FAILD";
            Console.WriteLine($"Selection Sort Result: {selectionSortResultStr}" +
               $"\nEtalon Time: {etalonTime.ToString("0.###")} ms" +
               $"\nYour Time: {studentTime.ToString("0.###")} ms");


            bool shakerSortResult = SortingChecker.CheckSortingAndTime(Etalon.ShakerSort, StudentSorting.ShakerSort,
                testArray, out etalonTime, out studentTime);

            String shakerSortResultStr = shakerSortResult ? "OK" : "FAILD";
            Console.WriteLine($"\nShaker Sort Result: {shakerSortResultStr}" +
                $"\nEtalon Time: {etalonTime.ToString("0.###")} ms" +
                $"\nYour Time: {studentTime.ToString("0.###")} ms");


            Console.ReadKey();
        }
    }
}
