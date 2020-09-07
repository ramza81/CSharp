using System;

namespace DotNet.Ch10_AssignmentIncrement.Sub01_AssignmentOperator
{
    // 할당(대입) 연산자 : 변수에 특정 값으로 초기화하면 자동 유추에 의해서 현식이 결정됨
    class AssignmentOperator
    {
        static void Main(string[] args)
        {
            var name = "CSharp";
            var version = 8;

            System.Console.WriteLine($"{name} {version}");
        }

    }

}
