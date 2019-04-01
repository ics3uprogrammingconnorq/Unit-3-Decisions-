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
                    Thread.Sleep(200);
                    aControlObject.BackColor = Color.Orange;
                }
            }
        }
    }
}
