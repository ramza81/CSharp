// 대리자 : 함수 포인터, 메서드 대신 호출, 대리 운전, 메서드의 매개 변수로 전달 가능
using System;
using System.Linq;

namespace DotNet.Ch40_Delegate
{
    public class DelegateDemo
    {
        static void GoForward() => System.Console.WriteLine("Go streight");
        static void GoLeft() => System.Console.WriteLine("Go Left");
        static void GoRight() => System.Console.WriteLine("Go Right");
        static void GoFast() => System.Console.WriteLine("Go Fast");
        // static void Stop() => System.Console.WriteLine("Stop");
        delegate void CarDriver();  // 대리자 형식 생성
        static void Main(string[] args)
        {
            // GoForward();    // 직접 운전
            // CarDriver goHome = new CarDriver(GoForward);    // 대리 운전
            CarDriver goHome = GoForward;    // 대리 운전

            goHome += GoLeft;
            goHome += GoRight;
            goHome += GoFast;
            goHome -= GoFast;
            // goHome += Stop;
            goHome += delegate() { System.Console.WriteLine("Stop"); }; // 익명 함수, 무명 메서드
            // goHome += delegate { System.Console.WriteLine("Go Back"); }; 
            goHome += () => System.Console.WriteLine("Go Back");    // Lamdba Expression


            // goHome.Invoke();
            goHome();        

            // 내장된 대리자 형식을 통해서 직접 대리자 개체 생성 : Func<T>, Action<T>, Predicate<T>, ...
            Action driver = GoForward;
            driver += GoLeft;
            driver += delegate() { System.Console.WriteLine("Stop"); }; // 익명 함수, 무명 메서드
            driver += () => System.Console.WriteLine("Go Back");
            driver();   // trigger

            Action go = () => System.Console.WriteLine("Drive");
            go();

            RunLamdba(() => System.Console.WriteLine("매배 변수로 람다 식 전달"));

            int[] numbers = { 1, 2, 3 };

            numbers.Where(x => x % 2 == 0);
            
        }

        static void RunLamdba(Action action) => action();
    }
}