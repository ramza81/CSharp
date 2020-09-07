using System;

namespace DotNet.Ch31_Algorithm
{
    class AlgorithmDemo
    {
        static void Main(string[] args)
        {
            Sort();
        }

        static void Sort()
        {
            int[] data = { 3, 2, 1, 5, 4 };

            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] > data[j])  // 오름차순, 내림차순
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            foreach (var item in data)
            {
                System.Console.WriteLine(item);
            }

        }
        
    }
}