/*Blaine Simcox 
 * 3/21/2014 - 3/22/2014
 * Facade Test Application Using AdventureWorksLT
 * Jeff Straw
 * CIT 275
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeWinformTest1._0.Properties;


namespace FacadeWinformTest1._0
{
    class DBClass
    {
        /// <summary>
        /// polymorphic db Connection variable
        /// </summary>
        private DbConnection advConnect = null;

        /// <summary>
        /// polymorphic db command variable
        /// </summary>
        private DbCommand advCommand = null;

        /// <summary>
        /// polymorphic db reader variable
        /// </summary>
        private DbDataReader advReader = null;

        /// <summary>
        /// Searches AdventureWorksLT for Select statement parameters and returns list
        /// </summary>
        /// <returns>All CustomersList in DB with SQL query parameters</returns>
        
        

        public List<Customers> CustomerList()
        {
            var results = new List<Customers>();
            advConnect = new SqlConnection(Settings.Default.AdventureworksConnection);
            advCommand = advConnect.CreateCommand();
            advCommand.CommandType = CommandType.Text;
            advCommand.CommandText = @"SELECT * FROM SalesLT.Customer JOIN SalesLT.CustomerAddress ON SalesLT.Customer.CustomerID = SalesLT.CustomerAddress.CustomerID JOIN SalesLT.Address ON SalesLT.CustomerAddress.AddressID = SalesLT.Address.AddressID ORDER BY SalesLT.Customer.FirstName, SalesLT.Customer.LastName;";

            using (advConnect)
            {
                advConnect.Open();
                advReader = advCommand.ExecuteReader();

                while (advReader.Read())
                {
                    int customerID = (int)advReader["CustomerID"];
                    bool nameStyle = Convert.ToBoolean(advReader["NameStyle"]);
                    string title = advReader["Title"].ToString();
                    string firstName = advReader["FirstName"].ToString();
                    string middleName = advReader["MiddleName"].ToString();
                    string lastName = advReader["LastName"].ToString();
                    string suffix = advReader["Suffix"].ToString();
                    string companyName = advReader["CompanyName"].ToString();
                    string salesPerson = advReader["SalesPerson"].ToString();
                    string emailAddress = advReader["EmailAddress"].ToString();
                    string phone = advReader["Phone"].ToString();
                    string passHash = advReader["PasswordHash"].ToString();
                    string passSalt = advReader["PasswordSalt"].ToString();
                    Guid rowgui = (Guid)advReader["rowguid"];
                    DateTime time = (DateTime)advReader["ModifiedDate"];
                    string address = advReader["AddressLine1"].ToString();
                    string city = advReader["City"].ToString();
                    string stateP = advReader["StateProvince"].ToString();
                    string postal = advReader["PostalCode"].ToString();

                    Customers c = new Customers(customerID, nameStyle, title, firstName, middleName, lastName,
                                                suffix, address, city, stateP, postal, companyName, salesPerson, emailAddress, phone, passHash,
                                                passSalt, rowgui, time);
                    results.Add(c);
                }

                advReader.Close();
                advConnect.Close();
            }
            return results;
        }

        /// <summary>
        /// Searches AdventureWorksLT for Select statement parameters and returns list based on combo box selection
        /// </summary>
        /// <param name="state">string fed in by cboStates</param>
        /// <returns>CustomersList from selected region</returns>
        public  List<Customers> CustomerList(string state)
        {
            var results = new List<Customers>();
            advConnect = new SqlConnection(Settings.Default.AdventureworksConnection);
            advCommand = advConnect.CreateCommand();
            advCommand.CommandType = CommandType.Text;
            advCommand.CommandText = string.Format( "SELECT * FROM SalesLT.Customer JOIN SalesLT.CustomerAddress ON SalesLT.Customer.CustomerID = SalesLT.CustomerAddress.CustomerID JOIN SalesLT.Address ON SalesLT.CustomerAddress.AddressID = SalesLT.Address.AddressID WHERE SalesLT.Address.StateProvince = '{0}' ORDER BY SalesLT.Customer.FirstName, SalesLT.Customer.LastName;", state);

            using (advConnect)
            {
                advConnect.Open();
                advReader = advCommand.ExecuteReader();

                while (advReader.Read())
                {
                    int customerID = (int)advReader["CustomerID"];
                    bool nameStyle = Convert.ToBoolean(advReader["NameStyle"]);
                    string title = advReader["Title"].ToString();
                    string firstName = advReader["FirstName"].ToString();
                    string middleName = advReader["MiddleName"].ToString();
                    string lastName = advReader["LastName"].ToString();
                    string suffix = advReader["Suffix"].ToString();
                    string companyName = advReader["CompanyName"].ToString();
                    string salesPerson = advReader["SalesPerson"].ToString();
                    string emailAddress = advReader["EmailAddress"].ToString();
                    string phone = advReader["Phone"].ToString();
                    string passHash = advReader["PasswordHash"].ToString();
                    string passSalt = advReader["PasswordSalt"].ToString();
                    Guid rowgui = (Guid)advReader["rowguid"];
                    DateTime time = (DateTime)advReader["ModifiedDate"];
                    string address = advReader["AddressLine1"].ToString();
                    string city = advReader["City"].ToString();
                    string stateP = advReader["StateProvince"].ToString();
                    string postal = advReader["PostalCode"].ToString();

                    Customers c = new Customers(customerID, nameStyle, title, firstName, middleName, lastName,
                                                suffix, address, city, stateP, postal, companyName, salesPerson, emailAddress, phone, passHash,
                                                passSalt, rowgui, time);
                    results.Add(c);
                }
                
                advReader.Close();
                advConnect.Close();
            }
            return results;
        }

        /// <summary>
        /// Searches AdventureWorksLT for Select statement parameters and returns list of Invoices with customer name and total
        /// </summary>
        /// <returns>Orders list</returns>
        public List<Order> OrderList()
        {
            var results = new List<Order>();
            advConnect = new SqlConnection(Settings.Default.AdventureworksConnection);
            advCommand = advConnect.CreateCommand();
            advCommand.CommandType = CommandType.Text;
            advCommand.CommandText = @"SELECT SO.SalesOrderID, SH.CustomerID, Title + ' ' +  FirstName + ' ' + MiddleName + ' ' + LastName AS Name, SP.Name AS ItemDescription, SO.LineTotal FROM SalesLT.Customer AS SC JOIN SalesLT.SalesOrderHeader AS SH ON SC.CustomerID = SH.CustomerID JOIN SalesLT.SalesOrderDetail AS SO ON SO.SalesOrderID = SH.SalesOrderID JOIN SalesLT.Product AS SP ON SO.ProductID = SP.ProductID ORDER BY FirstName;";

            using (advConnect)
            {
                advConnect.Open();
                advReader = advCommand.ExecuteReader();

                while (advReader.Read())
                {
                    int salesOrderID = (int)advReader["SalesOrderID"];
                    int customerID = (int)advReader["CustomerID"];
                    string cusName = advReader["Name"].ToString();
                    if (cusName == "")
                        cusName = "No Name Defined";
                    string itemDescription = advReader["ItemDescription"].ToString();
                    decimal lineTotal = Math.Round((decimal)advReader["LineTotal"], 2); ;
                    

                    Order order = new Order(salesOrderID, customerID, cusName, itemDescription, lineTotal);

                    results.Add(order);
                }

                advReader.Close();
                advConnect.Close();
            }
            return results;
        }
        
        /// <summary>
        /// Searches AdventureWorksLT for Select statement parameters and returns list of States for combo box options
        /// </summary>
        /// <returns>StateList of all available regions</returns>
        public List<string> StatesList()
        {
            var results = new List<string>();
            advConnect = new SqlConnection(Settings.Default.AdventureworksConnection);
            advCommand = advConnect.CreateCommand();
            advCommand.CommandType = CommandType.Text;
            advCommand.CommandText = @"SELECT DISTINCT StateProvince FROM SalesLT.Address ORDER BY StateProvince";

            using (advConnect)
            {
                advConnect.Open();
                advReader = advCommand.ExecuteReader();

                while (advReader.Read())
                {

                    string c = advReader["StateProvince"].ToString();
                    results.Add(c);
                }

                advReader.Close();
                advConnect.Close();
            }
            return results;
        }
        
    }
}
