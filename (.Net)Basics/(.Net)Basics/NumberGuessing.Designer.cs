namespace _.Net_Basics
{
    partial class NumberGuessing
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
            this.guessinglbl = new System.Windows.Forms.Label();
            this.enteredText = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.backToMain = new System.Windows.Forms.Button();
            this.attemptHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessinglbl
            // 
            this.guessinglbl.AutoSize = true;
            this.guessinglbl.Location = new System.Drawing.Point(113, 175);
            this.guessinglbl.MaximumSize = new System.Drawing.Size(400, 0);
            this.guessinglbl.Name = "guessinglbl";
            this.guessinglbl.Size = new System.Drawing.Size(93, 13);
            this.guessinglbl.TabIndex = 14;
            this.guessinglbl.Text = "Enter your number";
            // 
            // enteredText
            // 
            this.enteredText.Location = new System.Drawing.Point(571, 89);
            this.enteredText.Name = "enteredText";
            this.enteredText.Size = new System.Drawing.Size(100, 20);
            this.enteredText.TabIndex = 13;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(631, 115);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(40, 23);
            this.guessButton.TabIndex = 12;
            this.guessButton.Text = "OK";
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
            this.header.Size = new System.Drawing.Size(220, 31);
            this.header.TabIndex = 10;
            this.header.Text = "Number Guesser";
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
            // attemptHeader
            // 
            this.attemptHeader.AutoSize = true;
            this.attemptHeader.Location = new System.Drawing.Point(508, 57);
            this.attemptHeader.Name = "attemptHeader";
            this.attemptHeader.Size = new System.Drawing.Size(136, 13);
            this.attemptHeader.TabIndex = 15;
            this.attemptHeader.Text = "Remaining attempts are: 10";
            // 
            // NumberGuessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.attemptHeader);
            this.Controls.Add(this.guessinglbl);
            this.Controls.Add(this.enteredText);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.header);
            this.Controls.Add(this.backToMain);
            this.Name = "NumberGuessing";
            this.Text = "NumberGuessing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guessinglbl;
        private System.Windows.Forms.TextBox enteredText;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button backToMain;
        private System.Windows.Forms.Label attemptHeader;
    }
}