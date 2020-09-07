namespace DulAlgorithm
{
    public class Algorithm
    {
        /// <summary>
        /// 선택 정렬 알고리즘
        /// </summary>
        /// <param name="numbers">정수형 배열</param>
        /// <returns>오름차순 정렬된 정수형 배열</returns>
        public static int[] SelectionSort(int[] numbers)
        {
            int N = numbers.Length;

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }   

            return numbers;
        }
    }
}