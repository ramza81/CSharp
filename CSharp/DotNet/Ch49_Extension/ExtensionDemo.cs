using System;

namespace DotNet.Ch49_Extension
{
    static class StringExtension
    {
        public static string Five(this String msg) => msg.Substring(0, 5);
        public static string Ten(this String msg) => msg.Substring(0, 10);
        public static string AddElipisi(this String msg) => msg + "...";
        public static string AddElipisi(this String msg, string elipsis) => $"{msg}{elipsis}";
    }
    public class ExtensionDemo
    {
        static void Main(string[] args)
        {
            string message = "안녕하세요, 반갑습니다. 또 만나요.";
            System.Console.WriteLine(message.Five());
            System.Console.WriteLine(message.Ten());
            System.Console.WriteLine(message.Ten().Five());
            System.Console.WriteLine(message.Ten().Five().AddElipisi());
            System.Console.WriteLine(message.Ten().Five().AddElipisi("!!!"));
        }
    }
}