using System;

namespace DotNet.Ch06_NumberDataType.Sub01_IntegerDemo
{
    class IntegerDemo
    {
        static void Main(string[] args)
        {
            int min = Int32.MinValue;
            int max = Int32.MaxValue;

            System.Console.WriteLine("int 변수의 최소값: {0}", min);
            System.Console.WriteLine("int 변수의 최대값: {0}", max);
        }
    }
}