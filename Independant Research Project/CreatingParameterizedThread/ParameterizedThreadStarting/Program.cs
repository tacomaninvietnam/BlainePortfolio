/*Blaine Simcox 
 * Example of Starting Threads With Parameters
 * CIT 275
 * Jeff Straw
 * Example using code supplied via Youtube video by Jesse Diedrichson 40-783 1.1 - 1.2 tutorials
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParameterizedThreadStarting
{
    class Program
    {
        public static void ThreadMethod(object o)   //Method for ParameterizedThreadStart delegate.  Requires type of object
        {
            for ( int i = 0; i < (int)o; i++)       //Cast object o int an int for comparison
            {
                Console.WriteLine("ThreadPrc: {0}", i);  //Output i ever 1/2 second
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This is an example of a Parameterized Thread Call.\nThis Thread has been initialized t cycle 15 \ntimes at 1/2 second intervals before stopping.");
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));   //Create new parameterized Thread
            t.Start(15);                               //start thread with parameter of 15 cycles for ThreadMethod
            t.Join();                          //join stops application from terminating before thread is complete
            Console.WriteLine("Press Enter to Continue!");
            Console.ReadKey();                 //stop so user can read output       
        }
    }
}
