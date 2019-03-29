/*
 * Created by: Connor Quinlan
 * Created on: 28-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares
 * This program calculates all perfect squares up to a given value.
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
using System.Threading;

namespace PerfectSquaresConnorQ
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            // set the initial values
            value = 1;

            // clear all items from the list box
            lstOutput.Items.Clear();

            // get the user's end value selection from the number up-down box
            endingValue = Convert.ToInt32(this.nudInput.Value);

            // continue starting any perfect squares between the minimum value and the user's selected end value
            while (value <= endingValue)
            {
                // take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // the only way for both the decimal and the integer to be equal is if the value was a perfect square
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstOutput.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }

                // increament counter
                value++;

            }
        }
    }
}
