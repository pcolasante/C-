/*Author: Paulina Flores
 * Date:  9/13/20
 * 
 * Objective: A painting company has determined that for every 15 square feet of wall space, 
 * 1 gallon of paint and 8 hours of labor will be required.  The company charges $20.00 per hour for labor.  
 * Create an application that allows the user to enter the square feet of wall space to be painted and the 
 * price of the paint per gallon.  The program should display the following data:
 * The number of gallons of paint required
 * The hour of labor required
 * The cost of the paint
 * The labor charges
 * The total cost of the paint job
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPaintEstimator
{

    public partial class PaintJobEstimator : Form
    {
        const double laborCharge = 20.00; // LABOR CHARGE PER HOUR

        /*public static double PaintRequired(double sqrft)
        {
            double paintNeeded = sqrft / 15; // Minimum sqrft (15)
            return paintNeeded;
        }

        public static double HoursOfLabor(double sqrft, double paintNeeded)
        {
            double totalHours = paintNeeded * 8.00; // 8 hrs per 15sqrft
            return totalHours;
        }

        public static double PaintCost(double paintNeeded, double paintPrice)
        {
            double costOfPaint = paintNeeded * paintPrice; // cost of paint of the project
            return costOfPaint;
        }


        public static double ChargeLabor(double totalHours, double laborCharge)
        {
            double laborFee = totalHours * laborCharge; // multiplication of hours by labor fee
            return laborFee;
        }

        public static double CostTotal(double laborFee, double costOfPaint)
        {
            double total = laborFee + costOfPaint; // total cost of paint and labor
            return total;

        NOTE: SEARCH HOW TO CALL METHODS IN C#
        }*/

        public PaintJobEstimator()
        {
            InitializeComponent();
        }



        private void calculateButton_Click(object sender, EventArgs e)
        {


            double sqrft, paintPrice; //DECLARATION

            Double.TryParse(sqrFtNeededTextBox.Text, out sqrft); //INPUT
            Double.TryParse(paintPriceTextBox.Text, out paintPrice); // INPUT

            double paintNeeded, totalHours; //DECLARATION
            decimal costOfPaint, laborFee, totalCost; //DECLARATION

            //CALCULATIONS
            paintNeeded = sqrft / 15;
            totalHours = paintNeeded * 8.00;
            costOfPaint = (decimal)(paintNeeded * paintPrice);
            laborFee = (decimal)(totalHours * laborCharge);
            totalCost = laborFee + costOfPaint;

            //OUTPUT
            gallonsNeededLabel.Text = paintNeeded.ToString("0.##");
            hoursNeededLabel.Text = totalHours.ToString("0.##");
            costPaintLabel.Text = costOfPaint.ToString("0.##");
            chargesLaborLabel.Text = laborFee.ToString("0.##");
            costTotalLabel.Text = totalCost.ToString("0.##");

        }

        //CLEAR BUTTON
        private void clearButton_Click(object sender, EventArgs e)
        {
            sqrFtNeededTextBox.Clear();
            paintPriceTextBox.Clear();
            gallonsNeededLabel.Text = "";
            hoursNeededLabel.Text = "";
            costPaintLabel.Text = "";
            chargesLaborLabel.Text = "";
            costTotalLabel.Text = "";




        }

        //EXIT BUTTON
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
