/*Blaine Simcox 
 * Example of How to cancel Tasks with cancellation tokens
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

namespace CacellationOfThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This Application is To Demonstrate The Use of Cancellation Tokens\nUsed to Terminate Tasks.\n\nThe Following Output is various Square Roots of 2 Executed on a Task Thread.\nPressing Enter Will Terminate The Task Thread via a Cancellation Token.\n\nPress Enter To Continue.......");
            Console.ReadLine();

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(); //create new cancellation source
            CancellationToken token = cancellationTokenSource.Token;                         //create new cancellation token

            Task myTask = Task.Run(() =>      //call task with token as a means of terminating it 
                {
                    int n = 2;       //Numbers for multiplication and message tracking
                    int tracker = 2;

                    while (!token.IsCancellationRequested)  //continue task while thread cancellation token not requested
                    {
                        if (n < 1073741824)
                        {
                            n *= 2;    //square n then output message with last tracker and current number
                            Console.Write("\nThe Square of 2 to the " + tracker + " power is: " + n);
                            tracker++;    //incrementtracker for next while loop 
                            Thread.Sleep(500);
                        }
                        else
                        {
                            Console.Write("\n\nError:  Language Cannot Support Higher Square of 2!  \n" + n  +" Is The Final Output!");
                            Thread.Sleep(1000);
                        }

                    }
                }, token);

            Console.WriteLine("\nPress enter to stop the Task.");
            Console.ReadLine();                //once Enter is pressed thread stops
            cancellationTokenSource.Cancel();  //using concellationTokenSource.Cancel

            Console.WriteLine("\nYou Have Chosen To Stop the Task by Using the Cancellation token.\nPress enter to end the program.");
            Console.ReadLine();//pause to let user see output
        }
    }
}
