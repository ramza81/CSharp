// 자리 표시자(개체 틀)
using System;

namespace DotNet.Ch04_Syntax.Sub09_PlaceHolder
{
    class PlaceHolder
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("{0}", "Hello, C#");
            System.Console.WriteLine("{0}, {0}", "Hello, C#");
        }
    }
}