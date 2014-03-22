/*Blaine Simcox 
 * 3/21/2014 - 3/22/2014
 * Facade Test Application Using AdventureWorksLT
 * Jeff Straw
 * CIT 275
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

namespace FacadeWinformTest1._0
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// class level instantiation of facade variable
        /// </summary>
        Facade f = new Facade();
        
        /// <summary>
        /// Loads cboState with States by intializing a facade method()
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            foreach (string s in f.transferStateCombo())
            {
                cboState.Items.Add(s);
            }

        }

        /// <summary>
        /// Exits Application
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// cues the facade to trigger OrderList() from DBClass copying the facade's list into the form's rtb box
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            rtbMain.Text = "";
            string input = "";

            foreach (var c in f.orderListTransfer())
            {
                input += c + "\n";
            }
            rtbMain.Text = input;

            lblIteratorCount.Text = f.iteratorCount.ToString();
        }

        /// <summary>
        /// Triggers Facade to retrieve all CustomerList() from DBClass then transfering facade's list into text box
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void btnAllCust_Click(object sender, EventArgs e)
        {
            rtbMain.Text = "";
            string input = "";

            foreach (var c in f.customerListTransfer())
            {
                input += c.ToString() + "\n";
            }
            rtbMain.Text = input;

            lblIteratorCount.Text = f.iteratorCount.ToString();
        }

        /// <summary>
        /// Triggers the facade to use DBClass.CustomerList(string state) and create text data for rtb based on region
        /// </summary>
        /// <param name="sender">User</param>
        /// <param name="e">Click</param>
        private void cboStates_SelectedIndexChanged(object sender, EventArgs e)
        {

            var s = cboState.SelectedItem as string;

            if (s != null)
            {
                rtbMain.Text = "";
                string input = "";
                foreach(Customers c in f.customerListTransfer(s))
                {
                    input += c.ToString() + "\n";
                }
                rtbMain.Text = input;

                lblIteratorCount.Text = f.iteratorCount.ToString();
            }
        }
    }
}
