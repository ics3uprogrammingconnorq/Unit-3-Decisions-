/*
 * Created by: Connor Quinlan
 * Created on: 25-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program allows the user to play rock paper scissors with the computer.
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

namespace RockPaperScissorsConnorQ
{
    public partial class frmRockPaperScissors : Form
    {

        // Setting main and max constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;

        // Creating random object
        Random randomNumberGenerator;

        // Declairing user and computer options
        int userOption, computerOption;

        // String used to display result of the round
        string result;

        // Setting constants for the different options
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
            // Set user option
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

            // Generate computer option
            computerOption = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE+1);

            // Calculate winner
            if (userOption == ROCK)
            {
                if (computerOption == ROCK)
                {
                    radComputerRock.Checked = true;
                    result = "tie";
                }
                else if (computerOption == PAPER)
                {
                    radComputerPaper.Checked = true;
                    result = "lose";
                }
                else if (computerOption == SCISSORS)
                {
                    radComputerScissors.Checked = true;
                    result = "win";
                }
            }
            else if (userOption == PAPER)
            {
                if (computerOption == ROCK)
                {
                    radComputerRock.Checked = true;
                    result = "win";
                }
                else if (computerOption == PAPER)
                {
                    radComputerPaper.Checked = true;
                    result = "tie";
                }
                else if (computerOption == SCISSORS)
                {
                    radComputerScissors.Checked = true;
                    result = "lose";
                }
            }
            else if (userOption == SCISSORS)
            {
                if (computerOption == ROCK)
                {
                    radComputerRock.Checked = true;
                    result = "lose";
                }
                else if (computerOption == PAPER)
                {
                    radComputerPaper.Checked = true;
                    result = "win";
                }
                else if (computerOption == SCISSORS)
                {
                    radComputerScissors.Checked = true;
                    result = "tie";
                }
            }

            if (result == "win")
            {
                lblResult.Text = "You won!";
            }
            else if (result == "lose")
            {
                lblResult.Text = "You lost";
            }
            else if (result == "tie")
            {
                lblResult.Text = "It's a tie";
            }
        }
    }
}
