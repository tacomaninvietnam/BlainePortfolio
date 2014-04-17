/*Blaine Simcox 
 * CIT 275
 * Jeff Straw
 * Multithreading Using Interloked class
 * Code Examples from 40-783 1.2 Multithreading tutorial
 * By Jesse Diedrichtson on youtube.com
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingInterlockedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Following Result is from using non-atomic non-Interlocked\nIncrementors and Decrementors.\nAs you Can See, The Result of Even Increments and Decrements\nCome back Erroneously Due to How Individual CPUs Execute Multiple \nParallel Threads.  Because of these Variances From CPU to CPU, We Must Use\nAtomic Versions in Order to Synchronize the Same Object Over Multiple\nThreads.  This Is the Result of Non-Atomic Increment And Decremnt at The Same \nIntervals On Multiple Threads:");
            int n = 0;
            Task myTask = Task.Run(() =>   //lambda expression for defining task delegation of Second Thread
            {
                for (int i = 0; i < 1000000; i++)
                {
                    n++; //using non-interlocked non-atomic Increment to syncronize with main thread decrement

                }
            });
            for (int i = 0; i < 1000000; i++) //Main Thread
            {
                n--;  //using non-interlocked non-atomic Decrement to syncronize with main thread increment
            }
            myTask.Wait();                    //Waits for threads to complete execution
            Console.WriteLine("Result: " + n + "\nPress Enter To Continue....."); //Print results
            Console.ReadLine();
           
            
            n = 0;     //Reset n to Zero
            Console.WriteLine("The Following Result is from using atomic Interlocked class \nIncrementors and Decrementors:");
            

            myTask = Task.Run(() =>   //redefine my task using inerlocked class increment and decrement the 
                {                     //that return correct results
                    for ( int i = 0; i < 1000000; i ++)
                    {
                        Interlocked.Increment(ref n);  //using interlocked atomic Increment to syncronize with main thread decrement

                    }
                });
            for (int i = 0; i < 1000000; i++) //Main Thread 
            {
                Interlocked.Decrement(ref n);  //using interlocked atomic Decrement to syncronize with main thread increment
            }
            myTask.Wait();                    //Waits for threads to complete execution
            Console.WriteLine("Result: " + n); //Print results
            
        }
    }
}
