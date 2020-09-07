using System;

namespace DotNet.Ch42_ClassEtc
{
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Person
    {
        public void Print() => System.Console.WriteLine($"{Name} : {Age}");
    }

    public class Circle
    {
        public int Radius { get; private set; }
        public Circle(int radius) => Radius = radius;
        public Circle MakeNew(int radius) => new Circle(radius);
    }

    public class ClassEtcDemo
    {
        static void Main(string[] args)
        {
            var hello = new Hello();
            hello.Hi();
            hello.Bye();

            var person = new Person();
            person.Name = "bandiera";
            person.Age = 40;
            person.Print();

            var circle = new Circle(10);
            System.Console.WriteLine($"Raidus: {circle.Radius} - {circle.GetHashCode()}");

            circle =  circle.MakeNew(20);
            System.Console.WriteLine($"Raidus: {circle.Radius} - {circle.GetHashCode()}");
        }
    }
}