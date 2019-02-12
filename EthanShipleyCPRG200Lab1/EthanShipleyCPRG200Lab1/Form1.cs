using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthanShipleyCPRG200Lab1
{
    
    public partial class Form1 : Form
    {
        /* Calculates a customers cost for their power consumption
         * Author: Ethan Shipley
         * Date: December 2018
         */

        // Cost and multiplication constants for types of customers
        const decimal RES_COST = 6.00m;  //residential initial cost
        const decimal RES_MULT = 0.052m; //residential cost multiplier
        const decimal CON_COST = 60.00m; //commercial initial cost
        const decimal COMMULT = 0.045m; //commercial cost multiplier
        const decimal IND_COST = 76.00m; //industrial peak hour initial cost
        const decimal IND_MULT = 0.065m; //industrial peak hour cost multiplier
        const decimal IND_OFF_PK_COST = 40.00m;    //industrial off-peak hour initial cost
        const decimal IND_OFF_PK_MULT = 0.028m;    //industrial off-peak hour cost multiplier
        const decimal CAP = 1000; // for the first 1000 kWh
        int cust = 1; // sets the default customer id to 1

        public Form1()
        {
            InitializeComponent();
            lblPkPwr.Visible = false; //hides the Peak power label
            lblOffPk.Visible = false; //hides the off peak power label
            txtOffPk.Visible = false; //hides the off peak power text

        }

        // Clears the texts fields in the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalcChrg.Text = "";
            txtPwrConsump.Text = "";
            lblPkPwr.Visible = false;
            lblOffPk.Visible = false;
            txtOffPk.Visible = false;
            radRes.Checked = true;
        }

        // Closes the form if button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Calculates the cost of power based on the radial button selected
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // initializes the variables
            decimal chrg=0;
            //decimal kwhPk = Convert.ToDecimal(txtPwrConsump.Text);//gets the peak power and power consumption
            
            //if (numChkz(kwhPk))
            if(validator.IsProvided(txtPwrConsump)&&validator.IsNonNegativeInt(txtPwrConsump))
            {
                int kwhPk = Convert.ToInt32(txtPwrConsump.Text);
                // determines which format to charge the customer based on customers id
                if (cust == 1)        //Is residential
                {
                    chrg = resConv(kwhPk);
                }
                else if (cust == 2)    //Is Commercial
                {
                    chrg = comConv(kwhPk);
                }
                else if (cust == 3 && (validator.IsProvided(txtOffPk) && validator.IsNonNegativeInt(txtOffPk)))    //Is Industrial
                {
                    decimal kwhOffPk = Convert.ToDecimal(txtOffPk.Text);//gets the off peak power

                    chrg = indConv(kwhPk)+ indOffPkConv(kwhOffPk);
                }
                // Display the calculated charges for the customer
                // if the chrg is greater then 0 then siplay the charge
                if (chrg > 0){
                    txtCalcChrg.Text = chrg.ToString("c");
                }
                else
                {
                    txtCalcChrg.Text = "";
                }
                
            }
        }
        //if user uses the esCAPe key then it esCAPes the form
        protected override bool ProcessDialogKey(Keys keyData)
        {
            //checks if user pressed escape button, closes the form
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        //sets customer id to one if resident
        private void radRes_CheckedChanged(object sender, EventArgs e)
        {
            cust = 1;
            lblPwrConsump.Visible = true;// makes the power consumption text appear
            lblPkPwr.Visible = false; //hides the Peak power label
            lblOffPk.Visible = false; //hides the off peak power label
            txtOffPk.Visible = false; //hides the off peak power text
        }

        //sets customer id to two if commercial
        private void radCom_CheckedChanged(object sender, EventArgs e)
        {
            cust = 2;
            lblPwrConsump.Visible = true;// makes the power consumption text appear
            lblPkPwr.Visible = false; //hides the Peak power label
            lblOffPk.Visible = false; //hides the off peak power label
            txtOffPk.Visible = false; //hides the off peak power text
        }

        //sets customer id to three if industrial off-peak hours
        private void radInd_CheckedChanged(object sender, EventArgs e)
        {
            cust = 3;
            lblPkPwr.Visible = true;      //shows the peak power text
            lblPwrConsump.Visible = false;// makes the power consumption text dissappear
            lblOffPk.Visible = true; //shows the off peak power label
            txtOffPk.Visible = true; //shows the off peak power text
        }

        //checks if the user has inputted a number and that it is positive
        private Boolean numChkz(decimal num)
        {
            //if the modulus of num is zero then num is not a whole number
            // and checks if num is positive
            if (num % 1 == 0 && num>=0)
            {
                return true;
            }
            else
            {
                // displays warning if user entered incorrect number format
                return false;
            }
        }

        //Function calculates the customers charge for residents, converts kwh to charge
        private decimal resConv(decimal kwh)
        {
            decimal cons = 0; //amount of consumption

            cons = RES_COST + RES_MULT * kwh;

            return cons; // returns the consumption
        }

        //Function calculates the customers charge for commercial, converts kwh to charge
        private decimal comConv(decimal kwh)
        {
            decimal cons = 0; //amount of consumption

            // checks if the customer power usage is less than the first CAP
            if (kwh > CAP)
            {
                cons = CON_COST + COMMULT *(kwh-CAP);
            }
            else
            {
                cons = CON_COST;
            }

            return cons; // returns the consumption
        }

        //Function calculates the customers charge for industrial peak hours, converts kwh to charge
        private decimal indConv(decimal kwh)
        {
            decimal cons = 0; //amount of consumption

            // checks if the customer power usage is less than the first CAP
            if (kwh > CAP)
            {
                cons = IND_COST + IND_MULT * (kwh-CAP);
            }
            else
            {
                cons = IND_COST;
            }
            

            return cons; // returns the consumption
        }

        //Function calculates the customers charge for industrial off-peak hours, converts kwh to charge
        private decimal indOffPkConv(decimal kwh)
        {
            decimal cons = 0; //amount of consumption

            // checks if the customer power usage is less than the first CAP
            if (kwh > CAP)
            {
                cons = IND_OFF_PK_COST + IND_OFF_PK_MULT * (kwh-CAP);
            }
            else
            {
                cons = IND_OFF_PK_COST;
            }

            return cons; // returns the consumption
        }
    }
}
