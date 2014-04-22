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
using System.Threading.Tasks;

namespace SharedDataMultithreads
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;  //integers to feed threads
            int n2 = 0;

            object lockA = new object(); //objects for creating locks
            object lockB = new object();

            Console.WriteLine("First We Will Demonstrate Unmanaged Multithreading On The Same Variable.\nOne Thread Increments The Value Of 'n' While The Other Thread\nDecrements The Value Of Variable 'n'\nThis Should Result In Zero, But it Does Not Due To Each Thread \nAccessing 'n' At Roughly The Same Time.");
            Console.ReadLine(); // Stops program so user can read message

            Task myTask = Task.Run(() =>         //Create and Run unmanaged task with lambda function definition of task
            {

                for (int i = 0; i < 1000000; i++)
                {
                        n2++; //non atomic operator equivilant(n=n+1), not thread safe without lock
                }

            });
            for (int i = 0; i < 1000000; i++)
            {
                    n2--;//non atomic operator equivilant(n=n-1), not thread safe without lock
                
            };

            Console.WriteLine("That Was the Result Of Unmanaged Multithreading.  The Threads Interrupt Each \nOther Causing Eroneous Data:");
            Console.WriteLine("\n" + n2);
            Console.ReadLine();
            Console.WriteLine("This Is The Result Of Managed Multithreading.  Using Locks, The Second Thread \nDoes Not Execute Until the First is Done Granting The Full Cancellation To Zero.");

            Task myTask2 = Task.Run(() =>         //Create and Run task with lambda function definition of task
                {
                    
                        for (int i = 0; i < 1000000; i++)
                        {
                            lock (lockA)
                            {
                                n++; //non atomic operator equivilant(n=n+1), not thread safe without lock
                            }
                        }
                    
                });
            for (int i = 0; i < 1000000; i++)
            {
                lock (lockA)
                {
                    n--;//non atomic operator equivilant(n=n-1), not thread safe without lock
                }
            };
            myTask2.Wait();
            Console.WriteLine(n);
            Console.ReadLine();//break so user can read messages

        }
    }
}
