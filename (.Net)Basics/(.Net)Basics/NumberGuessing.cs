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
    public partial class NumberGuessing : Form
    {
        int num, attempts = 10, answer;
        string result, headerAttempt;

        private void backToMain_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        public NumberGuessing()
        {
            InitializeComponent();
            Random random = new Random();
            num = random.Next(1, 100);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(enteredText.Text, out answer))
            {
                MessageBox.Show("Enter a valid number!");
            }

            if (answer == num)
            {
                result += "Yes correct, You win at round " + attempts; 
            }
            else if(answer > num) 
            {
                result += "Your number too high. You lost 1 live \n";
                attempts--;
            }
            else if (answer < num)
            {
                result += "Your number too low. You lost 1 live \n";
                attempts--;
            }
            if (attempts == 0)
            {
                result += "You have out of lives. you failed.";
                Main main = new Main();
                main.Show();
                this.Close();
            }

            headerAttempt = "Reamaining attempts are: " + attempts + "/10";
            attemptHeader.Text = headerAttempt;
            guessinglbl.Text = result;
        }
    }
}
