// 특정 상황이 발생할 때 개체 또는 클래스에서 알림을 제공할 수 있도록 하는 멤버

using System;

namespace DotNet.Ch41_Event
{
    // 이벤트 게시자(Event Publisher)
    public class Car
    {
        private int _fuelGuage;

        public int FuelGuage
        {
            get { return _fuelGuage; }
            set 
            { 
                _fuelGuage = value; 
                OnFuelEmptyReached();
            }
        }
        
        public Car()
        {
            _fuelGuage = 25;
        }
        
        public void Go()
        {
            System.Console.WriteLine("운전");
            FuelGuage -= 5;
        }

        // public delegate void FuelEmptyNotification();
        // public event FuelEmptyNotification FuelEmptyReached;

        public event Action FuelEmptyReached;

        public void OnFuelEmptyReached()
        {
            System.Console.WriteLine($"현재 연료 상태: {_fuelGuage}%");
            if (_fuelGuage < 20)
            {               
                if (FuelEmptyReached != null)
                {
                    // FuelEmptyReached.();
                    FuelEmptyReached?.Invoke();
                }

            }
        }


    }
}