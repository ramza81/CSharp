using System;

namespace DotNet.Ch37_Method
{
    class MethodDemo
    {
        static void Main(string[] args)
        {
            string title;
            // System.Console.WriteLine($"1: {title}");
            Car car = new Car();
            car.Map(out title);
            System.Console.WriteLine($"3: {title}");
        }
    }
}