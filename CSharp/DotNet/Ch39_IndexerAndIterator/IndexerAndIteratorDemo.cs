// 인덱서 : 클래스의 인스턴스를 배열처럼 사용할 수 잇도록 해주는 구문
// 반복기 : 컬렉션의 항목을 단계별로 실행하는 데 사용되는 구문
using System;
using System.Collections;

namespace DotNet.Ch39_IndexerAndIterator
{
    class Car
    {
        // 필드
        private string[] names;
        // 생성자
        public Car(int Length)
        {
            names = new string[Length];
        }
        // 인덱서 Indexer
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        // 반복기 Iterator
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
    public class IndexerAndIteratorDemo
    {
        static void Main(string[] args)
        {
            Car cars = new Car(3);
            cars[0] = "CLA";
            cars[1] = "CLS";
            cars[2] = "AMG";

            foreach (var car in cars)
            {
                System.Console.WriteLine(car);
            }
        }
    }
}