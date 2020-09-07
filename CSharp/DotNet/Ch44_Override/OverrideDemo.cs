using System;

namespace DotNet.Ch44_Override
{
    class Parent
    {
        protected void Say() => System.Console.WriteLine("Parent Hello");
        protected void Run() => System.Console.WriteLine("Parent Run");
        public  virtual void Walk() => System.Console.WriteLine("Parent Walk");
        public virtual void Work() => System.Console.WriteLine("Parent Work");
    }

    class Child : Parent
    {
        // public void Say() => System.Console.WriteLine("Child Hello");
        public new void Run() => System.Console.WriteLine("Child Run");
        public override void Walk() => base.Walk();
        public override void Work() => System.Console.WriteLine("Child Work");
    }

    public class OverrideDemo
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            // child.Say();
            child.Run();
            child.Walk();
            child.Work();
            
        }
    }
}