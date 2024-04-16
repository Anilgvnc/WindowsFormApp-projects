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
    public partial class MessageSender : Form
    {
        public string fname { get; set; }
        public string mail { get; set; }
        public string message { get; set; }
        public MessageSender()
        {
            InitializeComponent();
        }

        private void MessageSender_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            mailTextBox.Text = "";
            messageTextBox.Text = "";

            date.Text = string.Empty;
            lastMessagelbl.Text = string.Empty;

            timer.Start();
        }


        private void signButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text.Trim()))
                {
                    throw new Exception("Please enter your full name");
                }
                if (nameTextBox.Text.Trim().Split(' ').Length < 2)
                {
                    throw new Exception("Please enter your name and surname");
                }
                if (string.IsNullOrEmpty(mailTextBox.Text.Trim()))
                {
                    throw new Exception("Please enter your email");
                }
                if (mailTextBox.Text.Trim().Split('@').Length < 2)
                {
                    throw new Exception("Please enter a valid email");
                }

                this.fname = nameTextBox.Text.Trim();
                this.mail = mailTextBox.Text.Trim();

                MessageBox.Show("Sign up successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(messageTextBox.Text.Trim()))
                {
                    throw new Exception("Please enter valid message");
                }
                if (string.IsNullOrEmpty(this.fname) || string.IsNullOrEmpty(this.mail))
                {
                    throw new Exception("Please sign up to send message");
                }

                this.message = messageTextBox.Text.Trim();

                secondTimer.Start();
                MessageBox.Show("Message sent successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getLastMessage_Click(object sender, EventArgs e)
        {
            displayLastMessage();
        }

        public void displayLastMessage()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Your Name: " + this.fname);
            builder.AppendLine("Email    : " + this.mail);
            builder.AppendLine("Message  : " + this.message);

            lastMessagelbl.Text = builder.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            mailTextBox.Text = "";
            messageTextBox.Text = "";

            date.Text = string.Empty;
            lastMessagelbl.Text = string.Empty;

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            displayTheTime();
        }

        private void displayTheTime()
        {
            date.Text = DateTime.Now.ToString();
        }

        private void secondTimer_Tick(object sender, EventArgs e)
        {
            displayLastMessage();
            secondTimer.Stop();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
        }
    }
}
