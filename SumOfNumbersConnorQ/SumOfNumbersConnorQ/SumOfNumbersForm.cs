/*
 * Created by: Connor Quinlan
 * Created on: 28-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Sum of Numbers
 * This program the calculates the sum of numbers up to a value.
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

namespace SumOfNumbersConnorQ
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
        }

        private void frmSumOfNumbers_Load(object sender, EventArgs e)
        {
        
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            Double sumAnswer;
            Double sumNumber;
            int counter;

            // clear the items from the listbox
            this.lstNumbers.Items.Clear();

            // initialize the final answer to 1
            sumAnswer = 1;

            // get the number from the user
            sumNumber = Convert.ToDouble(this.txtInput.Text);

            for (counter = 1; counter <= sumNumber; counter++)
            {
                // list the counter number in the listbox for the user to see
                this.lstNumbers.Items.Add(counter);

                // add the counter to the answer
                sumAnswer = sumAnswer + counter;
            }

            // convert the sumAnswer to a string and insert it in the label to display the answer
            lblAnswer.Text = "The sum of numbers up to " + this.txtInput.Text + " is " + Convert.ToString(sumAnswer - 1);
        }
    }
}
