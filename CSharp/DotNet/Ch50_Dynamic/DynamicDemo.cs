// 런타임에 데이터 형식이 결정되는 모든 형식을 담을 수 있는 특수한 유형의 형식
using System;

namespace DotNet.Ch50_Dynamic
{
    public class DynamicDemo
    {
        static void Main(string[] args)
        {
            // string ss = "컴파일 시점";
            // var vs = "컴파일 시점";
            // dynamic ds = "런타임 시점";

            dynamic x;
            x = 1_234;
            System.Console.WriteLine($"{x} - {x.GetType()}");

            x = "Dynamic Type";
            System.Console.WriteLine($"{x} - {x.GetType()}");

        }
    }
}