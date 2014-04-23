/*Blaine Simcox 
 * CIT 248
 * Jeff Straw
 * Independent Research Program
 * Multithreading Using Forms and Locks
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndependentResearchProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startThreadExample();
        }
        
        /// <summary>
        /// bool for stopping threads
        /// </summary>
        public bool stopped = false;

        /// <summary>
        /// iterator manipulated by both threads
        /// </summary>
        private int i = 0;

        /// <summary>
        /// thread1 text
        /// </summary>
        private string text1 = "";

        /// <summary>
        /// thread2 text
        /// </summary>
        private string text2 = "";

        /// <summary>
        /// object to create lock
        /// </summary>
        private object _lock = new object();

        /// <summary>
        /// Method to instantiate both test threads
        /// </summary>
        public void startThreadExample()
        {
            {

                int tt1; //trackers for messages
                int tt2;
                Reset(out tt1, out tt2);
                 
                Thread t = new Thread(new ThreadStart(() => //Lambda expression delegate call
                {
                    while (!stopped)
                    {
                        lock (_lock)   //lock i so t will do its thing and pass it on to t2
                        {
                            i++;
                        }
                        tt1++; //increment tracker and output message to string 
                        text1 += String.Format("{0}: Integer i equals {1} on Thread 1!\n", tt1, i);
                        Thread.Sleep(1); //rest so next thread can do some work
                        
                        if (i >= 50)//stop thread if i equal to 50
                        {
                            stopped = true;
                        }
                    }
                }
                ));
                //thread 2 is a clone of t no differences
                Thread t2 = new Thread(new ThreadStart(() =>
                {
                    while (!stopped)
                    {
                        lock (_lock)
                        {
                            i++;
                        }
                        tt2++;
                        text2 += String.Format("{0}: Integer i equals {1} on Thread 2!\n", tt2, i);
                        Thread.Sleep(1);
                        
                        if (i >= 50)
                        {
                            stopped = true;
                        }
                    }
                }
               ));

                t.Start();
                t2.Start();

                t.Join();
                t2.Join();

                rtb1.Text = text1;
                rtb2.Text = text2;
            }
        }

        //this is the startThreadExample() Method without Locks
        private void button1_Click(object sender, EventArgs e)
        {

            int tt1;
            int tt2;
            Reset(out tt1, out tt2);

                Thread t = new Thread(new ThreadStart(() =>
                {
                    while (!stopped)
                    {
                        
                            i++;
                        
                        tt1++;
                        text1 += String.Format("{0}: Integer i equals {1} on Thread 1!\n", tt1, i);
                        Thread.Sleep(1);

                        if (i >= 50)
                        {
                            stopped = true;
                        }
                    }
                }
                ));
                Thread t2 = new Thread(new ThreadStart(() =>
                {
                    while (!stopped)
                    {
                        
                            i++;
                        
                        tt2++;
                        text2 += String.Format("{0}: Integer i equals {1} on Thread 2!\n", tt2, i);
                        Thread.Sleep(1);

                        if (i >= 50)
                        {
                            stopped = true;
                        }
                    }
                }
               ));

                t.Start();
                t2.Start();

                t.Join();
                t2.Join();

                rtb1.Text = text1;
                rtb2.Text = text2;
        }

        //clears everything
        private void Reset(out int tt1, out int tt2)
        {
            tt1 = 0;
            tt2 = 0;
            i = 0;
            text1 = "";
            text2 = "";
            rtb1.Clear();
            rtb2.Clear();
            stopped = false;
        }
    }
}
