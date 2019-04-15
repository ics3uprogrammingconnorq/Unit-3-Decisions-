/*
 * Created by: Connor Quinlan
 * Created on: April 4th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #26 - Nested Loops
 * This program uses nested loops to convert capital letters to lowercase.
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

namespace NestedLoopsConnorQ
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declare my variables
            string capital;
            string lowercase;

            int counter1;
            int counter2;

            //Clears items in the listbox
            lstOutput.Items.Clear();

            for (counter1 = 65; counter1 <= 90; counter1++)
            {
                //Convert counter to its capital letter in unicode
                capital = Char.ConvertFromUtf32(counter1);

                for (counter2 = 97; counter2 <= 122; counter2++)
                {
                    //Convert counter to its lowercase letter in unicode
                    lowercase = Char.ConvertFromUtf32(counter2);

                    //Displays the converted letters in the listbox
                    lstOutput.Items.Add(capital + "-> " + lowercase);
                }
            }
        }
    }
}
