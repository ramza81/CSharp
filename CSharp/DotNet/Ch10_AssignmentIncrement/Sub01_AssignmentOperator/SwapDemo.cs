using System;

namespace DotNet.Ch10_AssignmentIncrement.Sub01_AssignmentOperator
{
    class SwapDemo
    {
        static void Main(string[] args)
        {
            var i = 100;
            var j = 200;

            System.Console.WriteLine($"처음 : {i}, {j}");
            
            // 변수값 서로 바꾸기
            var temp = i;
            i = j;
            j = temp;

            System.Console.WriteLine($"변경 : {i}, {j}");
        }

    }

}
