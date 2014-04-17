/*Blaine Simcox 
 * Example of Speed Difference when multithreading tasks
 * CIT 275
 * Jeff Straw
 * Example using code From 70-483 videos from DredricOne on youtube.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StoppingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
                {
                    while (!stopped)
                    {
                        Console.WriteLine("Running.....");
                        Thread.Sleep(1000);

                    }
                    Console.WriteLine("Thread is About to close.");
                }));
            t.Start();
            Console.WriteLine("Press Any Key to Exit.");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }
    }
}
