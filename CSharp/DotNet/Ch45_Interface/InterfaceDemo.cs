// 클래스에서 반드시 구현해야 하는 관련 기능에 대한 정의가 포함된 개념
using System;

namespace DotNet.Ch45_Interface
{
    // // ICar 인터페이스 선언
    // interface ICar
    // {
    //     void Go();  // 매개 변수도 없고 반환 값도 없는 Go() 메서드 시그니처 선언
    // }

    // // ICar 인터페이스를 상속하는 Car 클래스 선언
    // class Car : ICar
    // {
    //     public void Go()
    //     {
    //         System.Console.WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 합니다.");
    //     }
    // }

    public interface ICarStandard
    {
        void Left();
    }

    abstract class KS
    {
        public abstract void Back();
        public void Fly() => System.Console.WriteLine("Fly");
    }

    partial class MyCar : KS
    {
        public override void Back() => System.Console.WriteLine("Go Back");
    }

    partial class MyCar : KS
    {
        public void Right() => System.Console.WriteLine("Ro Right");
    }

    sealed class Car : MyCar, ICarStandard
    {
        public void Left() => System.Console.WriteLine("Go Left");

        public void Run() => System.Console.WriteLine("Run");
    }


    public class InterfaceDemo
    {
        static void Main(string[] args)
        {
            // var car = new Car();
            // car.Go();

            Car car = new Car();
            car.Run();
            car.Right();
            car.Back();
            car.Left();
            car.Fly();

        }
    }
}