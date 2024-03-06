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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void redirectToMathOp_Click(object sender, EventArgs e)
        {
            MathOp mathOp = new MathOp();
            mathOp.Show();
            this.Hide();
        }
    }
}
