/*Blaine Simcox 
 * Example of How to Set a Timeout on a task
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

namespace settingTimeOutOfThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() =>           //start second task thread 
                {
                    Console.WriteLine("At 1/2 second:");  //message for user
                    Thread.Sleep(500);                    //set the sleep timer to 1/2 second
                    Console.WriteLine("Thread Succeeds!");//since WaitAny is looking for longunning value in one second 
                                                          //this part of the thread executes completey

                    Console.WriteLine("At 1 second the Thread Times Out as So:");//with sleep set to 1 second
                    Thread.Sleep(1000);                         //the second thread s slightly slower than the main
                    Console.WriteLine("I Shouldn't Appear");    //Thread therefore this message doesn't execute.

                });

            int index = Task.WaitAny(new Task[] { longRunning }, 1000);  // gives a task of longRunning 1 second to execute or else times it out
            
            if (index == -1)           //If task does time out print this message
            {
                Console.WriteLine("Task Timed Out");
            }
        }
    }
}
