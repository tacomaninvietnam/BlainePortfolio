/*Blaine Simcox 
 * Example of Speed Difference when multithreading tasks
 * CIT 275
 * Jeff Straw
 * Example using code From DredricOne on youtube.com
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;              //implement threading class

namespace ThreadTestingDrawingClass
{
    public partial class Form1 : Form
    {
        public Form1()              //initialize form load
        {
            InitializeComponent();
            rdm = new Random();
        }
        
        Thread red;                //dclare two threads and random object for rectngle placing
        Thread blue;
        Random rdm;

        private void btnOneThread_Click(object sender, EventArgs e)
        {
            red = new Thread(threadSingle);      //declare new thread with threadR Signature signed to delegate
            red.IsBackground = true;         //stops ObjectDisposedException when user exits application
            red.Start();                    //and start thread
            
        }
        public void threadSingle()
        {
            MessageBox.Show("Because this is not a multithreaded application of the CreateGraphics Class, Blue rectangles will only form after the red process is complete.");
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }

            MessageBox.Show("Red Completed it's Cycle.  Click OK For Blue Cycle!");  //intermission message

            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }

            MessageBox.Show("Blue Completed!  Full Single Thread Cycle complete.");  //signifies end of cycle
        }
        public void threadB()   //method for Thread delegate with blue rectangles with random location
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }

            MessageBox.Show("Blue Completed it's Cycle!");  //Prints Message when thread completes cycle
        }

        private void threadR()   //method for Thread delegate with red rectangles rectangles with random location
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }

            MessageBox.Show("Red Completed!");    //Prints Message when thread completes cycle
        }

        private void btnTwoThread_Click(object sender, EventArgs e)
        {
            red = new Thread(threadR);  //declare new thread with appropriate thread Signature signed to delegate
            blue = new Thread(threadB);
            red.IsBackground = true;   //stops ObjectDisposedException when user exits application
            blue.IsBackground = true;  //stops ObjectDisposedException when user exits application
            red.Start();
            blue.Start();
        }

        
    }
}
