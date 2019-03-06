/*
 * Created by: Connor Quinlan
 * Created on: 27-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Number Guessing Game
 * This program asks the user to guess my secret number, if the user gets it right it shows the user a check mark and a ding sound, if they get it wrong it shows them an x and makes a dong sound.
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
using System.Media;

namespace GuessingGameConnorQ
{
    public partial class frmGuessingGame : Form
    {

        const int NUMBER = 4;
        int guessNumber;
        SoundPlayer correct;

        public frmGuessingGame()
        {
            InitializeComponent();
        }

        private void frmGuessingGame_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            guessNumber = int.Parse(txtInput.Text);
            lblCorrect.Visible = false;
            lblWrong.Visible = false;

            if (guessNumber == NUMBER)
            {
                this.picCheckX.Image = Properties.Resources.checkmark;
                picCheckX.Visible = true;
                lblCorrect.Visible = true;
                correct.SoundLocation = "N:/StuShare/Semester 2 - Winter 2019/ICS3U Programming/Quinlan, Connor (s280204)/Unit 3 (Decisions)/GuessingGameConnorQ/Sounds/Correct Answer Sound Effect.mp3";
                correct.Play();
            }
            else
            {
                this.picCheckX.Image = Properties.Resources.red_x;
                picCheckX.Visible = true;
                lblWrong.Visible = true;
            }

        }
    }
}
