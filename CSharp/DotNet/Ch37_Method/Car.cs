using System;

namespace DotNet.Ch37_Method
{
    public class Car
    {
        public void Map(out string title)
        {
            title = "Change Out";
            System.Console.WriteLine($"2: {title}");   
        }
    }
}