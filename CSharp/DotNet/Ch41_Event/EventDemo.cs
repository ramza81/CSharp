// 특정 상황이 발생할 때 개체 또는 클래스에서 알림을 제공할 수 있도록 하는 멤버
using System;

namespace DotNet.Ch41_Event
{
    // 이벤트 구독자(Event Subscriber)
    public class EventDemo
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.FuelEmptyReached += Car_FuelEmptyReached;
            car.FuelEmptyReached -= Car_FuelEmptyReached;
            car.FuelEmptyReached += () => {
                System.Console.WriteLine("연료부족!!!");
            };
            car.Go();
            car.Go();

            // car.OnFuelEmptyReached();
        }

        // 이벤트 처리기(Handler)
        private static void Car_FuelEmptyReached()
        {
            System.Console.WriteLine("Not Enough Fuel");
        }
    }
}