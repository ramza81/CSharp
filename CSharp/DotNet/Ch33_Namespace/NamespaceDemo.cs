// 네임스페이스 : 클래스 등의 사용자 정의 형식의 이름 충돌 방지 및 관련 기능끼리 묶어서 관리
using System;

namespace DotNet.Ch33_Namespace
{
    public class NamespaceDemo
    {
        public static void Main(string[] args)
        {
            Foo.Car fooCar = new Foo.Car();
            fooCar.Go();

            Bar.Car barCar = new Bar.Car();
            barCar.Go();
        }
    }
}

namespace Foo
    {
    public class Car
    {
        public void Go() => System.Console.WriteLine("[1] Called Car class of Foo Namespace");
    }
}

namespace Bar
{
    public class Car
    {
        public void Go() => System.Console.WriteLine("[2] Bar Namespace Car Class");
    }
    
}