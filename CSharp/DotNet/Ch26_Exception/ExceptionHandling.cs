using System;

namespace DotNet.Ch26_Exception
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            // int a = 3;
            // int b = 0;

            try
            {
                // 예외 발생
                // a = a / b;
                throw new Exception("내가 만든 에러");
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine($"예외(에러)가 발생됨: {ex.Message}");
            }
            finally
            {
                System.Console.WriteLine("try 구문을 정상 종료 합니다.");
            }

        }
    }
}