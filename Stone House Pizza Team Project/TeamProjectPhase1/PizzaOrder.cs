//all code so far Blaine Simcox 1/23/2013 - 1/30/2003;
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
    public partial class PizzaOrder : Form
    {
        public double price = 0.00;//variable for carrying the price to Main Form
        public Int32 quantity = 0;
        private string size = "Small ";
        public string order = "";
       
        public PizzaOrder()
        {
            InitializeComponent();
            radPersonal.Checked = true;
            rtbPrice.Anchor = (AnchorStyles)
                    (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right);
            
        }
        
        private void OrderMaker()//string concatenator for order output
        {
            order = ""; // resets string to empty each time operation is run

            txtToppings.Text = "";
            if (chkAnch.Checked == true)
                order += "An, ";
            if (chkBacon.Checked == true)
                order += "Bc, ";
            if (chkCapricola.Checked == true)
                order += "Cp ";
            if (chkHam.Checked == true)
                order += "Hm, ";
            if (chkChicken.Checked == true)
                order += "Chk, ";
            if (chkSausage.Checked == true)
                order += "Sg, ";
            if (chkPepperoni.Checked == true)
                order += "Pp, ";
            if (chkOnion.Checked == true)
                order += "On, ";
            if (chkMushroom.Checked == true)
                order += "Msh, ";
            if (chkScallions.Checked == true)
                order += "Sc, ";
            if (chkBanana.Checked == true)
                order += "Bp, ";
            if (chkBlack.Checked == true)
                order += "Bo, ";
            if (chkKalamata.Checked == true)
                order += "Ko, ";
            if (chkTomato.Checked == true)
                order += "Tom, ";
            if (chkCheese.Checked == true)
                order += "ECh, ";
            if (chkArtichokes.Checked == true)
                order += "Art, ";
            if (chkPineapple.Checked == true)
                order += "Pa, ";
            if (chkBell.Checked == true)
                order += "Gp, ";
            txtToppings.Text = order;
        }
            
        private void clearCheckboxes()// clears everything back to empty
        {
            chkAnch.Checked = false;
            chkArtichokes.Checked = false;
            chkBacon.Checked = false;
            chkBanana.Checked = false;
            chkBell.Checked = false;
            chkBlack.Checked = false;
            chkCapricola.Checked = false;
            chkCheese.Checked = false;
            chkChicken.Checked = false;
            chkHam.Checked = false;
            chkKalamata.Checked = false;
            chkMushroom.Checked = false;
            chkOnion.Checked = false;
            chkPepperoni.Checked = false;
            chkPineapple.Checked = false;
            chkSausage.Checked = false;
            chkScallions.Checked = false;
            chkTomato.Checked = false;
            order = "";
            txtToppings.Text = "";
        }
        
        public void passSubtotal ()//passes data through the menu pizza class into the main form
        {
            menuPizzaClass customData = new menuPizzaClass(); //instantiate menuPizzaClass  
            price *= quantity;
            customData.Order = quantity + " " + size + order + " " + "$" + price;
            customData.Subtotal = price;
            this.Tag = customData; //send tag to customData object
            
            this.DialogResult = DialogResult.OK;//verify dialogResult check to return data
        }

        private void btnSubmit_Click(object sender, EventArgs e)//submit button event
        {
            try
            {
                quantity = (Convert.ToInt32(txtQuantity.Text)); //checks whether or not text is valid integer
            }
            catch (FormatException)//to save user trouble resets quantity to 1 if invalid
            {
                quantity = 1;
                txtQuantity.Text = Convert.ToString(1);
            }
           
            passSubtotal();

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (radExtra.Checked == true)
            {
                price = 9.99;
                size = "Extra-Large   ";
            }
            clearCheckboxes();
            txtSub.Text = Convert.ToString(price);

        }
       
        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (radMedium.Checked == true)
            {
                price = 6.99;
                size = "Medium   ";
            }
            clearCheckboxes();
            txtSub.Text = Convert.ToString(price);
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (radLarge.Checked == true)
            {
                price = 8.99;
                size = "Large   ";
            }
            clearCheckboxes();
            txtSub.Text = Convert.ToString(price);
        }

        private void radPersonal_CheckedChanged(object sender, EventArgs e)
        {

            if (radPersonal.Checked == true)
            {
                price = 5.49;
                size = "Small   ";
            }
            clearCheckboxes();
            txtSub.Text = Convert.ToString(price);
        }

        private void anyCheckChanged(object sender, EventArgs e)
        {
            
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)    // The CheckBox just became checked...
            {
                if (radPersonal.Checked == true)
                    price += .75;
                if (radMedium.Checked == true)
                    price += 1.00;
                if (radLarge.Checked == true)
                    price += 1.25;
                if (radExtra.Checked == true)
                    price += 1.50;
                OrderMaker();
            }

            else    // The CheckBox just became unchecked...
            {
                if (radPersonal.Checked == true)
                    price -= .75;
                if (radMedium.Checked == true)
                    price -= 1.00;
                if (radLarge.Checked == true)
                    price -= 1.25;
                if (radExtra.Checked == true)
                    price -= 1.50;
                OrderMaker();
            }
            
            txtSub.Text = Convert.ToString(price);
        }
    }
}
