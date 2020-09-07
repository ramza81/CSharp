using System;
using System.Collections.Generic; 

// 제네릭 : Cup<T>를 Cup of T로 발음하여 형식 매개 변수인 T에 따른 Cup 클래스의 개체 생성
namespace DotNet.Ch28_Generic
{
    class Generic
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(200);

            foreach (var i in numbers)
            {
                System.Console.WriteLine(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }
        }
    }
}