// 부모 클래스에 정의된 기능을 다시 사용, 확장 및 수정하여 자식 클래스로 만들기
using System;

namespace DotNet.Ch43_Inheritance
{
    public enum CarType { 전기, 내연기관 }

    public abstract class CarBase
    {
        protected string LeftMsg { get; private set; } = "Go Left";  // 자식에게만 멤버 노출
        public abstract void Left();    // 추상 클래스의 추상 메서드, 본문 X, 시그니처 O => 표준(강제) => 인터페이스
        public void Back() => System.Console.WriteLine("Back");
    }

    public class Car : CarBase
    {
        public CarType Style { get; private set; }
        public Car(CarType carType)
        {
            this.Style = carType;
        }
        public override void Left() => System.Console.WriteLine(LeftMsg); // 실제 코드 구현, 재정의
        public void Go() => System.Console.WriteLine("Run");
    }

    public class Benz : Car // Sub : Base
    {

        // public Benz()
        // {
        //     this.Style = CarType.내연기관;
        // }

        public Benz() : this(CarType.내연기관) { }

        // public Benz(CarType carType)
        // {
        //     this.Style = carType;
        // }

        public Benz(CarType carType) : base(carType) { }
    }

    public class Tesla : Car    // Child : Parent
    {
        // public Tesla()
        // {
        //     this.Style = CarType.전기;
        // }

        // public Tesla(CarType carType)
        // {
        //     this.Style = carType;
        // }

        public Tesla() : this(CarType.전기) {}
        public Tesla(CarType carType) : base(carType) {}

    }

    // 봉인(최종) 클래스
    public sealed class Future : Car
    {
        public Future() : this(CarType.전기) {}
        public Future(CarType carType) : base(carType) {}
        // public void Go()
        // {
        //     base.Go();
        //     System.Console.WriteLine("Fly");
        // }
        public new void Go()
        {
            base.Go();
            System.Console.WriteLine("Fly");
        }        
    }

    // public class OtherFuture : Future
    // {
        
    // }

    public class InheritanceDemo : Object
    {
        static void Main(string[] args)
        {
            // (new Benz()).Go();
            // (new Tesla()).Go();

            // Benz benz = new Benz(CarType.전기);
            // benz.Go();
            // benz.Back();
            // benz.Left();
            // System.Console.WriteLine(benz.Style);

            // Tesla tesla = new Tesla();
            // tesla.Go();
            // tesla.Back();
            // tesla.Left();
            // System.Console.WriteLine(tesla.Style);

            Future future = new Future();
            future.Go();           
           
        }
    }
}