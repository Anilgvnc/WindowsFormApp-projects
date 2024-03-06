namespace _.Net_Basics
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.description = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.redirectToMathOp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(417, 203);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(201, 39);
            this.description.TabIndex = 7;
            this.description.Text = "Choose one of the application and learn. \r\nThis applications based on .net. \r\nBy " +
    "Kemal Anıl Güvenç";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(417, 154);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(121, 13);
            this.header.TabIndex = 6;
            this.header.Text = "Welcome to .Net Basics";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(181, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // redirectToMathOp
            // 
            this.redirectToMathOp.AutoSize = true;
            this.redirectToMathOp.Location = new System.Drawing.Point(181, 144);
            this.redirectToMathOp.Name = "redirectToMathOp";
            this.redirectToMathOp.Size = new System.Drawing.Size(103, 33);
            this.redirectToMathOp.TabIndex = 4;
            this.redirectToMathOp.Text = "Math Operations";
            this.redirectToMathOp.UseVisualStyleBackColor = true;
            this.redirectToMathOp.Click += new System.EventHandler(this.redirectToMathOp_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(731, 383);
            this.Controls.Add(this.description);
            this.Controls.Add(this.header);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.redirectToMathOp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = ".Net Basics Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button redirectToMathOp;
    }
}

