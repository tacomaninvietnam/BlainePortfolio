using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamProjectPhase1
{
    class MenuPayment
    {
        string _firstName;//delivery info
        string _lastName;
        string _street;
        string _city;
        string _state;
        int _zip;
        
        string _dcType;//debit info
        string _dcNumber;
        string _bank;
        string _pin;

        string _ccType;//credit info
        string _ccNumber;
        int _expMonth;
        int _expYear;
        string _cvv;

        bool _credit;
        bool _debit;
        bool _cash;

        #region DeliveryInfo

        public string FName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public int Zip
        {
            get { return _zip; }
            set { _zip = value; }
        } 
        #endregion

        #region DebitInfo
        public string DCtype
        {
            get { return _dcType; }
            set { _dcType = value; }
        }
        public string DCNumber
        {
            get { return _dcNumber; }
            set { _dcNumber = value; }
        }
        public string Bank
        {
            get { return _bank; }
            set { _bank = value; }
        }
        public string Pin
        {
            get { return _pin; }
            set { _pin = value; }
        } 
        #endregion


        #region CreditInfo
        public string CCType
        {
            get { return _ccType; }
            set { _ccType = value; }
        }
        public string CCNumber
        {
            get { return _ccNumber; }
            set { _ccNumber = value; }
        }
        public int ExpirationMonth
        {
            get { return _expMonth; }
            set { _expMonth = value; }
        }
        public int ExpirationYear
        {
            get { return _expYear; }
            set { _expYear = value; }
        }
        public string CVV2
        {
            get { return _cvv; }
            set { _cvv = value; }
        } 
        #endregion

        #region BoolInfo
        public bool Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }
        public bool Debit
        {
            get { return _debit; }
            set { _debit = value; }
        }
        public bool Cash
        {
            get { return _cash; }
            set { _cash = value; }
        } 
        #endregion

        public MenuPayment(string first, string last, string street, string city, string state, int zip)
        {
            this._firstName = first;
            this._lastName = last;
            this._street = street;
            this._city = city;
            this._state = state;
            this._zip = zip;

            
        }

        public MenuPayment(string first, string last, string street, string city, string state, int zip, string dctype, string dcnumber, string bank, string pin)
        {
            this._firstName = first;
            this._lastName = last;
            this._street = street;
            this._city = city;
            this._state = state;
            this._zip = zip;

            this._dcType = dctype;
            this._dcNumber = dcnumber;
            this._bank = bank;
            this._pin = pin;

            
        }

        public MenuPayment(string first, string last, string street, string city, string state, int zip, string cctype, string ccnum, int expM, int expY, string cvv)
        {
            this._firstName = first;
            this._lastName = last;
            this._street = street;
            this._city = city;
            this._state = state;
            this._zip = zip;

            this._ccType = cctype;
            this._ccNumber = ccnum;
            this._expMonth = expM;
            this._expYear = expY;
            this._cvv = cvv;

            
        }
    }
}
