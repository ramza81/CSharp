// 제네릭 클래스 : T에 지정한 형식으로 클래스와 멤버의 성질의 결정
// 클래스<T> 형태로 제네릭 클래스 만들기
using System;
using System.Collections.Generic;

namespace DotNet.Ch48_GenericClass
{
    // 컬렉션 이니셜라이저를 사용하여 개체 여러 개를 초기화
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // class Category
    // {
    //     public int CategoryId { get; set; }
    //     public string CategoryName { get; set; }
    // }

    public class Cup<T>
    {
        public T Content { get; set; }
    }

    // 형식 매개 변수 2개 사용
    public class Pair<T, V>
    {
        public T First { get; set; }
        public V Second { get; set; }
        public Pair(T first, V second)
        {
            First = first;
            Second = second;
        }
    }

    /// 페이징된 아티클과 아티클 개수
    // T 모델 클래스
    // V 개수 형식(int, long)
    public struct ArticleSet<T, V>
    {
        // 아티클 리스트 : 현재 페이지에 해당하는 아티클 리스트
        public IEnumerable<T> Items { get; set; }

        // 아티클 수 : 현재 앱의 지징된 조건에 맞는 레코드 수
        public V TotalCount { get; set; }

        public ArticleSet(IEnumerable<T> items, V totalCount)
        {
            Items = items;
            TotalCount = totalCount;
        }
    }


    class GenericClassDemo
    {
        static void Main(string[] args)
        {
            // List<string> colors = new List<string>() { "Red", "Blue" };
            
            // foreach (var item in colors)
            // {
            //     System.Console.WriteLine(item);
            // }

            // List<Person> people = new List<Person>()
            // {
            //     new Person { Name = "홍길동" },
            //     new Person { Name = "백두산" },
            //     new Person { Name = "임꺽정" }
            // };

            // foreach (var item in people)
            // {
            //     System.Console.WriteLine(item.Name);
            // }

            // var categories = new List<Category>()
            // {
            //     new Category() { CategoryId = 1, CategoryName = "좋은 책" },
            //     new Category() { CategoryId = 2, CategoryName = "좋은 강의" },
            //     new Category() { CategoryId = 3, CategoryName = "좋은 컴퓨터" },
            // };

            // foreach (var item in categories)
            // {
            //     System.Console.WriteLine($"{item.CategoryId} {item.CategoryName}");
            // }

            // var text = new Cup<string>();
            // // text.Content = 1234;
            // text.Content = "bandiera";
            // System.Console.WriteLine(text.Content);

            // var number = new Cup<int>();
            // // number.Content = "aa";
            // number.Content = 1_234;
            // System.Console.WriteLine(number.Content);

            // var person = new Cup<Person>();
            // person.Content = new Person() { Name = "bandiera", Age = 40 };
            // System.Console.WriteLine($"{person.Content.Name} {person.Content.Age}");

            // string, bool 2개 형식 받기
            var my = new Pair<string, bool>("나는 멋져~", true);
            System.Console.WriteLine($"{my.First} {my.Second}");

            // int, double 2개 형식 받기
            var tuple = new Pair<int, double>(1234, 3.14);
            System.Console.WriteLine($"{tuple.First} {tuple.Second}");

        }    
    }
}