using System;

namespace DotNet.Ch52_Library
{
    public class LibraryDemo
    {
        static void Main(string[] args)
        {
            int[] numbers = {8, 5, 6, 3, 1, 4, 2, 7, 9 };           

            numbers = DulAlgorithm.Algorithm.SelectionSort(numbers);

            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}