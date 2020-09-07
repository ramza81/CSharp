// 특성 : 튜닝
using System;
using System.Diagnostics;
using System.Reflection;

namespace DotNet.Ch46_AttrRef
{
    public class LuxuryAttribute : Attribute
    {
        public LuxuryAttribute() => System.Console.WriteLine("Luxury~");
    }

    // [LuxuryAttribute]
    [Luxury]
    class Car
    {
        // [Obsolete("Next Vesion will remove this Method. So use Auto() Method")]
        // public void Manual() => System.Console.WriteLine("Manual Drive");
        public void Auto() => System.Console.WriteLine("Auto Drive");

        [Conditional("DEBUG")]
        public void Test() => System.Console.WriteLine("Test Drive");
    }

    class AttrRefDemo
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Test();
            // car.Manual();
            car.Auto();
            
            // reflection
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);

            var carType = new Car();
            Type myCar = carType.GetType();
            MethodInfo info = myCar.GetMethod("Auto");
            info.Invoke(carType, null);
        }
    }
}