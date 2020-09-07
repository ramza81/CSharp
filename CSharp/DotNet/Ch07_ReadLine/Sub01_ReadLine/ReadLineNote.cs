using System;

namespace DotNet.Ch07_ReadLine.Sub01_ReadLine
{
    class ReadLineDemo
    {
        static void Main(string[] args)
        {
            // ReadLine
            // System.Console.Write("이름 : ______\b\b\b\b\b\b");
            // string name = Console.ReadLine();
            // System.Console.WriteLine($"{name}님 안녕하세요");

            // int x = Console.Read();
            // System.Console.WriteLine(x);                    // 아스키코드(ASCII)
            // System.Console.WriteLine(Convert.ToChar(x));    // 실제 문자

            // Convert
            // System.Console.Write("정수: ");
            // string num = Console.ReadLine();
            // int number = Convert.ToInt32(num);
            // System.Console.WriteLine(number);

            // decimal , binary
            // int number = 10;
            // string binary = Convert.ToString(number, 2).PadLeft(8, '0');    // 이진수로 변환
            // System.Console.WriteLine(binary);

            // number = Convert.ToInt32("00001010", 2);
            // System.Console.WriteLine(number);

            // int b1 = 0b0010;                // 이진수 표현 0b
            // System.Console.WriteLine(b1);

            // int b2 = 0B1010;
            // System.Console.WriteLine(b2);

            // int b3 = 0b0000_1010;           // 이진수는 4자리 마다 _ 표기 가능 0b0000____1010 > 갯수 무관
            // System.Console.WriteLine(b3);

            // var
            // string name = "Bandiera";
            // var name1 = "Bandiera";

            // System.Console.WriteLine(name);
            // System.Console.WriteLine(name1);

            // System.Console.WriteLine(name1.GetType());

            // dynamic name2 = 1.0;
            // System.Console.WriteLine(name2.GetType());

            // name2 = "aa";
            // System.Console.WriteLine(name2.GetType());

            // default value
            int i = default;
            System.Console.WriteLine(i);

            double d = default;
            System.Console.WriteLine(d);

            char c = default;
            System.Console.WriteLine(c);

            string s = default;
            System.Console.WriteLine(s);

        }
    }
}