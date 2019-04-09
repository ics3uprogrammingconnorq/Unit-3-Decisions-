/*
 * Created by: Connor Quinlan
 * Created on: 05-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program converts every letter of the alphabet to Unicode when the start button is pressed.
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

namespace UnicodeConnorQ
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            string text;
            int counter;

            // clear the items in the list box
            lstUnicode.Items.Clear();

            for ( counter = 65; counter <= 90; counter++ )
            {
                // convert counter from Unicode to a letter
                text = Char.ConvertFromUtf32(counter);

                // Add letter and number to list box
                lstUnicode.Items.Add(text + " -> " + counter);
            }
        }
    }
}
