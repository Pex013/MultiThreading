using System;
using System.Threading;

namespace Threading_Counters
{
    public class Counter
    {
        public static void Count()
        {
            for (var number = 0; number < 100; number++)
            {
                Console.WriteLine($"{number} is counted by {Thread.CurrentThread.Name} ");
            }
        }
    }
}