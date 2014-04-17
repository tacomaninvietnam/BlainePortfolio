/*Blaine Simcox 
 * Example of Creating and Running A Thread
 * CIT 275
 * Jeff Straw
 * Example using code From Jesse Dietrichson 70-483 Prep Video Objective 1.1 on youtube.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadApplicationConsole1
{
    class Program
    {
        public static void ThreadMethod()  //method to feed into ThreadStart Delegate
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i); //Write Int i status every one second
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();
            

            t.Join();    //do not terminate program until thread is executed
            //Console.ReadLine();
           
            
        }
    }
}
