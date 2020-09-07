// 필드(Field) : 클래스의 부품 역할을 하는 클래스의 내부 상태 값을 저장해 놓는 그릇
using System;

namespace DotNet.Ch34_Field
{
    public class Say
    {
        private string message = "Hello2";  // Field
        public void Hi()
        {
            // System.Console.WriteLine(message);
            System.Console.WriteLine(this.message);
        }
    }

    public class Car
    {
        // public string color = "Red";
        private string color = "Red";
        public string GetColor() => color;
    }

    public class Person
    {
        private string name = "이상민";   // 필드 == 멤버 변수, 전역 변수
        private const int age = 40;
        private readonly string _NickName = "BANDIERA";
        private string[] _websites = { "SeriaMania", "Okky" };

        public void ShowProfile() => System.Console.WriteLine($"{name} {age} {_NickName} - {string.Join(", ", _websites)}");

        public Person()
        {
            _NickName = "Bandiera";
        }
    }
        public class FieldDemo
    {
        // private static string message = "Hello1";    // 필드, 전역 변수
        // public static void Hi() => System.Console.WriteLine(message);

        public static void Main(string[] args)
        {
            // int number = 1_234; // 변수, 지역 변수
            // System.Console.WriteLine(number);
            // System.Console.WriteLine(message);
            // Hi();

            // Say say = new Say();
            // say.Hi();

            // Car car = new Car();
            // // System.Console.WriteLine(car.color);
            // System.Console.WriteLine(car.GetColor());

            Person person = new Person();
            person.ShowProfile();
        }
    }
}