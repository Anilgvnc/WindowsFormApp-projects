using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"c:\";
            openFileDialog.Filter = "Image Files (png)|*.png|Image File (jpg)|*.jpg|All files |*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            DialogResult openResult = openFileDialog.ShowDialog();
            if (openResult == DialogResult.Cancel)
            {
                MessageBox.Show("User cancelled.");
                return;
            }

            lblImg.Text = openFileDialog.FileName;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            lblColor.BackColor = dialog.Color;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = lblImg.Text;

            lblMessage.Text = richTextBox.Text;
            lblMessage.Font = new Font(comboBox.Text, (int)numericUpDown.Value);
            lblMessage.ForeColor = lblColor.BackColor;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message Send.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily family in FontFamily.Families)
            {
                comboBox.Items.Add(family.Name);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex== -1)
            {
                return;
            }

            string familyName = comboBox.Text;
            lblMessage.Font = new Font(familyName, 12);
        }
    }
}
