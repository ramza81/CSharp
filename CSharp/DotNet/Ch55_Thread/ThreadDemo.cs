// 동시에 여러 작업을 수행하여 앱의 응답설을 높이고, 다중 코어에서 처리량 향상
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNet.Ch55_Thread
{
    class Restaurant
    {
        public void MakeFood()
        {
            System.Console.WriteLine($"Make Food");
            DateTime start = DateTime.Now;          

            void EggFry()
            {
                Thread.Sleep(3000);
                System.Console.WriteLine("EggFry 3 seconds");
            }

            // EggFry();
            Thread t1 = new Thread(new ThreadStart(EggFry));

            void Soup()
            {
                Thread.Sleep(5000);
                System.Console.WriteLine("Soup 5 seconds");
            }

            // Soup();
            Thread t2 = new Thread(Soup);

            // void Rice()
            // {
            //     Thread.Sleep(7000);
            //     System.Console.WriteLine("Rice 7 seconds");
            // }

            // Rice();
            Thread t3 = new Thread(() => 
            {
                Thread.Sleep(7000);
                System.Console.WriteLine("Rice 7 seconds");
            });

            // async
            t1.Start();
            t2.Start();
            t3.Start();

            // await
            t1.Join();
            t2.Join();
            t3.Join();

            System.Console.WriteLine($"Complete: {(DateTime.Now - start).TotalSeconds}");

            System.Console.WriteLine("Start Dinner");
            // SinglePro();
            MultiPro();
            System.Console.WriteLine($"End Dinner: {(DateTime.Now - start).TotalSeconds}");
        }

        private void SinglePro()
        {
            for (int i = 0; i < 20_000; i++)
            {
                System.Console.WriteLine("Talking");
            }
        }

        private void MultiPro()
        {
            Parallel.For(0, 20_000, (i) => { System.Console.WriteLine("Talking"); });
        }
    }
    public class ThreadDemo
    {
        static void Main(string[] args)
        {
            (new Restaurant()).MakeFood();
        }
    }
}