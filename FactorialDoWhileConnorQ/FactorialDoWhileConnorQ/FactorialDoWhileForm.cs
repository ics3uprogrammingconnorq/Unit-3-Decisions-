/*
 * Created by: Connor Quinlan
 * Created on: 27-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program finds the factorial of given number.
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

namespace FactorialDoWhileConnorQ
{
    public partial class frmFactorialDoWhile : Form
    {
        public frmFactorialDoWhile()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from listbox
            this.lstOutput.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtInput.Text);

            factorialCounter = 0;

            // multiply the counter by the next incremented number until it reaches the user's number
            do
            {

                // increment the counter by 1
                factorialCounter++;

                // list the counter number in the listbox for the user to see
                lstOutput.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;

            } while (factorialCounter < factorialNumber);

            // convert the factorialAnswer to a String and insert it into the label
            this.lblFactorialAnswer.Text = this.txtInput.Text + "! = " + Convert.ToString(factorialAnswer);
        }
    }
}
