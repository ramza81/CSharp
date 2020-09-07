using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DotNet.Ch56_AsyncAwait
{
    public class Rice
    {
        
    }

    public class Soup
    {
        
    }

    public class Egg
    {
        
    }

    public class Cooking
    {
        /// <summary>
        /// Sysnc Make Rice
        /// </summary>
        /// <returns>Rice</returns>
        public Rice MakeRice()
        {
            System.Console.WriteLine("Making Race...");
            Thread.Sleep(3001);
            return new Rice();
        }

        /// <summary>
        /// Asynce Make Rice
        /// </summary>
        /// <returns>Rice</returns>
        public async Task<Rice> MakeRiceAsync()
        {
            System.Console.WriteLine("Making Race...");
            await Task.Delay(3001); //[A]
            return new Rice();        
        }

        /// <summary>
        /// Sync Make Soup
        /// </summary>
        /// <returns>Soup</returns>
        public Soup MakeSoup()
        {
            System.Console.WriteLine("Making Soup...");
            Thread.Sleep(3001);
            return new Soup();
        }

        /// <summary>
        /// Async Make Soup
        /// </summary>
        /// <returns>Soup</returns>
        public async Task<Soup> MakeSoupAsync()
        {
            System.Console.WriteLine("Making Soup...");
            await Task.Run(() => Task.Delay(3001)); //[B]
            return new Soup();   
        }

        /// <summary>
        /// Sync Make Egg
        /// </summary>
        /// <returns>Egg</returns>
        public Egg MakeEgg()
        {
            System.Console.WriteLine("Making Egg...");
            Thread.Sleep(3001);
            return new Egg();
        }

        /// <summary>
        /// Async Make Egg
        /// </summary>
        /// <returns>Egg</returns>
        public async Task<Egg> MakeEggAsync()
        {
            System.Console.WriteLine("Making Egg...");
            await Task.Delay(TimeSpan.FromMilliseconds(3001));
            return await Task.FromResult<Egg>(new Egg()); //[C]
        }        
        
    }
    public class AsyncAwaitDemo
    {
        static async Task Main(string[] args)
        {
            // DateTime start = DateTime.Now;

            // Cooking cooking  = new Cooking();

            // // cooking.MakeRice();
            // // cooking.MakeSoup();
            // // cooking.MakeEgg();
            // // System.Console.WriteLine($"Sync Complete: {(DateTime.Now - start).TotalSeconds}");

            // var rice = await cooking.MakeRiceAsync();
            // var soup = await cooking.MakeSoupAsync();
            // var egg = await cooking.MakeEggAsync();
            // System.Console.WriteLine($"Async Complete: {(DateTime.Now - start).TotalSeconds}");

            System.Console.WriteLine($"어떤 방식으로 실행할까요? (0~4 번호 입력\n0. Sync\t1. await\t2. Task<T>\t3. WhenAll\t4. WhenAny");

            var number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1: // Async(include Sync)
                    {
                        DateTime start = DateTime.Now;
                        
                        Egg egg= await (new Cooking()).MakeEggAsync();
                        System.Console.WriteLine($"Complete Egg: {egg.GetHashCode()}");

                        Rice rice = await (new Cooking()).MakeRiceAsync();
                        System.Console.WriteLine($"Complete Rice: {rice.GetHashCode()}");

                        Soup soup = await (new Cooking()).MakeSoupAsync();
                        System.Console.WriteLine($"Complete Soup: {soup.GetHashCode()}");

                        System.Console.WriteLine($"\nAsync Complete: {(DateTime.Now - start).TotalSeconds}");
                    }
                    break;
                case 2: // Async
                    {
                        DateTime start = DateTime.Now;

                        // 3 Async Method Execute At same the time
                        Task<Rice> riceTask = (new Cooking()).MakeRiceAsync();
                        Task<Soup> soupTask = (new Cooking()).MakeSoupAsync();
                        Task<Egg> eggTask = (new Cooking()).MakeEggAsync();                       

                        Rice rice = await riceTask;
                        System.Console.WriteLine($"Complete Rice: {rice.GetHashCode()}");

                        Soup soup = await soupTask;
                        System.Console.WriteLine($"Complete Soup: {soup.GetHashCode()}");

                        Egg egg= await eggTask;
                        System.Console.WriteLine($"Complete Egg: {egg.GetHashCode()}");

                        System.Console.WriteLine($"\nAsync Complete: {(DateTime.Now - start).TotalSeconds}");
                    }
                    break;
                case 3: // Async -WhenAll
                    {
                        DateTime start = DateTime.Now;

                        // 3 Async Method Execute At same the time
                        Task<Rice> raceTask = (new Cooking()).MakeRiceAsync();
                        Task<Soup> soupTask = (new Cooking()).MakeSoupAsync();
                        Task<Egg> eggTask = (new Cooking()).MakeEggAsync();                       

                        await Task.WhenAll(raceTask, soupTask, eggTask);

                        System.Console.WriteLine($"\nAsync Complete: {(DateTime.Now - start).TotalSeconds}");
                    }
                    break;  
                case 4: // Async -WhenAny
                    {
                        DateTime start = DateTime.Now;

                        // 3 Async Method Execute At same the time
                        Task<Rice> riceTask = (new Cooking()).MakeRiceAsync();
                        Task<Soup> soupTask = (new Cooking()).MakeSoupAsync();
                        Task<Egg> eggTask = (new Cooking()).MakeEggAsync();                       

                        var allTasks = new List<Task> { riceTask, soupTask, eggTask };

                        while (allTasks.Any())
                        {
                            Task finished = await Task.WhenAny(allTasks);
                            if (finished == riceTask)
                            {
                                Rice rice = await riceTask;
                                System.Console.WriteLine($"Complete Rice: {rice}");
                            }
                            else if (finished == soupTask)
                            {
                                Soup soup = await soupTask;
                                System.Console.WriteLine($"Complete Rice: {soup}");
                            }
                            else if (finished == eggTask)
                            {
                                Egg egg = await eggTask;
                                System.Console.WriteLine($"Complete Rice: {egg}");
                            }
                            allTasks.Remove(finished);
                        }

                        System.Console.WriteLine($"\nAsync Complete: {(DateTime.Now - start).TotalSeconds}");
                    }
                    break;                                                                       
                default:    // Sync
                    {
                        DateTime start = DateTime.Now;
                        
                        Egg egg= (new Cooking()).MakeEgg();
                        System.Console.WriteLine($"Complete Egg: {egg.GetHashCode()}");

                        Rice rice = (new Cooking()).MakeRice();
                        System.Console.WriteLine($"Complete Rice: {rice.GetHashCode()}");

                        Soup soup = (new Cooking()).MakeSoup();
                        System.Console.WriteLine($"Complete Soup: {soup.GetHashCode()}");

                        System.Console.WriteLine($"\nSync Complete: {(DateTime.Now - start).TotalSeconds}");
                    }
                break;
            }
            
        }
    }
}