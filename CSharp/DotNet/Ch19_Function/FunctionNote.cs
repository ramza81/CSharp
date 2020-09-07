using System;

// 함수 : 반복하여 사용하도록 하나의 이름으로 만들어 놓은 코드의 집합
namespace DotNet.Ch19_Function
{
    class FunctionNote
    {   
        // 선언
        // static int Sum(int first, int second)
        // {
        //     int sum = first + second;
        //     // System.Console.WriteLine($"합계: {sum}");
        //     return sum;
        // }

        static int Sum(int first, int second) => (first + second);


        // 호출
        // static void Main() => Console.WriteLine(Sum(3, 5));

        static void Main(string[] args)
        {
            int first = Convert.ToInt32(args[0]);
            int second = Convert.ToInt32(args[1]);
            System.Console.WriteLine(Sum(first, second));
        }

        // static void Main() => Sum(3, 5);
    }
}