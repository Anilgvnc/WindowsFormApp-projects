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
            this.redirectTo_NumGuesser = new System.Windows.Forms.Button();
            this.redirectToMathOp = new System.Windows.Forms.Button();
            this.navPanel = new System.Windows.Forms.Panel();
            this.github = new System.Windows.Forms.LinkLabel();
            this.contactlbl = new System.Windows.Forms.Label();
            this.socialmedialbl = new System.Windows.Forms.Label();
            this.linkedin = new System.Windows.Forms.LinkLabel();
            this.website = new System.Windows.Forms.LinkLabel();
            this.redirectToOddOrEven = new System.Windows.Forms.Button();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(287, 75);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(298, 60);
            this.description.TabIndex = 7;
            this.description.Text = "Choose one of the application and learn. \r\nThis applications based on .net. \r\nBy " +
    "Kemal Anıl Güvenç";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(284, 26);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(302, 31);
            this.header.TabIndex = 6;
            this.header.Text = "Welcome to .Net Basics";
            // 
            // redirectTo_NumGuesser
            // 
            this.redirectTo_NumGuesser.AutoSize = true;
            this.redirectTo_NumGuesser.Location = new System.Drawing.Point(19, 64);
            this.redirectTo_NumGuesser.Name = "redirectTo_NumGuesser";
            this.redirectTo_NumGuesser.Size = new System.Drawing.Size(165, 33);
            this.redirectTo_NumGuesser.TabIndex = 5;
            this.redirectTo_NumGuesser.Text = "Number Guesser";
            this.redirectTo_NumGuesser.UseVisualStyleBackColor = true;
            this.redirectTo_NumGuesser.Click += new System.EventHandler(this.redirectTo_NumGuesser_Click);
            // 
            // redirectToMathOp
            // 
            this.redirectToMathOp.AutoSize = true;
            this.redirectToMathOp.Location = new System.Drawing.Point(19, 14);
            this.redirectToMathOp.Name = "redirectToMathOp";
            this.redirectToMathOp.Size = new System.Drawing.Size(165, 33);
            this.redirectToMathOp.TabIndex = 4;
            this.redirectToMathOp.Text = "Math Operations";
            this.redirectToMathOp.UseVisualStyleBackColor = true;
            this.redirectToMathOp.Click += new System.EventHandler(this.redirectToMathOp_Click);
            // 
            // navPanel
            // 
            this.navPanel.AutoSize = true;
            this.navPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navPanel.Controls.Add(this.redirectToMathOp);
            this.navPanel.Controls.Add(this.redirectToOddOrEven);
            this.navPanel.Controls.Add(this.redirectTo_NumGuesser);
            this.navPanel.Location = new System.Drawing.Point(12, 12);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(204, 514);
            this.navPanel.TabIndex = 8;
            // 
            // github
            // 
            this.github.AutoSize = true;
            this.github.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.github.LinkColor = System.Drawing.Color.SeaGreen;
            this.github.Location = new System.Drawing.Point(285, 272);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(57, 20);
            this.github.TabIndex = 6;
            this.github.TabStop = true;
            this.github.Text = "Github";
            this.github.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_LinkClicked);
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlbl.Location = new System.Drawing.Point(285, 208);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(124, 26);
            this.contactlbl.TabIndex = 9;
            this.contactlbl.Text = "Contact me";
            // 
            // socialmedialbl
            // 
            this.socialmedialbl.AutoSize = true;
            this.socialmedialbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socialmedialbl.Location = new System.Drawing.Point(286, 234);
            this.socialmedialbl.Name = "socialmedialbl";
            this.socialmedialbl.Size = new System.Drawing.Size(390, 20);
            this.socialmedialbl.TabIndex = 10;
            this.socialmedialbl.Text = "Links from me; you can contact with me from this links.";
            // 
            // linkedin
            // 
            this.linkedin.AutoSize = true;
            this.linkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedin.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkedin.Location = new System.Drawing.Point(348, 272);
            this.linkedin.Name = "linkedin";
            this.linkedin.Size = new System.Drawing.Size(68, 20);
            this.linkedin.TabIndex = 6;
            this.linkedin.TabStop = true;
            this.linkedin.Text = "Linkedin";
            this.linkedin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkedin_LinkClicked);
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website.LinkColor = System.Drawing.Color.SeaGreen;
            this.website.Location = new System.Drawing.Point(422, 272);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(152, 20);
            this.website.TabIndex = 6;
            this.website.TabStop = true;
            this.website.Text = "My personal website";
            this.website.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.website_LinkClicked);
            // 
            // redirectToOddOrEven
            // 
            this.redirectToOddOrEven.AutoSize = true;
            this.redirectToOddOrEven.Location = new System.Drawing.Point(19, 115);
            this.redirectToOddOrEven.Name = "redirectToOddOrEven";
            this.redirectToOddOrEven.Size = new System.Drawing.Size(165, 33);
            this.redirectToOddOrEven.TabIndex = 5;
            this.redirectToOddOrEven.Text = "Number Analysis";
            this.redirectToOddOrEven.UseVisualStyleBackColor = true;
            this.redirectToOddOrEven.Click += new System.EventHandler(this.redirectToOddOrEven_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.socialmedialbl);
            this.Controls.Add(this.contactlbl);
            this.Controls.Add(this.website);
            this.Controls.Add(this.linkedin);
            this.Controls.Add(this.github);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.header);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".Net Basics Portal";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button redirectTo_NumGuesser;
        private System.Windows.Forms.Button redirectToMathOp;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.LinkLabel github;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Label socialmedialbl;
        private System.Windows.Forms.LinkLabel linkedin;
        private System.Windows.Forms.LinkLabel website;
        private System.Windows.Forms.Button redirectToOddOrEven;
    }
}

