using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Purchase
{
    public partial class vehiclePurchase : Form
    {

        const double STEREO_SYSTEM = 425.76;
        const double LEATHER_INTERIOR = 987.41;
        const double COMPUTER_NAV = 1741.23;
        const double STANDARD = 0;
        const double PEARLIZED = 345.72;
        const double CUSTOM_DETAIL = 599.99;
        const double TAX_RATE = 0.08;


        double price;
        double finish;
        double result;
        double addStereo = 0;
        double addLeather = 0;
        double addNav = 0;
        double addExterior = 0;
        double subTotal = 0;
        double tax;
        double tradeInAmount = 0;

        public vehiclePurchase()
        {
            InitializeComponent();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //CLEAR ALL DETAILS

            //boxes
            basePriceTextBox.Clear();
            tradeInTextBox.Clear();
            accessoryResLabel.ResetText();
            amountDueResLabel.ResetText();
            subResLabel.ResetText();
            totalResLabel.ResetText();

            //checkbox
            stereoSystemCheckBox.Checked = false;
            leatherInteriorCheckBox.Checked = false;
            computerNavCheckBox.Checked = false;

            //radio buttons 
            standRadioButton.Checked = false;
            pearlRadioButton.Checked = false;
            customDetRadioButton.Checked = false;
 
            
            
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            price = double.Parse(basePriceTextBox.Text);

            if (price > 0)
            {
                


                if (stereoSystemCheckBox.Checked == true)
                {
                    addStereo = Convert.ToDouble(STEREO_SYSTEM.ToString());
                }
                if (leatherInteriorCheckBox.Checked == true)
                {
                    addLeather = Convert.ToDouble(LEATHER_INTERIOR.ToString());
                }
                if (computerNavCheckBox.Checked == true)
                {
                    addNav = Convert.ToDouble(COMPUTER_NAV.ToString());
                }
                if (standRadioButton.Checked == true)
                {
                    addExterior = Convert.ToDouble(STANDARD.ToString());
                }
                else if (pearlRadioButton.Checked == true)
                {
                    addExterior = Convert.ToDouble(PEARLIZED.ToString());
                }
            
                else if (customDetRadioButton.Checked == true)
                {
                    addExterior = Convert.ToDouble(CUSTOM_DETAIL.ToString());                
                }

                if (tradeInTextBox.Text == "")
                {
                    MessageBox.Show("Enter Trade In Allowance");
                }
                else if (!double.TryParse(tradeInTextBox.Text, out tradeInAmount))
                {
                    MessageBox.Show("Please Enter Valid Trade-In Amount");
                }
                else if (Convert.ToDouble(tradeInTextBox.Text) > Convert.ToDouble(basePriceTextBox.Text) || (Convert.ToDouble(txtTradeInAllowance.Text) < 0))
                {
                    MessageBox.Show("Trade In Allowance must be less than Sales Price and greater than 0");
                }
                else
                {
                    tradeInAmount = 0;
                }

                finish = Convert.ToDouble(addLeather) + Convert.ToDouble(addLeather) + Convert.ToDouble(addNav) + Convert.ToDouble(addStereo);

            price = double.Parse(basePriceTextBox.Text);
                subTotal = finish + Convert.ToDouble(basePriceTextBox.Text) - tradeInAmount;

                tax = (subTotal * TAX_RATE) / 100;
                accessoryResLabel.Text = "$" + finish.ToString();
                subResLabel.Text = tax.ToString();
                result = tax + subTotal;
                totalResLabel.Text = "$" + result.ToString();


            }
            else
            {
                MessageBox.Show("Value must be positive and greater than 0");
            }



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //exit application
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by Paulina Flores.");
        }

    }
}
