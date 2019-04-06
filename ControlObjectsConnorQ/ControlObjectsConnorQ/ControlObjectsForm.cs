/*
 * Created by: Connor Quinlan
 * Created on: 04-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #25 - Control Objects
 * This program changes the colours of objects.
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

namespace ControlObjectsConnorQ
{
    public partial class frmControlObjects : Form
    {
        public frmControlObjects()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Blue;

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Orange;
                }
            }
        }
    }
}
