using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _.Net_Basics
{
    public partial class Craps : Form
    {
        Random random = new Random();
        string answer;
        int firstDice, secondDice, firstDiceResult, secondDiceResult;

        public enum crapsRule
        {
            Continue,
            Win,
            Lose
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        public Craps()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            answer = " ";

            firstDice = random.Next(1, 7);
            secondDice = random.Next(1, 7);
            firstDiceResult = firstDice + secondDice;
            answer += "FirstDices are: " + firstDice.ToString() + " + " + secondDice.ToString() + "\n";

            do
            {
                firstDice = random.Next(1, 7);
                secondDice = random.Next(1, 7);
                secondDiceResult = firstDice + secondDice;

                if (firstDiceResult == 7 || firstDiceResult == 11)
                {
                    answer += "You win";
                    break;
                }
                else if (firstDiceResult == 2 || firstDiceResult == 3 || firstDiceResult == 12)
                {
                    answer += "Craps! You lose";
                    break;
                }
                else if (secondDice == 7)
                {
                    answer += secondDice + "You lose!";
                    break;
                }
                else if (secondDice == firstDice)
                {
                    answer += secondDice + "You win";
                    break ;
                }


            } while (secondDiceResult != 7);


            dicelbl.Text = answer;
        }
    }
}
