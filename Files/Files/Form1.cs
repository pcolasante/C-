using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files
{
    public partial class RandomNumberFileReader : Form
    {
        public RandomNumberFileReader()
        {
            InitializeComponent();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            // VARIABLES
            int count = 0;
            int numbers = 0;
            int totalNum = 0;

            //OPEN DIALOG
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            //OPEN FILE
            string filePath = openFileDialog.FileName;

            StreamReader inputFile = new StreamReader(filePath);

            //CLEAN BEFORE WE START
            RandoList.Items.Clear();

            //LOOP
            while (!inputFile.EndOfStream)
            {
                numbers = Convert.ToInt32(inputFile.ReadLine());

                totalNum = totalNum + numbers;

                RandoList.Items.Add(numbers.ToString());

                count++;


            }

            //DISPLAY
            totalNumbersLabel.Text = totalNum.ToString();
            numbersReadResultLabel.Text = count.ToString();
        }
    }
}
