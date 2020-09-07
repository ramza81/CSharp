using System;

namespace DotNet.Ch35_Constructor
{
    public class Car
    {
        // private string name;
        private readonly string name;
        public Car() : this("Normal")
        {
            // 기본 생성자, 생성자 메서드
            // System.Console.WriteLine("Craete Car Object. Assemble, Power");
            // this.name = "Normal";
        }

        // public Car(string name)
        // {
        //     this.name = name;
        // }

        public Car(string name) => this.name = name;

        // public void Go() => System.Console.WriteLine("Run");
        public void Go() => System.Console.WriteLine($"{name} Run");
    }


    public class Pet
    {
        // 속성
        public string Name { get; set; }

        // public Pet(string name)
        // {
        //     this.Name = name;
        // }

        // Expression Bodied Constructor
        public Pet(string name) => Name = name;
    }    

    class ConstructorDemo
    {
        static void Main(string[] args)
        {
            // // Car car = new Car();
            // // car.Go();

            // (new Car()).Go();

            // // Car my = new Car("Rush");
            // // my.Go();

            // (new Car("Rush")).Go();

            Pet pet = new Pet("야옹이");
            System.Console.WriteLine(pet.Name);
        }
    }
}