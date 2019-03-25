/*
 * Created by: Connor Quinlan
 * Created on: 19-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program takes the amount of boxes sold by the user and gives them a prize based on the that number.
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

namespace ChocolateBoxesConnorQ
{
    public partial class frmChocolateBoxes : Form
    {

        int boxesSold;

        public frmChocolateBoxes()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            boxesSold = int.Parse(txtInput.Text);

            if (boxesSold > 20)
            {
                lblPrize.Text = "Grand Prize!";
            }
            else
            {
                if (boxesSold > 10)
                {
                    lblPrize.Text = "Honorable Mention";
                }
                else
                {
                    lblPrize.Text = "Small Prize";
                }
            }
        }
    }
}
