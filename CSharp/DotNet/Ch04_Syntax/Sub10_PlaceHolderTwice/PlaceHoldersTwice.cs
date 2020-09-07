// 자리 표시자(개체 틀)
using System;

namespace DotNet.Ch04_Syntax.Sub1_PlaceHolderTwice
{
    class PlaceHoldersTwice
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("{0}", "Hello, C#");
            System.Console.WriteLine("{0}, {0}", "Hello, C#");
        }
    }
}