///<summary>
///Blaine Simcox II
///CIT 255
///Jeff Straw
///Final Exam
///12/5/2013
///Image taken from smokeandscales.blogspot.com
///Form Data For Project
///Gives User an Interface
///and provides a visual representation
///of Database
///</summary>
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstrumentsUI
{
    public partial class Form1 : Form
    {
        #region Fields
		
        /// <summary>
        /// Object For Instantiating DataBase
        /// </summary>
        DataRepository instruments = new DataRepository();

        /// <summary>
        /// String For Storing Database in Formatted Form
        /// To Load rtbMaster
        /// </summary>
        private string rtbmasterString = ""; 
	    #endregion

        #region Constructors and Form Initializers
        /// <summary>
        /// Default Constructor for form
        /// Uses Exception handling to Thorw 
        /// message for Missing Database
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitializeDataBase();
        }

        /// <summary>
        /// Sets Default Values for Form from Db File
        /// </summary>
        private void InitializeDataBase()
        {
            try//try to get Db Items and load to rtbMaster and cboType
            {
                rtbmasterString = "";

                foreach (Instrument I in instruments.GetInstruments())
                {
                    rtbmasterString += I;
                }

                rtbMaster.Text = rtbmasterString;

                cboType.Items.Clear();

                foreach (Section S in instruments.GetType())
                {
                    cboType.Items.Add(S);
                }
            }
            catch (Exception ex)//If db not present, throws exception and messagebox declaring the problem
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region Methods
        /// <summary>
        /// Triggers the GetInstruments(string) method
        /// Returns Filtered Data based On Type
        /// </summary>
        /// <param name="sender">End User</param>
        /// <param name="e">SelectedValueChanged Event</param>
        private void cboType_SelectedValueChanged(object sender, EventArgs e)
        {
            string s = cboType.SelectedItem.ToString();
            try
            {
                if (s != null && s != "")//work around required for my installation of Visual Studio
                {
                    rtbMaster.Text = "";
                    rtbmasterString = "";
                    foreach (Instrument I in instruments.GetInstruments(s))
                    {
                        rtbmasterString += I;
                    }
                    rtbMaster.Text = rtbmasterString;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets rtbMaster to default Text
        /// </summary>
        /// <param name="sender">End User</param>
        /// <param name="e">BtnReset Click Event</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeDataBase();
        }

        /// <summary>
        /// Exits Application
        /// </summary>
        /// <param name="sender">End User</param>
        /// <param name="e">BtnExit Click Event</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
        #endregion
}
