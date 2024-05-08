namespace howto_binary_tree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericDepth = new System.Windows.Forms.NumericUpDown();
            this.numericLength = new System.Windows.Forms.NumericUpDown();
            this.numericTheta = new System.Windows.Forms.NumericUpDown();
            this.txtLengthScale = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTheta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(155, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 425);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Depth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length Scale:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "D Theta";
            // 
            // numericDepth
            // 
            this.numericDepth.Location = new System.Drawing.Point(101, 15);
            this.numericDepth.Name = "numericDepth";
            this.numericDepth.Size = new System.Drawing.Size(48, 20);
            this.numericDepth.TabIndex = 5;
            this.numericDepth.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericDepth.ValueChanged += new System.EventHandler(this.numericDepth_ValueChanged);
            // 
            // numericLength
            // 
            this.numericLength.Location = new System.Drawing.Point(101, 48);
            this.numericLength.Name = "numericLength";
            this.numericLength.Size = new System.Drawing.Size(48, 20);
            this.numericLength.TabIndex = 6;
            this.numericLength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericLength.ValueChanged += new System.EventHandler(this.numericLength_ValueChanged);
            // 
            // numericTheta
            // 
            this.numericTheta.Location = new System.Drawing.Point(101, 114);
            this.numericTheta.Name = "numericTheta";
            this.numericTheta.Size = new System.Drawing.Size(48, 20);
            this.numericTheta.TabIndex = 8;
            this.numericTheta.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericTheta.ValueChanged += new System.EventHandler(this.numericTheta_ValueChanged);
            // 
            // txtLengthScale
            // 
            this.txtLengthScale.Location = new System.Drawing.Point(101, 84);
            this.txtLengthScale.Name = "txtLengthScale";
            this.txtLengthScale.Size = new System.Drawing.Size(48, 20);
            this.txtLengthScale.TabIndex = 9;
            this.txtLengthScale.Text = "0.75";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.txtLengthScale);
            this.Controls.Add(this.numericTheta);
            this.Controls.Add(this.numericLength);
            this.Controls.Add(this.numericDepth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTheta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericDepth;
        private System.Windows.Forms.NumericUpDown numericLength;
        private System.Windows.Forms.NumericUpDown numericTheta;
        private System.Windows.Forms.TextBox txtLengthScale;
    }
}

