//all code so far Blaine Simcox 1/23/2013 - 1/30/2003;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace TeamProjectPhase1
{
    public partial class frmMain : Form
    {
        public double subtotal = 0;
        public string size = "Small ";
        public bool loggedIn = false;
        List<double> subTotals = new List<double>();//list for storing numeric data
        List<string> pizzaOrders = new List<string>();// list for storing pizza order strings
        List<MenuPayment> customers = new List<MenuPayment>();
        List<MenuPayment> customerCredit = new List<MenuPayment>();
        List<MenuPayment> customerDebit = new List<MenuPayment>();


        public frmMain()//Simcox 1/30/2013 initializes the main form and sets the subtotal textbox to zero 
        {
            InitializeComponent();
            
            txtSubtotal.Text = "$" + subtotal;
            clearRadios();
            lblAs.Visible = false;
            readXMLs();
            
        }

        private void button1_Click(object sender, EventArgs e)//Simcox 1/30/2013 instantiates form pizzaOrder Class 
        {
            string inboundOrder = "";

            PizzaOrder Custom = new PizzaOrder();//Simcox 1/30/2013 Creates new instance of form

            if (Custom.ShowDialog() == DialogResult.OK)
            {
                menuPizzaClass customPizza = (menuPizzaClass)Custom.Tag;  // Create a variable pointing to the new pizza, explicitly casting the Tag property from the form
                inboundOrder = Convert.ToString(customPizza.Order);
                subtotal = subtotal + Convert.ToDouble(customPizza.Subtotal);
                txtSubtotal.Text = "$" + Convert.ToString(subtotal.ToString("n2"));
                lstOrder.Items.Add(inboundOrder);//converts tag value to double value and adds it to subtotal
                subTotals.Add(customPizza.Subtotal);
                pizzaOrders.Add(inboundOrder);
            }
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)//clears the subtotal and order list
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete Your Order?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (result == DialogResult.OK)// if user clicks ok, removes item at selected index
            {
                subtotal = 0; // reset subtotal to 0
                txtSubtotal.Text = "$";// change text to " "
                lstOrder.Items.Clear();// clear lstOrder
                subTotals.Clear();
                pizzaOrders.Clear();
            }
        }
        
        private void pizzaCalculator(int qty, double pizzaPrice, string pizzaSize)//Main algorythm for calculating menu prices on pizzas
        {

            if (qty != 0  && pizzaPrice != 0)
            {
                subtotal += (pizzaPrice * qty);  // multiplies quantity by baseprice from pizzaPrice(qty)
                
                txtSubtotal.Text = "$" + subtotal.ToString("n2"); // sets the subtotal textbox
                lstOrder.Items.Add(qty + pizzaSize + " $" + (pizzaPrice * qty).ToString("n2")); // updates list with string concatenation
                subTotals.Add(pizzaPrice * qty);
                pizzaOrders.Add(qty + pizzaSize + " $" + (pizzaPrice * qty).ToString("n2"));
            }
            else
                clearRadios();
        }

        /*
         Size Stirng functions for pricing algorythm
        */

        #region Size String Methods
        private string sizeMeat()
        {
            string size = " ";

            if (radSMM.Checked == true)
                size = " Small Meat Lover's";
            if (radMDM.Checked == true)
                size = " Medium Meat Lover's";
            if (radLGM.Checked == true)
                size = " Large Meat Lover's";
            if (radXLM.Checked == true)
                size = " Extra-Large Meat Lover's";

            return size;
        }

        private string sizeRoasted()
        {
            string size = "";

            if (radSMR.Checked == true)
                size = " Small Roasted Chicken";
            if (radMDR.Checked == true)
                size = " Medium Roasted Chicken";
            if (radLGR.Checked == true)
                size = " Large Roasted Chicken";
            if (radXLR.Checked == true)
                size = " Extra-Large Roasted Chicken";

            return size;
        }
        private string sizeHawaiian()
        {
            string size = "";

            if (radSMH.Checked == true)
                size = " Small Hawaiian";
            if (radMDH.Checked == true)
                size = " Medium Hawaiian";
            if (radLGH.Checked == true)
                size = " Large Hawaiian"; ;
            if (radXLH.Checked == true)
                size = " Extra-Large Hawaiian";

            return size;
        }
        private string sizeSupreme()
        {
            string size = "";

            if (radSMS.Checked == true)
                size = " Small Supreme";
            if (radMDS.Checked == true)
                size = " Medium Supreme";
            if (radLGS.Checked == true)
                size = " Large Supreme";
            if (radXLS.Checked == true)
                size = " Extra-Large Supreme";

            return size;
        }
        private string sizeVeg()
        {
            string size = "";

            if (radSMV.Checked == true)
                size = " Small Vegetarian";
            if (radMDV.Checked == true)
                size = " Medium Vegetarian";
            if (radLGV.Checked == true)
                size = " Large Vegetarian";
            if (radXLV.Checked == true)
                size = " Extra-Large Vegetarian";

            return size;
        }
        private string sizeGreek()
        {
            string size = "";

            if (radSMG.Checked == true)
                size = " Small Greek Salad";
            if (radMDG.Checked == true)
                size = " Medium Greek Salad";
            if (radLGG.Checked == true)
                size = " Large Greek Salad";
            if (radXLG.Checked == true)
                size = " Extra-Large Greek Salad";

            return size;
        }
        private string sizeAnti()
        {
            string size = "";

            if (radSMA.Checked == true)
                size = " Small Anti-Pesto Salad";
            if (radMDA.Checked == true)
                size = " Medium Anti-Pesto Salad";
            if (radLGA.Checked == true)
                size = " Large Anti-Pesto Salad";
            if (radXLA.Checked == true)
                size = " Extra-Large Anti-Pesto Salad";

            return size;
        }
        private string sizeTossed()
        {
            string size = "";

            if (radSMT.Checked == true)
                size = " Small Tossed Salad";
            if (radMDT.Checked == true)
                size = " Medium Tossed Salad";
            if (radLGT.Checked == true)
                size = " Large Tossed Salad";
            if (radXLT.Checked == true)
                size = " Extra-Large Tossed Salad";

            return size;
        }
        private string sizePlain()
        {
            string size = "";

            if (rad10WP.Checked == true)
                size = " 10 Wings Plain";
            if (rad20WP.Checked == true)
                size = " 20 Wings Plain";

            return size;
        }
        private string sizeBbq()
        {
            string size = "";

            if (rad10Q.Checked == true)
                size = " 10 Wings BBQ";
            if (rad20Q.Checked == true)
                size = " 20 Wings BBQ";

            return size;
        }
        private string sizeBuffalo()
        {
            string size = "";

            if (rad10B.Checked == true)
                size = " 10 Wings Buffalo-Style";
            if (rad20B.Checked == true)
                size = " 20 Wings Buffalo-Style";

            return size;
        }
        private string sizeBread()
        {
            string size = "";

            if (radBread6.Checked == true)
                size = " 6 Bread Sticks";
            if (radBread12.Checked == true)
                size = " 12 Bread Sticks";

            return size;
        }
        private string sizeCheesey()
        {
            string size = "";

            if (radCheeseySm.Checked == true)
                size = " Sm Cheesey Bread";
            if (radCheeseyLg.Checked == true)
                size = " Lg Cheesey Bread";

            return size;
        } 
        private string pepsi()
        {
            string pop = " 2-liter(s)";
            return pop;
        }
        #endregion

        /*End String Functions*/

        /*
         * 
         * 
         Start Pricing function tables
        */

        #region Pricing Methods
        private double pizzaPriceMeat()
        {
            double basePrice = 0;

            if (radSMM.Checked == true)
                basePrice = 9.99;
            if (radMDM.Checked == true)
                basePrice = 13.99;
            if (radLGM.Checked == true)
                basePrice = 16.49;
            if (radXLM.Checked == true)
                basePrice = 18.99;

            return basePrice;
        }
        private double pizzaPriceHawaiian()
        {
            double basePrice = 0;

            if (radSMH.Checked == true)
                basePrice = 8.49;
            if (radMDH.Checked == true)
                basePrice = 11.99;
            if (radLGH.Checked == true)
                basePrice = 13.99;
            if (radXLH.Checked == true)
                basePrice = 15.99;

            return basePrice;
        }
        private double pizzaPriceRoasted()
        {
            double basePrice = 0;

            if (radSMR.Checked == true)
                basePrice = 9.24;
            if (radMDR.Checked == true)
                basePrice = 13.99;
            if (radLGR.Checked == true)
                basePrice = 16.49;
            if (radXLR.Checked == true)
                basePrice = 18.99;
            return basePrice;
        }
        private double pizzaPriceSupreme()
        {
            double basePrice = 0;

            if (radSMS.Checked == true)
                basePrice = 10.74;
            if (radMDS.Checked == true)
                basePrice = 14.99;
            if (radLGS.Checked == true)
                basePrice = 17.74;
            if (radXLS.Checked == true)
                basePrice = 20.49;

            return basePrice;
        }
        private double pizzaPriceVeg()
        {
            double basePrice = 0;

            if (radSMV.Checked == true)
                basePrice = 9.99;
            if (radMDV.Checked == true)
                basePrice = 13.99;
            if (radLGV.Checked == true)
                basePrice = 16.49;
            if (radXLV.Checked == true)
                basePrice = 18.99;

            return basePrice;
        }
        private double pizzaPriceGreek()
        {
            double basePrice = 0;

            if (radSMG.Checked == true)
                basePrice = 5.95;
            if (radMDG.Checked == true)
                basePrice = 7.95;
            if (radLGG.Checked == true)
                basePrice = 9.95;
            if (radXLG.Checked == true)
                basePrice = 11.95;

            return basePrice;
        }
        private double pizzaPriceTossed()
        {
            double basePrice = 0;

            if (radSMT.Checked == true)
                basePrice = 5.95;
            if (radMDT.Checked == true)
                basePrice = 7.95;
            if (radLGT.Checked == true)
                basePrice = 9.95;
            if (radXLT.Checked == true)
                basePrice = 11.95;

            return basePrice;
        }
        private double pizzaPriceAnti()
        {
            double basePrice = 0;

            if (radSMA.Checked == true)
                basePrice = 5.95;
            if (radMDA.Checked == true)
                basePrice = 7.95;
            if (radLGA.Checked == true)
                basePrice = 9.95;
            if (radXLA.Checked == true)
                basePrice = 11.95;

            return basePrice;
        }
        private double pizzaPriceBuffalo()
        {
            double basePrice = 0;

            if (rad10B.Checked == true)
                basePrice = 6.95;
            if (rad20B.Checked == true)
                basePrice = 11.95;

            return basePrice;
        }
        private double pizzaPriceBbq()
        {
            double basePrice = 0;

            if (rad10Q.Checked == true)
                basePrice = 6.95;
            if (rad20Q.Checked == true)
                basePrice = 11.95;

            return basePrice;
        }
        private double pizzaPricePlain()
        {
            double basePrice = 0;

            if (rad10WP.Checked == true)
                basePrice = 6.95;
            if (rad20WP.Checked == true)
                basePrice = 11.95;

            return basePrice;
        }
        private double pizzaPriceBread()
        {
            double basePrice = 0;

            if (radBread6.Checked == true)
                basePrice = 4.95;
            if (radBread12.Checked == true)
                basePrice = 6.95;

            return basePrice;
        }
        private double pizzaPriceCheesey()
        {
            double basePrice = 0;

            if (radCheeseySm.Checked == true)
                basePrice = 6.95;
            if (radCheeseyLg.Checked == true)
                basePrice = 8.95;

            return basePrice;
        }
        private double pepsiTwoLiters()
        {
            double basePrice = 2.35;
            return basePrice;
        }
        
        #endregion
        /*end pricing table functions*/
        
        private int getQuantity(Control control)//Conversion and input exception handler for Meat Lover's textbox
        {
            int qty = 0;
            try
            {
                qty = Convert.ToInt16(control.Text);//get quantity by control name

            }
            catch (FormatException)
            {
                txtQML.Text = "0";
                qty = 0;
            }
            return qty;
        }
        
        private void clearRadios()//3/17/2013 Blaine Simcox function to fix glitch in radio button selection
        {
            rad10B.Checked = false;
            rad10Q.Checked = false;
            rad10WP.Checked = false;
            rad20B.Checked = false;
            rad20Q.Checked = false;
            rad20WP.Checked = false;
            radLGA.Checked = false;
            radLGG.Checked = false;
            radLGH.Checked = false;
            radLGM.Checked = false;
            radLGR.Checked = false;
            radLGS.Checked = false;
            radLGT.Checked = false;
            radLGV.Checked = false;
            radMDA.Checked = false;
            radMDG.Checked = false;
            radMDH.Checked = false;
            radMDM.Checked = false;
            radMDR.Checked = false;
            radMDS.Checked = false;
            radMDT.Checked = false;
            radMDV.Checked = false;
            radSMA.Checked = false;
            radSMG.Checked = false;
            radSMH.Checked = false;
            radSMM.Checked = false;
            radSMR.Checked = false;
            radSMS.Checked = false;
            radSMT.Checked = false;
            radSMV.Checked = false;
            radXLA.Checked = false;
            radXLG.Checked = false;
            radXLH.Checked = false;
            radXLM.Checked = false;
            radXLR.Checked = false;
            radXLS.Checked = false;
            radXLT.Checked = false;
            radXLV.Checked = false;

            
        }
        
        /*add button click events*/

        #region Button Events
        private void btnMeat_Click(object sender, EventArgs e)//meat lover's button event
        {
            int qty = getQuantity(txtQML);
            pizzaCalculator(qty, pizzaPriceMeat(), sizeMeat());
            clearRadios();
            txtQML.Text = "0";
        }

        private void btnHaw_Click(object sender, EventArgs e)// hawaiian button event
        {
            int qty = getQuantity(txtQHA);
            pizzaCalculator(qty, pizzaPriceHawaiian(), sizeHawaiian());
            clearRadios();
            txtQHA.Text = "0";

        }

        private void btnChick_Click(object sender, EventArgs e)//chicken button event
        {
            int qty = getQuantity(txtQRC);
            pizzaCalculator(qty, pizzaPriceRoasted(), sizeRoasted());
            clearRadios();
            txtQRC.Text = "0";
        }

        private void btnSup_Click(object sender, EventArgs e)//supreme button event
        {

            int qty = getQuantity(txtQSU);
            pizzaCalculator(qty, pizzaPriceSupreme(), sizeSupreme());
            clearRadios();
            txtQSU.Text = "0";
        }

        private void btnVeg_Click(object sender, EventArgs e)// vegetarian button event
        {

            int qty = getQuantity(txtQVG);
            pizzaCalculator(qty, pizzaPriceVeg(), sizeVeg());
            clearRadios();
            txtQVG.Text = "0";
        }

        private void btnGreek_Click(object sender, EventArgs e)//add greek button event Blaine Simcox 3/17/2013
        {
            int qty = getQuantity(txtQtyGreek);
            pizzaCalculator(qty, pizzaPriceGreek(), sizeGreek());
            clearRadios();
            txtQtyGreek.Text = "0";
        }

        private void btnAddAnti_Click(object sender, EventArgs e)//add greek button event Blaine Simcox 3/17/2013
        {
            int qty = getQuantity(txtQtyAnti);
            pizzaCalculator(qty, pizzaPriceAnti(), sizeAnti());
            clearRadios();
            txtQtyAnti.Text = "0";
        }

        private void btnAddTossed_Click(object sender, EventArgs e)//add greek button event Blaine Simcox 3/17/2013
        {
            int qty = getQuantity(txtQtyTossed);
            pizzaCalculator(qty, pizzaPriceTossed(), sizeTossed());
            clearRadios();
            txtQtyTossed.Text = "0";
        }

        private void btnAddPlain_Click(object sender, EventArgs e)//add Plain wings button event Blaine Simcox 3/17/2013
        {
            int qty = getQuantity(txtQtyPlain);
            pizzaCalculator(qty, pizzaPricePlain(), sizePlain());
            clearRadios();
            txtQtyPlain.Text = "0";
        }

        private void btnAddBbq_Click(object sender, EventArgs e)//add Bbq wings button event Blaine Simcox 3/17/2013
        {
            int qty = getQuantity(txtQtyBbq);
            pizzaCalculator(qty, pizzaPriceBbq(), sizeBbq());
            clearRadios();
            txtQtyBbq.Text = "0";
        }

        private void btnAddBuffalo_Click(object sender, EventArgs e)//add Buffalo button event Blaine Simcox 3/17/2013
        {
            int qty = getQuantity(txtQtyBuffalo);
            pizzaCalculator(qty, pizzaPriceBuffalo(), sizeBuffalo());
            clearRadios();
            txtQtyBuffalo.Text = "0";
        }

        private void btnAddBread_Click(object sender, EventArgs e)//add Bread Sticks button event Blaine Simcox 3/17/2013
        {
            int qty = getQuantity(txtQtyBread);
            pizzaCalculator(qty, pizzaPriceBread(), sizeBread());
            clearRadios();
            txtQtyBread.Text = "0";
        }

        private void btnAddCheesey_Click(object sender, EventArgs e)//add Cheeesey Bread button event Blaine Simcox 3/17/2013
        {
            int qty = getQuantity(txtQtyCheesey);
            pizzaCalculator(qty, pizzaPriceCheesey(), sizeCheesey());
            clearRadios();
            txtQtyCheesey.Text = "0";
        }
        private void btnAddPepsi_Click(object sender, EventArgs e)
        {
            int qty = getQuantity(nudPepsi);
            pizzaCalculator(qty, pepsiTwoLiters(), pepsi());
            clearRadios();
            nudPepsi.Text = "0";
        }
        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (loggedIn == false)
            {
                MessageBox.Show("You Must Log In to Continue!", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                btnLogIn.Focus();
            }
            else
            {
                string receipt = "\n\nYour Oder:\n____________________________\n\n";

                for(int i = 0; i < pizzaOrders.Count; i++)
                {
                    string order = pizzaOrders[i] ;
                    receipt += order + "\n";
                }
                
                receipt += "Total:\n\n________________________________\n\nTaxes: $" + (subtotal * .06).ToString("n2") + "\n" + "Total: $" + (subtotal + (subtotal * .06)).ToString("n2");
                DialogResult result = MessageBox.Show(rtbCustomer.Text + "\n\n" + rtbCardInfo.Text + receipt, "Goodbye!", MessageBoxButtons.OKCancel, 
                                                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    DialogResult result2 = MessageBox.Show("You Are Now Finalizing Your Order, \nYou Will Now Exit the Application!" + "\n\n\nDesign Team:"
                                         + " ____________________\n" + "Head Programmer:  Blaine Simcox II\n" + "Secondary Programmer: Dakota Zenner\n"
                                         + "Head Researcher:  Shane Johnson\n" + "QA:  Steven Starlin\n" + "QA:  Ethan Vanhoose\n" + "QA:  Athony Brown",
                                         "Are You sure you Want To Leave?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                                        
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage();

            if (paymentPage.ShowDialog() == DialogResult.OK)
            {

                MenuPayment input = (MenuPayment)paymentPage.Tag;
                if (input.Cash == true)
                    customers.Add(input);
                else if (input.Credit == true)
                    customerCredit.Add(input);
                else
                    customerDebit.Add(input);
                rtbLoader(input);
                writeXMLs(input);
            }
        }
        #endregion

        /*end add Button Click events*/

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)//removes selected items from listbox and updates paralell list
        {
            int index = lstOrder.SelectedIndex; //sets integer at selected index
            double removeList = subTotals[index]; //creates variable to subtract from global subtotal variable

            DialogResult result = MessageBox.Show("Are You Sure You Want to Remove This Item?", "Attention!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)// if user clicks ok, removes item at selected index
            {
                subtotal -= removeList;
                txtSubtotal.Text = "$" + Convert.ToString(subtotal.ToString("n2"));
                subTotals.RemoveAt(index);//update paralell list for listbox Blaine Simcox 3/17/2013
                pizzaOrders.RemoveAt(index);//update paralell string list for workaround Blaine Simcox 3/17/2013 

                lstOrder.Items.Clear(); // Lines 628 - 633 courtesy of Jeff Straw, modified by Blaine; workaround for system failure
                foreach (var order in pizzaOrders)
                {
                    lstOrder.Items.Add(order);
                }
            }
        }

        

        private void rtbLoader(MenuPayment input)//loads various rtb boxes and set global variable loggedIn to true for submit button
        {
            rtfOutputs(input);

            lblAs.Visible = true;
            lblLogInStatus.Text = "Logged In";
            lblCustomerName.Text = input.LName + ", " + input.FName;

            loggedIn = true;
        }

        private void rtfOutputs(MenuPayment input)//builds the strings for rtb's
        {
            string pin = Convert.ToString(input.Pin);
            string cvv = Convert.ToString(input.CVV2);


            rtbCustomer.Text = "Customer Delivery Info:\n" + input.FName + " " + input.LName + "\n" + input.Street + "\n" + input.City + ", " + input.State + " " + input.Zip;
            if (input.Debit == true)
            {
                rtbCardInfo.Text = "Debit Card Info:\nCard Type: " + input.DCtype + "\nCard Number: " + input.DCNumber.Replace(input.DCNumber, "****************")
                                    + "\nEBank: " + input.Bank + "\nPIN: " + pin.Replace(Convert.ToString(input.Pin), "***");
            }
            else if (input.Credit == true)
            {
                rtbCardInfo.Text = "Credit Card Info:\nCard Type: " + input.CCType + "\nCard Number: " + input.CCNumber.Replace(input.CCNumber, "****************")
                                    + "\nExpiration: " + input.ExpirationMonth + "/ " + input.ExpirationYear + "\nCvv2: " + cvv.Replace(Convert.ToString(input.CVV2), "***");
            }
            else
                rtbCardInfo.Text = "Cash";
        }

        #region XMLFunctions

        private void writeXMLs(MenuPayment input)
        {

            XmlWriterSettings settings = new XmlWriterSettings();//defines indetation of elements and nodes inside of elements Blaine 4/9/2012
            settings.Indent = true;
            settings.IndentChars = "    ";
            string path = "";

            if (input.Credit == true)//checks which type of xml to write to 
                path = @"..\..\xml\credit.xml";
            else if (input.Debit == true)
                path = @"..\..\xml\debit.xml";
            else
                path = @"..\..\xml\customers.xml";

            using (XmlWriter writer = XmlWriter.Create(path, settings))//create new instance of Xml writer class to write to relative path
            {
                writer.WriteStartDocument();//Blaine 4/9/2012//starts the XML
                writer.WriteStartElement("customers");//Adds Header Element

                if (input.Credit == true)
                {
                    foreach (MenuPayment customer in customerCredit)//dotnetPerls algorthm //adds individual elemnts into each Employee (singular) Element
                    {
                        writer.WriteStartElement("customer"); //Start new Employee Element

                        writer.WriteElementString("FirstName", customer.FName);//output to Xml
                        writer.WriteElementString("LastName", customer.LName);//output to Xml
                        writer.WriteElementString("StreetAdress", customer.Street);//output to Xml
                        writer.WriteElementString("City", customer.City);//output to Xml
                        writer.WriteElementString("State", customer.State);//output to Xml
                        writer.WriteElementString("Zip", Convert.ToString(customer.Zip));//output to Xml

                        writer.WriteElementString("CCType", customer.CCType);
                        writer.WriteElementString("CCNumber", customer.CCNumber);
                        writer.WriteElementString("expMonth", Convert.ToString(customer.ExpirationMonth));
                        writer.WriteElementString("expYear", Convert.ToString(customer.ExpirationYear));
                        writer.WriteElementString("Cvv", customer.CVV2);

                        writer.WriteEndElement();//end customer element
                    }
                }
                else if (input.Debit == true)
                {
                    foreach (MenuPayment customer in customerDebit)
                    {
                        writer.WriteStartElement("customer"); //Start new Employee Element

                        writer.WriteElementString("FirstName", customer.FName);//output to Xml
                        writer.WriteElementString("LastName", customer.LName);//output to Xml
                        writer.WriteElementString("StreetAdress", customer.Street);//output to Xml
                        writer.WriteElementString("City", customer.City);//output to Xml
                        writer.WriteElementString("State", customer.State);//output to Xml
                        writer.WriteElementString("Zip", Convert.ToString(customer.Zip));//output to Xml

                        writer.WriteElementString("DCType", customer.DCtype);
                        writer.WriteElementString("DCNumber", customer.DCNumber);
                        writer.WriteElementString("Bank", customer.Bank);
                        writer.WriteElementString("PIN", Convert.ToString(customer.Pin));


                        writer.WriteEndElement();//end Employee element
                    }
                }
                else
                {
                    foreach (MenuPayment customer in customers)
                    {
                        writer.WriteStartElement("customer"); //Start new Employee Element

                        writer.WriteElementString("FirstName", customer.FName);//output to Xml
                        writer.WriteElementString("LastName", customer.LName);//output to Xml
                        writer.WriteElementString("StreetAdress", customer.Street);//output to Xml
                        writer.WriteElementString("City", customer.City);//output to Xml
                        writer.WriteElementString("State", customer.State);//output to Xml
                        writer.WriteElementString("Zip", Convert.ToString(customer.Zip));//output to Xml

                        writer.WriteEndElement();//end Employee element
                    }
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }//finish using instance of Xml Writer 

        }
        private void readXMLs()
        {
            XmlReaderSettings settings = new XmlReaderSettings();//instatiate new writer setting object tell it to ignore comments and white space
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            using (XmlReader xmlIn = XmlReader.Create(@"..\..\xml\customers.xml", settings))//creat new reader object at relative path with previous settings used to create customer file
            {
                xmlIn.ReadToDescendant("customer"); //start xml read at Parent root element
                customers.Clear();//clear the customers list just in case
                do
                {
                    customerInfoXmlIn(xmlIn);

                } while (xmlIn.ReadToNextSibling("customer"));//until you hit the element with no next sibling
            }
            using (XmlReader xmlIn = XmlReader.Create(@"..\..\xml\credit.xml", settings))//creat new reader object at relative path with previous settings used for credit file
            {
                xmlIn.ReadToDescendant("customer"); //start xml read at Parent root element
                customerCredit.Clear();//clear the customers list just in case
                do
                {
                    creditInfoXmlIn(xmlIn);

                } while (xmlIn.ReadToNextSibling("customer"));//until you hit the element with no next sibling
            }
            using (XmlReader xmlIn = XmlReader.Create(@"..\..\xml\debit.xml", settings))//creat new reader object at relative path with previous settings used for debit file
            {
                xmlIn.ReadToDescendant("customer"); //start xml read at Parent root element
                customerDebit.Clear();//clear the customers list just in case
                do
                {
                    debitInfoXmlIn(xmlIn);

                } while (xmlIn.ReadToNextSibling("customer"));//until you hit the element with no next sibling
            }
        }

        private void customerInfoXmlIn(XmlReader xmlIn)//method to return customer cash orders
        {
            string fname;
            string lname;
            string street;
            string city;
            string state;
            int zip;

            deliveryInfoXml(xmlIn, out fname, out lname, out street, out city, out state, out zip);

            MenuPayment output = new MenuPayment(fname, lname, street, city, state, zip);
            customers.Add(output);
        }

        private void creditInfoXmlIn(XmlReader xmlIn)//method to return credit card orders
        {
            string fname;
            string lname;
            string street;
            string city;
            string state;
            int zip;

            deliveryInfoXml(xmlIn, out fname, out lname, out street, out city, out state, out zip);


            string ccType = xmlIn.ReadElementContentAsString();//credit info
            string ccNumber = xmlIn.ReadElementContentAsString();
            int expMonth = xmlIn.ReadElementContentAsInt();
            int expYear = xmlIn.ReadElementContentAsInt();
            string cvv = xmlIn.ReadElementContentAsString();

            MenuPayment output = new MenuPayment(fname, lname, street, city, state, zip, ccType, ccNumber, expMonth, expYear, cvv);
            customerCredit.Add(output);
        }
        private void debitInfoXmlIn(XmlReader xmlIn)//method to return debit card orders
        {
            string fname;
            string lname;
            string street;
            string city;
            string state;
            int zip;

            deliveryInfoXml(xmlIn, out fname, out lname, out street, out city, out state, out zip);

            string dcType = xmlIn.ReadElementContentAsString();//debit info
            string dcNumber = xmlIn.ReadElementContentAsString();
            string bank = xmlIn.ReadElementContentAsString();
            string pin = xmlIn.ReadElementContentAsString();

            MenuPayment output = new MenuPayment(fname, lname, street, city, state, zip, dcType, dcNumber, bank, pin);
            customerDebit.Add(output);
        }

        private static void deliveryInfoXml(XmlReader xmlIn, out string fname, out string lname, out string street, out string city, out string state, out int zip)//method for basic customer info
        {
            xmlIn.ReadStartElement("customer");//read first root
            fname = xmlIn.ReadElementContentAsString(); //variables loaded for instantiation of MenuPayment constructor
            lname = xmlIn.ReadElementContentAsString();
            street = xmlIn.ReadElementContentAsString();
            city = xmlIn.ReadElementContentAsString();
            state = xmlIn.ReadElementContentAsString();
            zip = xmlIn.ReadElementContentAsInt();
        } 
        #endregion

        



        

       

       

       

        

        

        

        
       

        

        

        

        
    }
}
