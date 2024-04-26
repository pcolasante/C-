using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Making_Decisions
{
    public partial class WorkshopSelector : Form
    {
        public WorkshopSelector()
        {
            InitializeComponent();
        }






        // BUTTON
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //VARIABLES
            int numberDays = 0;
            int registrationFee = 0;
            int lodgingFee = 0;

            //WORKSHOP

            if (workshopListBox.SelectedItem.ToString() == "Handling Stress")
            {
                numberDays = 3;
                registrationFee = 1000;
            }
            else if (workshopListBox.SelectedItem.ToString() == "Time Management")
            {
                numberDays = 3;
                registrationFee = 800;
            }
            else if (workshopListBox.SelectedItem.ToString() == "Supervision Skills")
            {
                numberDays = 3;
                registrationFee = 1500;

            }
            else if (workshopListBox.SelectedItem.ToString() == "Negotiation")
            {
                numberDays = 5;
                registrationFee = 1300;
            }

            else if (workshopListBox.SelectedItem.ToString() == "How to Interview")
            {
                numberDays = 1;
                registrationFee = 500;
            }

            //LOCATION
            if (locationListBox.SelectedItem.ToString() == "Austin")
            {
                lodgingFee = 150;
            }

            else if (locationListBox.SelectedItem.ToString() == "Chicago")
            {
                lodgingFee = 225;

            }

            else if (locationListBox.SelectedItem.ToString() == "Dallas")
            {
                lodgingFee = 175;

            }

            else if (locationListBox.SelectedItem.ToString() == "Orlando")
            {
                lodgingFee = 300;
            }

            else if (locationListBox.SelectedItem.ToString() == "Phoenix")
            {
                lodgingFee = 175;
            }

            else if (locationListBox.SelectedItem.ToString() == "Raleigh")
            {
                lodgingFee = 150;
            }

            //CALCULATE

            //TOTAL

            int total = registrationFee + (lodgingFee * numberDays);

            // DISPLAY

            registrationResultLabel.Text = registrationFee.ToString("C0");

            lodgingResultLabel.Text = (lodgingFee.ToString("c0") + " * " + numberDays + " days = " + (lodgingFee * numberDays).ToString("c0")).ToString();

            totalResultLabel.Text = total.ToString("c0");

        }
    }
}
