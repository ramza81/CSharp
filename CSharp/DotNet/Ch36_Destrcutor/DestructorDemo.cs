using System;

namespace DotNet.Ch36_Destructor
{
    class Car
    {
        private string _name;
        public Car() : this("normal") {}
        public Car(string name)
        {
            _name = name;
            System.Console.WriteLine($"1:{_name} goes to");
        }
        public void Go() => System.Console.WriteLine($"2:{_name} run");
        // 소멸자
        ~Car() => System.Console.WriteLine($"3:{_name} destroy");
    }
    public class DestructorDemo
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Go();

            Car car2 = new Car("Super");
            car2.Go();
        }
    }
}