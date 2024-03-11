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
    public partial class NumberGuesser : Form
    {
        public NumberGuesser()
        {
            InitializeComponent();
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int num = 0, guessedNum = 0;
            string guessingLabel = " ";
            Random random = new Random();

            if (!int.TryParse(guessText.Text, out num))
            {
                MessageBox.Show("Enter valid number.");
            }

            if (num < 0 || num > 100)
            {
                MessageBox.Show("Please pick number between [0-99]");
            }


            do
            {
                guessedNum = random.Next(0, 100);
                guessingLabel += guessedNum.ToString() + " -" + "oops" + "-> ";
                guessinglbl.Text = guessingLabel;

            } while (guessedNum != num);

            guessingLabel += guessedNum.ToString() + " I did it.";
            guessinglbl.Text = guessingLabel;
        }
    }
}
