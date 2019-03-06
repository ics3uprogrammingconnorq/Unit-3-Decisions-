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
        // Inicialize values
        int number = 0;
        int guessNumber;
        const int MIN = 1;
        const int MAX = 10;
        Random randomNumberGenerator = new Random();

        public frmGuessingGame()
        {
            InitializeComponent();
            // Generate random number
            number = randomNumberGenerator.Next(MIN, MAX);
        }

        private void frmGuessingGame_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            guessNumber = int.Parse(txtInput.Text);
            lblCorrect.Visible = false;
            lblWrong.Visible = false;

            // If they guess correctly
            if (guessNumber == number)
            {
                // Change Image
                this.picCheckX.Image = Properties.Resources.checkmark;
                // Make indicators visible
                picCheckX.Visible = true;
                lblCorrect.Visible = true;
                // Play Sound
                SoundPlayer correct = new SoundPlayer(@"nice-work.wav");
                correct.Play();
            }
            // If they guess incorrectly
            else
            {
                // Change Image
                this.picCheckX.Image = Properties.Resources.red_x;
                // Make indicators visible
                picCheckX.Visible = true;
                lblWrong.Visible = true;
                // Play Sound
                SoundPlayer incorrect = new SoundPlayer(@"maybe-next-time.wav");
                incorrect.Play();
            }

        }
    }
}
