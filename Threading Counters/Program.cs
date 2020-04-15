using System;
using System.Threading;

namespace Threading_Counters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            NOTE TO SELF:
            creating threads and initialize them, This didn't work, could not
            start the threads so i need to initialize the name later.
            var counter1 = new Thread(Counter.Count).Name = "counter 1";
            var counter2 = new Thread(Counter.Count).Name = "counter 2";
            var counter3 = new Thread(Counter.Count).Name = "counter 3";
            var counter4 = new Thread(Counter.Count).Name = "counter 4";
            var counter5 = new Thread(Counter.Count).Name = "counter 5";
            */

            //creating threads and initialize them
            var counter1 = new Thread(Counter.Count);
            var counter2 = new Thread(Counter.Count);
            var counter3 = new Thread(Counter.Count);
            var counter4 = new Thread(Counter.Count);
            var counter5 = new Thread(Counter.Count);

            //Giving the counters a name to use in the .count() function
            counter1.Name = "counter 1";
            counter2.Name = "counter 2";
            counter3.Name = "counter 3";
            counter4.Name = "counter 4";
            counter5.Name = "counter 5";

            //Starting counters
            counter1.Start();
            counter2.Start();
            counter3.Start();
            counter4.Start();
            counter5.Start();
        }
    }
}