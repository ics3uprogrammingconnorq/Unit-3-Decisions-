using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsConnorQ
{
    public partial class frmRockPaperScissors : Form
    {

        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;

        Random randomNumberGenerator;

        int userOption, computerOption;

        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            randomNumberGenerator = new Random();
        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (radUserRock.Checked)
            {
                userOption = 1;
            }
            else if (radUserPaper.Checked)
            {
                userOption = 2;
            }
            else if (radUserScissors.Checked)
            {
                userOption = 3;
            }
        }
    }
}
