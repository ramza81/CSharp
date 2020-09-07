using System;

namespace DotNet.Ch10_AssignmentIncrement.Sub01_AssignmentOperator
{
    class ShortcutOperatorDemo
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            b += a;     // 누적 : b 변수에 a 변수의 값을 누적
            System.Console.WriteLine(b);    // 8

            // 현재 b는 8
            b -= a;     // 가감 : b에서 a를 뺀 후 다시 b에 할당
            System.Console.WriteLine(b);    // 5

        }

    }

}
