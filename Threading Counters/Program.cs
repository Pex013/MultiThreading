using System;
using System.Threading;

namespace Threading_Counters
{
    internal class Program
    {
        private int TotalCountsDone { get; set; }

        private static void Main(string[] args)
        {
            ICounter counter = new Counter();

            //Giving the counters a name to use in the .count() function
            var thread1 = new Thread(counter.Count);
            var thread2 = new Thread(counter.Count);
            var thread3 = new Thread(counter.Count);
            var thread4 = new Thread(counter.Count);
            var thread5 = new Thread(counter.Count);

            thread1.Name = "thread 1";
            thread2.Name = "thread 2";
            thread3.Name = "thread 3";
            thread4.Name = "thread 4";
            thread5.Name = "thread 5";

            //Starting counters
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
        }
    }
}