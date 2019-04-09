/*
 * Created by: Connor Quinlan
 * Created on: 09-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Running Average
 * This program calculates the running average of continuous number inputs.
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

namespace RunningAverageConnorQ
{
    public partial class frmRunningAverage : Form
    {
        // declare global variables
        int numberOfNumbers = 0;
        double total = 0;
        double nextNumber;
        double runningAverage;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            nextNumber = double.Parse(txtInput.Text);

            if (nextNumber == -1)
            {
                // display finished message box
                MessageBox.Show("The running average is over", "Complete");
            }
            else if (nextNumber >= 0 && nextNumber <= 100)
            {
                // add to total
                total += nextNumber;

                // increament the number of numbers
                numberOfNumbers++;

                // calculate new average
                runningAverage = total / numberOfNumbers;

                // display average
                lblAverageNumber.Text = Convert.ToString(runningAverage);
            }
        }
    }
}
