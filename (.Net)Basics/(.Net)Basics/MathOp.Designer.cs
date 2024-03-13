namespace _.Net_Basics
{
    partial class MathOp
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
            this.button1 = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.questionlbl = new System.Windows.Forms.Label();
            this.answerText = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.resultCorrect = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.GroupBox();
            this.wrongCount = new System.Windows.Forms.Label();
            this.correctCount = new System.Windows.Forms.Label();
            this.playCount = new System.Windows.Forms.Label();
            this.resultFalse = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.score.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.header.Location = new System.Drawing.Point(89, 22);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(214, 31);
            this.header.TabIndex = 1;
            this.header.Text = "Math Operations";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(92, 67);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(270, 52);
            this.desc.TabIndex = 2;
            this.desc.Text = "Description\r\n\r\n1- Computer selects one of the 4 operations.\r\n2- Computer generate" +
    "s 2 numbers between 10 and 100.";
            // 
            // questionlbl
            // 
            this.questionlbl.AutoSize = true;
            this.questionlbl.Location = new System.Drawing.Point(92, 227);
            this.questionlbl.Name = "questionlbl";
            this.questionlbl.Size = new System.Drawing.Size(49, 13);
            this.questionlbl.TabIndex = 3;
            this.questionlbl.Text = "Question";
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(219, 224);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(129, 20);
            this.answerText.TabIndex = 4;
            this.answerText.Text = "Enter your answer";
            this.answerText.TextChanged += new System.EventHandler(this.answerText_TextChanged);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(354, 222);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click_1);
            // 
            // resultCorrect
            // 
            this.resultCorrect.AutoSize = true;
            this.resultCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultCorrect.ForeColor = System.Drawing.Color.LawnGreen;
            this.resultCorrect.Location = new System.Drawing.Point(92, 293);
            this.resultCorrect.Name = "resultCorrect";
            this.resultCorrect.Size = new System.Drawing.Size(111, 33);
            this.resultCorrect.TabIndex = 6;
            this.resultCorrect.Text = "Correct";
            this.resultCorrect.Visible = false;
            // 
            // score
            // 
            this.score.Controls.Add(this.wrongCount);
            this.score.Controls.Add(this.correctCount);
            this.score.Controls.Add(this.playCount);
            this.score.Location = new System.Drawing.Point(562, 22);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(200, 100);
            this.score.TabIndex = 7;
            this.score.TabStop = false;
            this.score.Text = "Score";
            // 
            // wrongCount
            // 
            this.wrongCount.AutoSize = true;
            this.wrongCount.Location = new System.Drawing.Point(22, 71);
            this.wrongCount.Name = "wrongCount";
            this.wrongCount.Size = new System.Drawing.Size(39, 13);
            this.wrongCount.TabIndex = 2;
            this.wrongCount.Text = "Wrong";
            // 
            // correctCount
            // 
            this.correctCount.AutoSize = true;
            this.correctCount.Location = new System.Drawing.Point(22, 45);
            this.correctCount.Name = "correctCount";
            this.correctCount.Size = new System.Drawing.Size(41, 13);
            this.correctCount.TabIndex = 1;
            this.correctCount.Text = "Correct";
            // 
            // playCount
            // 
            this.playCount.AutoSize = true;
            this.playCount.Location = new System.Drawing.Point(22, 18);
            this.playCount.Name = "playCount";
            this.playCount.Size = new System.Drawing.Size(58, 13);
            this.playCount.TabIndex = 0;
            this.playCount.Text = "No. of play";
            // 
            // resultFalse
            // 
            this.resultFalse.AutoSize = true;
            this.resultFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultFalse.ForeColor = System.Drawing.Color.Red;
            this.resultFalse.Location = new System.Drawing.Point(89, 293);
            this.resultFalse.Name = "resultFalse";
            this.resultFalse.Size = new System.Drawing.Size(87, 33);
            this.resultFalse.TabIndex = 9;
            this.resultFalse.Text = "False";
            this.resultFalse.Visible = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(152, 149);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(134, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MathOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultFalse);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.score);
            this.Controls.Add(this.resultCorrect);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.questionlbl);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.header);
            this.Controls.Add(this.button1);
            this.Name = "MathOp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathOp";
            this.score.ResumeLayout(false);
            this.score.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label questionlbl;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label resultCorrect;
        private System.Windows.Forms.GroupBox score;
        private System.Windows.Forms.Label wrongCount;
        private System.Windows.Forms.Label correctCount;
        private System.Windows.Forms.Label playCount;
        private System.Windows.Forms.Label resultFalse;
        private System.Windows.Forms.Button startButton;
    }
}