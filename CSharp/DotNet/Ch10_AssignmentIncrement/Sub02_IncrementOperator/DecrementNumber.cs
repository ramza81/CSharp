using System;

namespace DotNet.Ch10_AssignmentIncrement.Sub02_IncrementOperator
{
    // 정수형 변수의 값을 1씩 감소
    class DecrementNumber
    {
        static void Main(string[] args)
        {
            int num = 10;
            num = num - 1;  // 1 감소
            System.Console.WriteLine(num);  // 9

        }

    }

}
