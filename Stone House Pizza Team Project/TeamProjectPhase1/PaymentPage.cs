using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamProjectPhase1
{
    public partial class PaymentPage : Form
    {
        public DateTime today = new DateTime();
        public bool credit = false;
        public bool debit = false;
        public bool cash = false;
        private string firstName = "First Name!";
        private string lastName = "Last Name!";
        private string streetAddress = "Street Address!";
        private string cityName = "City!";
        private string zipCode = "Zip Code!";
        private string CCDebitNumber = "Card Number!";
        private string CvvNumber = "Cvv2 Number!";
        private string bankName = "Bank Name!";
        private string PINNumber = "PIN Number!";

        #region Initiializers
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void PaymentPage_Load(object sender, EventArgs e)
        {

            grpDebit.Visible = false;
            grpCard.Visible = true;
            txtFName.Focus();
            defaults();
            credit = true;
            clearAll();
            cboCardType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDebitType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboState.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void defaults()
        {
            today = DateTime.Now;
            cboCardType.Text = "Master Card";
            cboDebitType.Text = "Master Card";
            cboState.Text = "MI";
            cboMonth.Text = Convert.ToString(today.Month);
            cboYear.Text = Convert.ToString(today.Year);


        } 
        #endregion

        #region FormResetMethods
        private void clearAll()//empties all text boxes and cbo boxes
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            cboState.Text = "";
            txtZip.Text = "";
            cboCardType.Text = "";
            txtDebitCardNumber.Text = "";
            txtDebitCardNumber.Text = "";
            txtBankName.Text = "";
            cboDebitType.Text = "";
        }
        private void clearFinancial()//clears the finacial data only
        {
            cboCardType.Text = "";
            txtDebitCardNumber.Text = "";
            txtDebitCardNumber.Text = "";
            txtBankName.Text = "";
            cboDebitType.Text = "";
        } 
        #endregion

        #region radChangeEvents

        private void radDebit_CheckedChanged(object sender, EventArgs e)
        {

            grpCard.Visible = false;
            grpDebit.Visible = true;
            cash = false;
            credit = false;
            debit = true;
            clearFinancial();
        }

        private void radCash_CheckedChanged(object sender, EventArgs e)
        {

            grpCard.Visible = false;
            grpDebit.Visible = false;
            credit = false;
            debit = false;
            cash = true;
            clearFinancial();
        }

        private void radCredit_CheckedChanged(object sender, EventArgs e)
        {

            grpCard.Visible = true;
            grpDebit.Visible = false;
            cash = false;
            debit = false;
            credit = true;
            clearFinancial();
        } 
        #endregion

        //Input Data Validation Methods
        #region DataValidation

        private bool validateInput()//This is the validation Algorithm works from global variables credit and debit.
        {
            if (credit == true)
            {
                return
                    checkString(txtFName, firstName) &&
                    checkString(txtLName, lastName) &&
                    checkString(txtStreet, streetAddress) &&
                    checkString(txtCity, cityName) &&
                    checkString(txtZip, zipCode)

                    && checkValueRange(txtZip, zipCode)
                    && checkValueRange(txtCreditNumber, CCDebitNumber)
                    && checkValueRange(txtCvv, CvvNumber);
            }
            else if (debit == true)
            {
                return
                    checkString(txtFName, firstName) &&
                    checkString(txtLName, lastName) &&
                    checkString(txtStreet, streetAddress) &&
                    checkString(txtCity, cityName) &&
                    checkString(txtZip, zipCode) &&
                    checkString(txtBankName, bankName)

                    && checkValueRange(txtZip, zipCode)
                    && checkValueRange(txtDebitCardNumber, CCDebitNumber)
                    && checkValueRange(txtPin, PINNumber);
            }
            else
            {
                return
                    checkString(txtFName, firstName) &&
                    checkString(txtLName, lastName) &&
                    checkString(txtStreet, streetAddress) &&
                    checkString(txtCity, cityName) &&
                    checkString(txtZip, zipCode)
                    
                    && checkValueRange(txtZip, zipCode);
            }
        }
        private bool checkString(TextBox text, string value)//generic checker for empty strings
        {
            if (text.Text == "")
            {
                MessageBox.Show("Must Enter a " + value, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                text.Focus();
                return false;
            }
            return true;
        }
        private bool checkValueType(TextBox text, string value)//Makes Sure Value is an integer 
        {
            try
            {
                Convert.ToInt64(text.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Can Not Use Letters or Symbols for " + value, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                text.Focus();
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Must Use 16 digits only!" + value, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                text.Focus();
                return false;
            }
        }
        private bool checkValueRange(TextBox text, string value)//checks the range of each textbox dynamically after running checkvaluetype Method
        {
            checkValueType(text, value);//runs the check to make sure I got integers

            if (text.Name == "txtZip")//checks the length of each type of numeric input to ensure it isn't wrong length
            {
                Convert.ToString(text.Text);
                if (txtZip.TextLength != 5)
                {
                    MessageBox.Show("Must Enter 5 Digit " + value, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    text.Focus();
                    return false;
                }
            }
            else if (text.Name == "txtDebitCardNumber")
            {
                Convert.ToString(text.Text);
                if (text.TextLength != 16)
                {
                    MessageBox.Show("Must Enter 16 Digit Code For " + value, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    text.Focus();
                    return false;
                }
            }
            else if (text.Name == "txtCreditNumber")
            {
                Convert.ToString(text.Text);
                if (text.TextLength != 16)
                {
                    MessageBox.Show("Must Enter 16 Digit Code For " + value, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    text.Focus();
                    return false;
                }
            }
            else if (text.Name == "txtCvv")
            {
                Convert.ToString(text.Text);
                if (text.TextLength != 3)
                {
                    MessageBox.Show("Must Enter 3 Digit Code For " + value, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    text.Focus();
                    return false;
                }
            }
            else if (text.Name == "txtPin")
            {
                Convert.ToString(text.Text);
                if (text.TextLength != 4)
                {
                    MessageBox.Show("Must Enter 4 Digit Code For " + value, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    text.Focus();
                    return false;
                }
            }

            return true;
        }
        
        #endregion

        #region ButtonEvents
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validateInput() == true)//boolean check to validate all input in pre-send condition
            {

                if (cash == true)
                {
                    MenuPayment output = new MenuPayment(txtFName.Text, txtLName.Text, txtStreet.Text, txtCity.Text, cboState.Text, Convert.ToInt32(txtZip.Text));//Delivery Info transfer
                    output.Cash = true;
                    this.Tag = output;
                }
                else if (credit == true)//Check for Credit info transfer
                {
                    MenuPayment output = new MenuPayment(txtFName.Text, txtLName.Text, txtStreet.Text, txtCity.Text, cboState.Text, Convert.ToInt32(txtZip.Text),
                                                          cboCardType.Text, Convert.ToString(txtCreditNumber.Text), Convert.ToInt32(cboMonth.Text), Convert.ToInt32(cboYear.Text), txtCvv.Text);
                    output.Credit = true;
                    this.Tag = output;
                }
                else if (debit == true)//check for debit info transfer
                {
                    MenuPayment output = new MenuPayment(txtFName.Text, txtLName.Text, txtStreet.Text, txtCity.Text, cboState.Text, Convert.ToInt32(txtZip.Text),
                                                         cboDebitType.Text, Convert.ToString(txtDebitCardNumber.Text), txtBankName.Text, txtPin.Text);
                    output.Debit = true;
                    this.Tag = output;
                }
                

                
                this.DialogResult = DialogResult.OK;//verify dialogResult check to return data
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)//cancel button event
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)//resets the form entirely
        {
            clearAll();
        } 
        #endregion
    }
}
