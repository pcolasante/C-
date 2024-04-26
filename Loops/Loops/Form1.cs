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

namespace Loops
{
    public partial class randomNumberFileMaker : Form
    {
        public randomNumberFileMaker()
        {
            InitializeComponent();
        }

        //BUTTON
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            //VARIABLES
            Random random = new Random();
            int randomNum = 0;
            int number = Convert.ToInt32(randomInputTextBox.Text.Trim());

            //SAVE FILE
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.ShowDialog();

            string filePath = saveFile.FileName;

            //CREATE FILE
            StreamWriter outputFile = File.CreateText(filePath);

            //RANDOM NUM
            while (number > 0)
            {
                randomNum = random.Next(1, 100);

                outputFile.WriteLine(randomNum.ToString());
                number--;
            }

            //CLOSE FILE
            outputFile.Close();

            //LOCATION OF FILE
            MessageBox.Show("Location of File: " + filePath);
            
        }

    }
}
