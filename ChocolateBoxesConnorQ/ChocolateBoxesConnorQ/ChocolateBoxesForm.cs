/*
 * Created by: Connor Quinlan
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program...
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
                lblPrize.Text = "Prize!";
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
