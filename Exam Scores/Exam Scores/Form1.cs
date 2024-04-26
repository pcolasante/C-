//Author: Paulina Flores
//Date: 10/17/20


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Exam_Scores
{
    public partial class examScore : Form
    {
        public examScore()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e) { 

            //READ FILES
            StreamReader inputFileSection1 = File.OpenText("Section1.txt");
            StreamReader inputFileSection2 = File.OpenText("Section2.txt");
            StreamReader inputFileSection3 = File.OpenText("Section3.txt");

            //CREATE ARRAYS
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[12];
            jaggedArray[1] = new int[8];
            jaggedArray[2] = new int[10];

            //CREATE VARIABLES
            int avgS1 = 0;
            int avgS2 = 0;
            int avgS3 = 0;
            int total = 0;
            int avgSections = 0;
            int highestScore = 0;
            int lowestScore = 0;

            int highestSection = 0;
            int lowestSection = 0;

            string value;
            int i = 0;
            // ------------------ SECTION 1 ---------------------------
            //ADD SCORES FROM FILE 1
            while ((value = inputFileSection1.ReadLine()) != null)
            {
                jaggedArray[0][i] = Convert.ToInt32(value);
                section1ListBox.Items.Add(jaggedArray[0][i]);

                avgS1 += jaggedArray[0][i];

                i++;
            }

            // AVERAGE SECTION 1
            total += avgS1;

            avgS1 = avgS1 / jaggedArray[0].Count();

            resultAvgS1Label.Text = avgS1.ToString();

            i = 0;

            // ------------------ SECTION 2 ---------------------------
            //ADD SCORES FROM FILE 2
            while ((value = inputFileSection2.ReadLine()) != null)
            {
                jaggedArray[1][i] = Convert.ToInt32(value);
                section2ListBox.Items.Add(jaggedArray[1][i]);
                avgS2 += jaggedArray[1][i];

                i++;
            }

            // AVERAGE SECTION 2
            total += avgS2;

            avgS2 = avgS2 / jaggedArray[1].Count();

            resultAvgS2Label.Text = avgS2.ToString();

            i = 0;


            // ------------------ SECTION 3 ---------------------------
            //ADD SCORES FROM FILE 3
            while ((value = inputFileSection3.ReadLine()) != null)
            {
                jaggedArray[2][i] = Convert.ToInt32(value);
                section3ListBox.Items.Add(jaggedArray[2][i]);
                avgS3 += jaggedArray[2][i];

                i++;
            }

            // AVERAGE SECTION 3
            total += avgS3;

            avgS3 = avgS3 / jaggedArray[2].Count();

            resultAvgS3Label.Text = avgS3.ToString();


            // ----------------- AVERAGE TOTAL -----------------

            avgSections = total / (jaggedArray[0].Count() + jaggedArray[1].Count() + jaggedArray[2].Count());

            resultAvgAllSectionsLabel.Text = avgSections.ToString();


            // --------------- HIGHEST SCORE ----------------------

            if (jaggedArray[0].Max() > jaggedArray[1].Max() && jaggedArray[0].Max() > jaggedArray[2].Max())
            {
                highestScore = jaggedArray[0].Max();
                highestSection = 1;
            }

            else if (jaggedArray[1].Max() > jaggedArray[2].Max())
            {
                highestScore = jaggedArray[1].Max();
                highestSection = 2;
            }
            else
            {
                highestScore = jaggedArray[2].Max();
                highestSection = 3;
            }

            // -------------- LOWEST SCORE ------------------------

            if (jaggedArray[0].Min() < jaggedArray[1].Min() && jaggedArray[0].Min() < jaggedArray[2].Min())
            {
                lowestScore = jaggedArray[0].Min();
                lowestSection = 1;
            }

            else if (jaggedArray[1].Min() < jaggedArray[2].Min())
            {
                lowestScore = jaggedArray[1].Min();
                lowestSection = 2;
            }

            else
            {
                lowestScore = jaggedArray[2].Min();
                lowestSection = 3;
            }

            //OUTPUT

            resultHighestAllSectionsLabel.Text = highestScore + " from Section " + highestSection;
            resultLowestAllSectionsLabel.Text = lowestScore + " from Section " + lowestSection;


        }


    }
}
