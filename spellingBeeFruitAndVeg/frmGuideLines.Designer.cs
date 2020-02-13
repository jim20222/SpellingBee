namespace spellingBeeFruitAndVeg
{
    partial class frmGuideLines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuideLines));
            this.lblGuideLines2 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblGuideLines = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblVowelGuide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuideLines2
            // 
            this.lblGuideLines2.AutoSize = true;
            this.lblGuideLines2.BackColor = System.Drawing.Color.Transparent;
            this.lblGuideLines2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuideLines2.Location = new System.Drawing.Point(26, 88);
            this.lblGuideLines2.Name = "lblGuideLines2";
            this.lblGuideLines2.Size = new System.Drawing.Size(280, 18);
            this.lblGuideLines2.TabIndex = 5;
            this.lblGuideLines2.Text = "Compulsory Guide-Lines For Game:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(121, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(355, 52);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "WELCOME TO THE ANUAL \r\nSPELLING-BEE";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGuideLines
            // 
            this.lblGuideLines.AutoSize = true;
            this.lblGuideLines.BackColor = System.Drawing.Color.Transparent;
            this.lblGuideLines.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuideLines.Location = new System.Drawing.Point(12, 125);
            this.lblGuideLines.Name = "lblGuideLines";
            this.lblGuideLines.Size = new System.Drawing.Size(550, 176);
            this.lblGuideLines.TabIndex = 7;
            this.lblGuideLines.Text = resources.GetString("lblGuideLines.Text");
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.Location = new System.Drawing.Point(12, 370);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 57);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return To Spelling-Bee";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblVowelGuide
            // 
            this.lblVowelGuide.AutoSize = true;
            this.lblVowelGuide.BackColor = System.Drawing.Color.Transparent;
            this.lblVowelGuide.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVowelGuide.Location = new System.Drawing.Point(12, 312);
            this.lblVowelGuide.Name = "lblVowelGuide";
            this.lblVowelGuide.Size = new System.Drawing.Size(333, 48);
            this.lblVowelGuide.TabIndex = 9;
            this.lblVowelGuide.Text = "All new words should conform to the following rules:\r\n·\tLength 5-8 characters\r\n·\t" +
    "Word should contain 2 vowels\r\n";
            // 
            // frmGuideLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 439);
            this.Controls.Add(this.lblVowelGuide);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblGuideLines);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblGuideLines2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuideLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spelling-Bee : Fruit And Vegetables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuideLines2;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblGuideLines;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblVowelGuide;
    }
}