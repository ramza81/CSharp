using System;

namespace DotNet.Ch10_AssignmentIncrement.Sub02_IncrementOperator
{
    // 정수형 변수의 값을 1씩 증가
    class IncrementNumber
    {
        static void Main(string[] args)
        {
            int num = 10;
            num = num + 1;  // 1 증가
            System.Console.WriteLine(num);  // 11


        }

    }

}
