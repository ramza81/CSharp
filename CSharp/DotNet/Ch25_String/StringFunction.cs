using System;

namespace DotNet.Ch25_String
{
    class StringFunction
    {
        static void Main(string[] args)
        {
            // // 문자열 관련 주요 함수
            // string message = "Hello World";
            // System.Console.WriteLine(message.ToUpper());
            // System.Console.WriteLine(message.ToLower());
            // System.Console.WriteLine(message.Replace("Hello", "안녕하세요").Replace("World", "세상아"));

            // // System.String 클래스 == string 키워드
            // String s1 = "Hello";
            // string s2 = "Welcome";
            // System.Console.WriteLine($"{s1}, {s2}");

            // // 문자열 연결: 더하기 연산자, String.Concat()  메서드
            // string s1 = "안녕" + "하세요.";
            // string s2 = string.Concat("반갑", "습니다.");
            // System.Console.WriteLine($"{s1} {s2}");

            // // 문자열의 길이: String.Length 속성
            // string s1 = "Hello";
            // string s2 = "안녕하세요";
            // System.Console.WriteLine($"{s1.Length}, {s2.Length}");

            // // ToCharArry 메서드로 문자열을 문바 배열로 변환하기
            // string s = "안녕하세요";
            // char[] ch = s.ToCharArray();
            // foreach(char c in ch)
            // {
            //     System.Console.WriteLine(c);
            // }

            // // 문자열 묶는 3가지 표현 방법 정리
            // var displayName = "";
            // var firstName = "상민";
            // var lastName = "이";

            // // 더하기(+) 연산자
            // displayName = "이름 : " + lastName + firstName;
            // System.Console.WriteLine(displayName);

            // // string.Foramt() 메서드
            // displayName = string.Format("이름 : {0}{1}", lastName, firstName);
            // System.Console.WriteLine(displayName);

            // // 문자열 보간법
            // displayName = $"이름 : {lastName}{firstName}";
            // System.Console.WriteLine(displayName);

            // // 문자열 비교하는 2가지 방법
            // string userName = "bandiera";
            // string usreNameInput = "Bandiera";

            // // == 연산자
            // if (userName.ToLower() == usreNameInput.ToLower())
            // {
            //     System.Console.WriteLine("같습니다1");
            // }

            // // string.Equals() 메서드 사용 > 권장
            // if (string.Equals(userName, usreNameInput, StringComparison.CurrentCultureIgnoreCase))
            // {
            //     System.Console.WriteLine("같습니다2");
            // }

            // 문자열 값 비교 : 대소문자 비교
            string s1 = "Bandiera";
            string s2 = "bandiera";

            // 문자열의 값의 대소문자를 구분
            if (s1 == s2)
            {
                System.Console.WriteLine("같다1");
            }
            else
            {
                System.Console.WriteLine("다르다1");
            }

            // 문자열의 대소문자를 구분하지 않고 비교
            if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
            {
                System.Console.WriteLine("같다2");
            }
            else
            {
                System.Console.WriteLine("다르다2");
            }
        }
    }
}