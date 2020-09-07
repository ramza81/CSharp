// 속성 : 필드의 값을 읽거나 쓰거나 계산하는 방법을 제공하는 클래스의 속성을 나타내는 멤버
using System;

namespace DotNet.Ch38_Property
{
    public class PropertyDemo
    {
        class Car
        {
            //1. public string name;
            //2. private string name;
            // public string GetName()
            // {
            //     return name;
            // }
            // public void SetName(string name)
            // {
            //     this.name = name;
            // }

            //3. private string name;
            // public string Name
            // {
            //     get
            //     {
            //         return name;
            //     }
            //     set
            //     {
            //         name = value;
            //     }
            // }
             public string Name { get; set; } = "My Car";
            // public string Name { get; private set; } = "My Car";
        }
        static void Main(string[] args)
        {
            // Car car = new Car();
            // //1. car.name = "My Car";
            // //System.Console.WriteLine(car.name);
            // //2. car.SetName("My Car");
            // // System.Console.WriteLine(car.GetName());
            // //3. car.Name = "My Car";
            // // System.Console.WriteLine(car.Name);

            // // Car car = new Car() { Name = "My Car" }; // Object Initializer
            // System.Console.WriteLine((new Car().Name));
           
            // // car.Name = "Your Car";
            // System.Console.WriteLine($"{nameof(car.Name)} : {car.Name}");

            // var person = new { Name = "Red", Age = 21 };
            // System.Console.WriteLine(person.Name);

            Car car = new Car { Name = null };
            System.Console.WriteLine(car.Name);
            System.Console.WriteLine(car?.Name);
            System.Console.WriteLine(car?.Name ?? "Unknown");

        }
    }
}