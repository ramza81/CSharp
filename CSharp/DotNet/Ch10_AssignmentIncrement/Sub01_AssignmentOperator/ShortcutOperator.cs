using System;

namespace DotNet.Ch10_AssignmentIncrement.Sub01_AssignmentOperator
{
    class ShortcutOperator
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;

            x = x +2;   // 기본형
            y += 2;     // 축약형

            System.Console.WriteLine($"x: {x}, y: {y}");

        }

    }

}
