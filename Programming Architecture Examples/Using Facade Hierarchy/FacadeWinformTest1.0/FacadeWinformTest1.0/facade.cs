/*Blaine Simcox 
 * 3/21/2014 - 3/22/2014
 * Facade Test Application Using AdventureWorksLT
 * Jeff Straw
 * CIT 275
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadeWinformTest1._0
{
    class Facade
    {
        /// <summary>
        /// Global instance of DBClass
        /// </summary>
        DBClass h = new DBClass();

        /// <summary>
        /// Variable for holding record count
        /// </summary>
        public int iteratorCount = 0;
        
        /// <summary>
        /// Creates List to populate Form1 rtbMain to fullfill Facade hierarchy
        /// </summary>
        /// <returns>List of All states in DataBase</returns>
        public List<string> transferStateCombo()
        {
            List<string> results = new List<string>();

            foreach (string s in h.StatesList())
            {
                results.Add(s);
            }
           
            return results;
            
        }

        /// <summary>
        /// Creates list to populate Form1 From DBClass to fulfill Facade role
        /// </summary>
        /// <param name="s">state or province parameter fed by cboStates</param>
        /// <returns>Returns filtered list of Customers by possible regions</returns>
        public List<Customers> customerListTransfer(string s)
        {
                iteratorCount = 0;
                List<Customers> results = new List<Customers>();

                foreach (var c in h.CustomerList(s))
                {
                    results.Add(c);
                    iteratorCount++;
                }
                
                return results;
        }

        /// <summary>
        /// Creates list to populate Form1 From DBClass to fulfill Facade role
        /// </summary>
        /// <returns>Returns list of all Customers</returns>
        public List<Customers> customerListTransfer()
        {
            iteratorCount = 0;
            List<Customers> results = new List<Customers>();

            foreach (var c in h.CustomerList())
            {
                results.Add(c);
                iteratorCount++;
            }
            return results;
        }

        /// <summary>
        /// Create list to populate Form1 From DBClass to fulfill Facade role
        /// </summary>
        /// <returns>Returns list of Orders with totals</returns>
        public List<Order> orderListTransfer()
        {
            iteratorCount = 0;
            List<Order> results = new List<Order>();

            foreach (var c in h.OrderList())
            {
                results.Add(c);
                iteratorCount++;
            }
            return results;
        }
    }
}
