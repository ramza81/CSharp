using System;
using System.Linq;

using System.Collections;
using System.Collections.Generic;

// LINQ : C# 언어에 직접 쿼리(Query) 기능을 통합하는 방식을 기반으로 하는 기술 집합 이름
namespace DotNet.Ch30_LINQ
{
    class LinqDemo
    {
        static void Main(string[] args)
        {
            // Sum();
            ListLinq();
        }

        static void Sum()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int cnt = 0;
            int sum = 0;
            int max = 0;
            double avg = 0;

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     sum += i;    // 구문 실수
            //     sum += numbers[i];
            // }

            // System.Console.WriteLine(sum);

            // Linq
            cnt = numbers.Count();
            System.Console.WriteLine(cnt);

            sum = numbers.Sum();
            System.Console.WriteLine(sum);

            max = numbers.Max();
            System.Console.WriteLine(max);

            avg = numbers.Average();
            System.Console.WriteLine(avg);

            var evenNumber = numbers.Where(n => n % 2 == 0 ).ToList();  // 식 람다
            foreach (var item in evenNumber)
            {
                System.Console.WriteLine(item);
            }

            var list = numbers.Select(x => { return x * 10; } );        // 문 람다

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine(numbers.Where(n => n % 2 == 0).Max());
            System.Console.WriteLine(numbers.Where(n => n % 2 == 0 || n % 3 == 0 ).Sum());

        }
    
        static void ListLinq()
        {
            // List<string> techs = new List<string>();
            // techs.Add("C#");
            // techs.Add("ASP.NET");
            // techs.Add("Blazor");

            // foreach (var item in techs)
            // {
            //     System.Console.WriteLine(item);
            // }

            // techs.OrderByDescending(t => t);

            // foreach (var item in techs)
            // {
            //     System.Console.WriteLine(item);
            // }

            var numbers = Enumerable.Range(1, 100);

            // System.Console.WriteLine(numbers.Where(n => n % 2 == 0).Sum());

            // foreach (var item in numbers)
            // {
            //     System.Console.WriteLine(item);
            // }

            // numbers = numbers.OrderByDescending(n => n);

            // foreach (var item in numbers)
            // {
            //     System.Console.WriteLine(item);
            // }

            // numbers = numbers.OrderByDescending(n => n).Where(x => x % 2 == 0).Skip(3).Take(3);

            // foreach (var item in numbers)
            // {
            //     System.Console.WriteLine(item);
            // }

            var q = from n in numbers
                    where n % 2 == 0
                    select n;

            foreach (var item in q)
            {   
                System.Console.WriteLine(item);
            }    

            var qq = numbers.Where(n => n % 2 == 0);

            foreach (var item in qq)
            {   
                System.Console.WriteLine(item);
            }                

        }
    
    }
}