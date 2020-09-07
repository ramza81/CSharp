using System;

// 개체(object : 오브젝트) : 설계도인 클래스로부터 만들어진 하나의 인스턴스(실체 , 구성요소)
namespace DotNet.Ch32_Object
{
    class ObjectDemo
    {
        static void Main(string[] args)
        {
            // ClassCode classCode1  = new ClassCode();
            // System.Console.WriteLine(classCode1.GetHashCode()); 

            // ClassCode classCode2 = new ClassCode();
            // System.Console.WriteLine(classCode2.GetHashCode()); 

            // Car car1 = new Car();
            // Car car2 = new Car();

            // car1.Go();
            // car2.Go();

            // var car3 = new Car();
            // car3.Go();

            // Car car = new Car();
            // System.Console.WriteLine(car.ToString());

            ClassOne.Hi();
            ClassTwo two = new ClassTwo();
            two.Hi();

        }
    }

    public class ClassCode
    {
        
    }

    public class Car
    {
        public void Go() => System.Console.WriteLine("Run...");
        public override string ToString() => "My Car";
    }

    public class ClassOne
    {
        public static void Hi() => System.Console.WriteLine("Hi");
    }

    public class ClassTwo
    {
        public void Hi() => System.Console.WriteLine("Hi");
    }
}