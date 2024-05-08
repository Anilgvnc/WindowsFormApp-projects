using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace howto_binary_tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawBranch(Graphics g, Pen pen, int depth, float x, float y, float length, float theta, float length_scale, float dtheta)
        {
            float x1 = (float)(x + length * Math.Cos(theta));
            float y1 = (float)(y + length * Math.Sin(theta));

            g.DrawLine(pen, x, y, x1, y1);

            if (depth > 1)
            {
                DrawBranch(g, pen, depth - 1, x1, y1, length * length_scale, theta + dtheta, length_scale, dtheta);
                DrawBranch(g, pen, depth - 1, x1, y1, length * length_scale, theta - dtheta, length_scale, dtheta);
            }
        }

        private void LoadDraw()
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            DrawBranch(g, Pens.Green, Convert.ToInt32(numericDepth.Value), 242, 420, (float)numericLength.Value, (float)Math.PI / 2, float.Parse(txtLengthScale.Text), (float)numericTheta.Value);

        }

        private void numericDepth_ValueChanged(object sender, EventArgs e)
        {
            LoadDraw();
        }

        private void numericLength_ValueChanged(object sender, EventArgs e)
        {
            LoadDraw();
        }

        private void numericTheta_ValueChanged(object sender, EventArgs e)
        {
            LoadDraw();
        }
    }
}
