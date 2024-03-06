using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _.Net_Basics
{
    public partial class MathOp : Form
    {

        int pCount = 0, cCount = 0, wCount = 0;
        int num1, num2, answer;
        int playerAns;
        string question;
        string lblplay;
        string lblCorrect;


        public MathOp()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            num1 = random.Next(1, 100);
            num2 = random.Next(1, 100);
            answer = num1 + num2;
            questionlbl.Text = num1.ToString() + " + " + num2.ToString();
            startButton.Text = "Take another question";

            pCount++;
            playCount.Text = "No. of Play: " + pCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
        private void checkButton_Click_1(object sender, EventArgs e)
        {

            if (!int.TryParse(answerText.Text, out playerAns))
            {
                MessageBox.Show("Please enter a valid number.");
                answerText.Focus();
                answerText.SelectAll();
                return;
            }

            if (playerAns < 0 || playerAns > 1000)
            {
                MessageBox.Show("The number must be range [1-999]");
                answerText.Focus();
                answerText.SelectAll();
                return;
            }

            if (playerAns == answer)
            {
                cCount++;
                correctCount.Text = "Correct: " + cCount.ToString();
                resultFalse.Visible = false;
                resultCorrect.Visible = true;

            }
            else
            {
                wCount++;
                wrongCount.Text = "Wrong: " + wCount.ToString();
                resultCorrect.Visible = false;
                resultFalse.Visible = true;
            }
        }
    }
}
