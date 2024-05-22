namespace collections
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
            this.btnArr = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArr
            // 
            this.btnArr.Location = new System.Drawing.Point(6, 32);
            this.btnArr.Name = "btnArr";
            this.btnArr.Size = new System.Drawing.Size(75, 23);
            this.btnArr.TabIndex = 0;
            this.btnArr.Text = "Array list";
            this.btnArr.UseVisualStyleBackColor = true;
            this.btnArr.Click += new System.EventHandler(this.btnArr_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 295);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(772, 143);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArr);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Non Generic Coollection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Collection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArr;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

