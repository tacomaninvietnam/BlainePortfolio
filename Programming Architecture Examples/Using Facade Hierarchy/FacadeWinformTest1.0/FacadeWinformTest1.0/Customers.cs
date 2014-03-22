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

namespace FacadeWinformTest1._0
{
    class Customers
    {
        /// <summary>
        /// Fields For Customer Class
        /// </summary>
        #region fields
        public string _fName;
        public string _title;
        public string _mName;
        public string _lName;
        public string _suffix;
        public string _companyName;
        public string _salesPerson;
        public string _emailAddress;
        public string _phoneNumber;
        public int _customerID;
        public bool _nameStyle;
        public string _passwordHash;
        public string _passwordSalt;
        public Guid _rowGUID;
        public DateTime _modifiedDate;
        private string _address;
        private string _city;
        private string _state;
        private string _postalCode;

        #endregion

        /// <summary>
        /// Default Constructor For Customers Class
        /// </summary>
        public Customers()
        {
            
        }

        /// <summary>
        /// Fully Loaded Constructor For Customers
        /// </summary>
        /// <param name="_customerID">CustomerID field</param>
        /// <param name="_nameStyle">NameStyle Field</param>
        /// <param name="_fName">FirstName Field</param>
        /// <param name="_mName">Nullable Middle Name Field</param>
        /// <param name="_lName">LastName Field</param>
        /// <param name="_suffix">Nullable Suffix field</param>
        /// <param name="_companyName">Nullable Comapany Name Field</param>
        /// <param name="_salesPerson">Nullable SalesPerson Field</param>
        /// <param name="_emailAddress">Nullable EmailAddress Field</param>
        /// <param name="_phoneNumber">Nullable PhoneNumber Field</param>
        /// <param name="passwordHash">PasswordHash Field</param>
        /// <param name="_passwordSalt">PasswordSalt Field</param>
        /// <param name="_rowguid">Rowguid Field</param>
        /// <param name="_modifiedDate">ModifiedDate Field</param>
        public Customers(int customerID, bool nameStyle, string title, string fName, string mName, string lName, string suffix,
                         string address, string city, string state, string zip,
                         string companyName, string salesPerson, string emailAddress, string phoneNumber, 
                         string passwordHash, string passwordSalt, Guid rowguid, DateTime modifiedDate)
        {
            this._customerID = customerID;
            this._nameStyle = nameStyle;
            this._title = title;
            this._fName = fName;
            this._mName = mName;
            this._lName = lName;
            this._suffix = suffix;
            this._address = address;
            this._city = city;
            this._state = state;
            this._postalCode = zip;
            this._companyName = companyName;
            this._salesPerson = salesPerson;
            this._emailAddress = emailAddress;
            this._phoneNumber = phoneNumber;
            this._passwordHash = passwordHash;
            this._passwordSalt = passwordSalt;
            this._rowGUID = rowguid;
            this._modifiedDate = modifiedDate;
        }

        /// <summary>
        /// ToString Override for Customers class
        /// </summary>
        /// <returns>Formatted Customer String</returns>
        public override string ToString()
        {
            return string.Format("Cusotmer ID#:   {0}\n" +
                                 "{1} {2} {3} {4} {5}\n"+
                                 "{6}\n"+
                                 "{7}, {8} {9}\n"+
                                 "{10}\n"+
                                 "Phone: {11}\n"+
                                 "Company: {12}\n"+
                                 "Sales Person: {13}\n"+
                                 "{14}\n",
                                 
                                 this._customerID, this._title, this._fName, this._mName, this._lName, this._suffix,
                                 this._address, this._city, this._state, this._postalCode,
                                 this._emailAddress, this._phoneNumber, this._companyName, this._salesPerson, this._modifiedDate);
        }
    }
}
