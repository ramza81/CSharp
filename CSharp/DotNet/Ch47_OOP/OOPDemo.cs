using System;
using System.Collections;

//[1] 네임스페이스 : 클래스명 충돌 방지
namespace DotNet.Ch47_OOP
{
    //[2] 인터페이스 : 표준, 다중상속
    interface IStandard { void Run(); } // 추상화

    //[3] 클래스 : 설계도
    class Car : IStandard   // 상속
    {
        // 캡슐화
        #region [4] 필드 : Private Member Variables
        private string name;    // 필드 : 부품
        private string[] names; // 배열형 필드
        private readonly int _Length;   // 읽기전용 필드
        #endregion

        #region [5] 생성자 : Constructors
        public Car()
        {
            this.name = "Good Car";     // 필드를 기본값으로 초기화
        }
        public Car(string name)     // 생성자 : 시동, 필드 초기화
        {
            this.name = name;
        }
        public Car(int length)
        {
            this.Name = "Good Car";
            _Length = length;       // 읽기 전용 필드는 생성자에 의해서 초기화 가능
            names = new string[length]; // 넘겨온 값으로 요소생성
        }
        #endregion

        #region [6] 메서드 : Public Methods
        public void Run() => System.Console.WriteLine($"{name} Car Run");
        #endregion

        #region [7] 속성 : Public Properties
        public string Name  // 속성 : private 필드 -> 외부공개
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            } 
        }    
        public int Length { get { return _Length; } }
        #endregion

        #region [8] 소멸자 : 폐차, 만들어진 개체 소멸될 때
        ~Car() => System.Console.WriteLine($"{name} Car Destoied");
        #endregion

        #region [9] Indexer : 카탈로그 화
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region [10] 이터레이터(Iterators) : 반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion
        
        #region [11] 대리자 : Public Delegates 다중 메서드 호출
        public delegate void EventHandler();
        #endregion

        #region [12] 이벤트 : Public Events
        public event EventHandler Click;
        // public event Action Click;
        #endregion

        #region [13] 이벤트 처리기 : Event Handlers
        public void OnClick()
        {
            if (Click != null)
            {
                Click();
            }
        }
        #endregion
    }

    class CarRepair
    {
        // 다형성(융통성) : IStandard를 구현하는 모든 클래스 가능
        public CarRepair(IStandard car) => car.Run();
    }

    class OOPDemo
    {
        static void Main(string[] args)
        {
            // Field Method
            Car campingCar = new Car("Camping");
            campingCar.Run();

            // Property
            Car sportCar = new Car();
            sportCar.Name = "Sports";
            sportCar.Run();

            // Indexer
            Car cars = new Car(2);
            cars[0] = "1st Car";
            cars[1] = "2nd Car";

            for (int i = 0; i <  cars.Length; i++)
            {
                System.Console.WriteLine(cars[i]);
            }

            // Iterator
            foreach (var item in cars)
            {
                System.Console.WriteLine(item);
            }

            // Delegate Event Event Handler
            Car btn = new Car("Ev");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.OnClick();

            // Muli
            new CarRepair(campingCar);
            new CarRepair(sportCar);

        }
    }
}