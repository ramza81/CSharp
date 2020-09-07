using System;

namespace DotNet.Ch22_Structure
{

    struct Point
    {
        public int x;       // public 공용
        public int y;
        // private int z;      // private 전용
    }

    class StructDemo
    {
     static void Main(string[] args)
     {
         Point point;
         point.x = 100;
         point.y = 200;

         System.Console.WriteLine($"x: {point.x}, y: {point.y}");
    }   
    }
}