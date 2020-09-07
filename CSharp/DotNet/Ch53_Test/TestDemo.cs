using System;

namespace DotNet.Ch53_Test
{
    public class TestDemo
    {
        static void Main(string[] args)
        {
            int[] numbers = {8, 5, 6, 3, 1, 4, 2, 7, 9, 11 };           

            numbers = DulAlgorithm.Algorithm.SelectionSort(numbers);

            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}