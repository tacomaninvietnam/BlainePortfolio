/*Blaine Simcox 
 * Example of Deadlock when multithreading tasks
 * CIT 275
 * Jeff Straw
 * Example using code From 70-483 videos from Jesse Diderictson on youtube.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleDeadlock
{
    class Program
    {
        static void Main(string[] args)
        {
            object lockA = new object(); //objects to lock
            object lockB = new object();

            Console.WriteLine("This is a deadlock!\nlockA is locked by lockB before the code in lockA can\nbe accessed.  This causes both locks to sit at the \nopposing locks without authorization creating a deadlock. \nAs you can see, you can do nothing.\nDepending on your processor you can correct this problem by simply removing \nthe second Thread.Sleep statement.\nRemoval of Second lockB lock allows thread to flow correctly.");
            Task myTask = Task.Run(() => 
                {
                    lock (lockA) //we'll call this lock 1a
                    {
                        Thread.Sleep(1000);
                        lock (lockB) //lock 1b and locks lockB until this thread finishes
                        {
                            Console.WriteLine("Locked A and B!");
                        }
                    }
                });
            lock (lockB)  //this lock creates the deadlock since it fires roughly the same time as lock 1a
                          //but before lock 1b.  1b is locked out 
            {

                Thread.Sleep(1000);
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A!");
                }
            }
        }
    }
}
