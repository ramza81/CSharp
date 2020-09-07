// 괄호 기호의 간단한 구문을 사용하여 하나 이상의 속성을 가지는 개체를 만드는 형식
using System;

namespace DotNet.Ch51_Tuple
{
    public class TupleDemo
    {
        static void Main(string[] args)
        {
            // // 튜플 리터럴
            // var r = (12, 34, 56);   // 3개의 int 형식 데이터가 r 변수에 담김
            // System.Console.WriteLine(r.Item1);
            // System.Console.WriteLine(r.Item2);
            // System.Console.WriteLine(r.Item3);

            // var fhd = (1920, 1080); // 기본 : Item1, Item2
            // System.Console.WriteLine(fhd.Item1);
            // System.Console.WriteLine(fhd.Item2);

            //  var uhd = (Width: 3840, Height: 2160); // 이름 지정
            //  System.Console.WriteLine(uhd.Width);
            //  System.Console.WriteLine(uhd.Height);

            //  // 이름과 형식 지정
            //  (ushort Width, ushort Height) hd = (1366, 768);
            //  System.Console.WriteLine($"{hd.Width}, {hd.Height}, {hd.GetType()}");

            // var t1 = Tally1();
            // System.Console.WriteLine($"{t1.Item1}, {t1.Item2}");

            // var t2 = Tally2();
            // System.Console.WriteLine($"{t2.Sum}, {t2.Count}");

            // var boy = (Name: "철수", isStuduent: true, OrderPrice: 1_000);
            // boy.OrderPrice = 2000;
            // System.Console.WriteLine($"{boy.Name}(초등학생: {boy.isStuduent}) - 주문: {boy.OrderPrice:C0}");

            // var t = ZeroZero();
            // System.Console.WriteLine($"{t.Item1}, {t.Item2}");

            var (a, b) = Tally2();
            System.Console.WriteLine($"{a}, {b}");


        }

        // 튜플 리턴(Tuple Return) 형식 : (int, int)
        static (int, int) Tally1()
        {
            var r = (12, 3);    // 튜플 리터럴에 2개의 값 담기
            return r;           // 튜플 리터럴 반환
        }

        // 튜플 리턴에 이름 값 지정 가능
        static (int Sum, int Count) Tally2() => (45, 6);

        // 튜플 리턴에 초기값 지정
        static (int, int) ZeroZero() => default;

    }
}