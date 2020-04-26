using System;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;

namespace Threading_Counters
{
    public class Counter : ICounter
    {
        //Adding the race-condition
        public int TotalCount { get; set; }

        public void Count()
        {
            var countTime = new Random().Next(100);

            try
            {
                Thread.Sleep(countTime);
            }
            catch (Exception e)
            {
                Thread.CurrentThread.Interrupt();
                Console.WriteLine($"Thread got interrupted: {e}");
            }

            for (var number = 0; number < 100; number++)
            {
                Console.WriteLine($"{DateTime.Now} : number {number} is counted by {Thread.CurrentThread.Name}");
                TotalCount++;
            }

            lock (this)
            {
                Console.WriteLine($"Total count for all threads : {TotalCount}");
            }
        }
    }
}