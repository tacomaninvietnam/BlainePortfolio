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

namespace FacadeWinformTest1._0
{
    class Order
    {
        /// <summary>
        /// Fields for Order class
        /// </summary>
        public int? _orderID;
        public int? _customerID;
        public string _cusName;
        public string _itemDescription;
        public decimal _lineTotal;

        /// <summary>
        /// Fully-loaded constructor for Order
        /// </summary>
        /// <param name="orderID">sets _orderID</param>
        /// <param name="cusID">sets _customerID</param>
        /// <param name="cusName">sets _customerName</param>
        /// <param name="itemDescription">sets _itemDescrition</param>
        /// <param name="lineTotal">sets _lineTotal</param>
        public Order(int orderID, int cusID, string cusName, string itemDescription, decimal lineTotal )
        {
            this._orderID = orderID;
            this._customerID = cusID;
            this._cusName = cusName;
            this._itemDescription = itemDescription;
            this._lineTotal = lineTotal;
        }
        /// <summary>
        /// ToString Override for Order Class
        /// </summary>
        /// <returns>Formatted String of Order class</returns>
        public override string ToString()
        {
            return string.Format("Order ID:  {0}\nCustomer ID:  {1}\n{2}\n{3}\nTotal:  ${4}\n", 
                this._orderID, this._customerID, this._cusName, this._itemDescription, this._lineTotal);
        }

    }
}
