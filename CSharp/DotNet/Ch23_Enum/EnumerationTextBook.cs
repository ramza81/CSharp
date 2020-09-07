using System;

namespace DotNet.Ch23_Enum
{
    class EnumerationTextBook
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("red");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"{nameof(ConsoleColor.Green)} & {nameof(ConsoleColor.Yellow)}");
            Console.ResetColor();

        }
    }
}