using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPrograms
{
    internal class StopWatch1
    {
        public static void Simulate()
        {
            Console.WriteLine("StopWatch Program");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Start");
            /*Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Counting");
            }
            */
            stopwatch.Stop();
            Console.WriteLine("Stop");
            Console.WriteLine("Time Elapsed: {0}", stopwatch.Elapsed);
            Console.ReadLine();


        }


    }
}
