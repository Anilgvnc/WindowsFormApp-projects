namespace _.Net_Basics
{
    partial class Craps
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
            this.dicelbl = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.backToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dicelbl
            // 
            this.dicelbl.AutoSize = true;
            this.dicelbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dicelbl.Location = new System.Drawing.Point(113, 175);
            this.dicelbl.MaximumSize = new System.Drawing.Size(400, 0);
            this.dicelbl.Name = "dicelbl";
            this.dicelbl.Size = new System.Drawing.Size(57, 13);
            this.dicelbl.TabIndex = 14;
            this.dicelbl.Text = "Roll a dice";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(496, 86);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(46, 23);
            this.guessButton.TabIndex = 12;
            this.guessButton.Text = "Roll";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(110, 57);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(270, 52);
            this.desc.TabIndex = 11;
            this.desc.Text = "Description\r\n\r\n1- Computer selects one of the 4 operations.\r\n2- Computer generate" +
    "s 2 numbers between 10 and 100.";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.header.Location = new System.Drawing.Point(107, 12);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(167, 31);
            this.header.TabIndex = 10;
            this.header.Text = "Craps Game";
            // 
            // backToMain
            // 
            this.backToMain.Location = new System.Drawing.Point(12, 12);
            this.backToMain.Name = "backToMain";
            this.backToMain.Size = new System.Drawing.Size(22, 23);
            this.backToMain.TabIndex = 9;
            this.backToMain.Text = "<";
            this.backToMain.UseVisualStyleBackColor = true;
            this.backToMain.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dicelbl);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.header);
            this.Controls.Add(this.backToMain);
            this.Name = "Craps";
            this.Text = "Craps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dicelbl;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button backToMain;
    }
}