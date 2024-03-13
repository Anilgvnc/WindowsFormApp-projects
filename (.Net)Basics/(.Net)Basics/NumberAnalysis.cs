using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _.Net_Basics
{
    public partial class NumberAnalysis : Form
    {
        Random random = new Random();

        public NumberAnalysis()
        {
            InitializeComponent();
            GeneratedNumberAnalysis();
        }

        private void enteredButton_Click(object sender, EventArgs e)
        {
            string answer = " ";
            long num = 0;

            if (!long.TryParse(numText.Text, out num))
            {
                MessageBox.Show("Enter valid number");
                return;
            }

            //Even or Odd
            answer += IsEven(num);

            //is it prime
            answer += NumberIsPrime(num);

            if (num % 7 == 0 && num % 3 != 0)
            {
                answer += " This number can divide 7 but cannot divide 3.";
            }

            //Calculate Digit
            answer += " This number have " + Digit(num) + " digit.";

            //Reversed Number
            answer += " Reversed number is " + ReversedNumber(num);

            numlbl.Text = answer;
        }

        public string NumberIsPrime(long num)
        {
            bool isPrime = false;
            string answer;
            if (num == 0 || num == 1)
            {
                isPrime = true;
            }
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = true;
                    break;
                }
            }

            if (isPrime == true)
            {
                answer = " and not a prime number.";
            }
            else
            {
                answer = " and prime number.";
            }
            return answer;
        }

        public string IsEven(long number)
        {
            string answer;
            if (number % 2 == 0)
            {
                answer = "Even";
            }
            else
            {
                answer = "Odd";
            }
            return answer;
        }
        public long Digit(long number)
        {
            int count = 0;
            while (number % 10 >= 1)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        public long ReversedNumber(long number)
        {
            long reversedNum = 0;
            while (number > 0)
            {
                reversedNum = reversedNum * 10 + number % 10;
                number /= 10;
            }
            return reversedNum;
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void findLargestbutton_Click(object sender, EventArgs e)
        {
            long num1, num2, num3;
            string answerL = " ";

            if (!long.TryParse(num1Text.Text, out num1))
            {
                MessageBox.Show("Please enter valid numbers.");
            }

            if (!long.TryParse(num2Text.Text, out num2))
            {
                MessageBox.Show("Please enter valid numbers.");
            }

            if (!long.TryParse(num3Text.Text, out num3))
            {
                MessageBox.Show("Please enter valid numbers.");
            }

            if (num1 > num2 && num1 > num3)
            {
                answerL = num1.ToString();
            }
            else if (num2 > num1 && num2 > num3)
            {
                answerL = num2.ToString();
            }
            else
            {
                answerL = num3.ToString();
            }


            answerL += " is the largest number.";
            largestNumAnswer.Text = answerL;
        }
        private void GeneratedNumberAnalysis()
        {
            int[] arr = new int[3];
            int max = 0, min = 0;
            string answer = "Generated numbers are: ";

            for (int i = 0; i < 3; i++)
            {
                arr[i] = random.Next(0, 1000);
                answer += arr[i] + ", ";
            }

            answer += "\nMaximum number: " + arr.Max() + "\nMinimum number: " + arr.Min();
            answerGeneratingNumberAnalysis.Text = answer;
        }

    }
}
