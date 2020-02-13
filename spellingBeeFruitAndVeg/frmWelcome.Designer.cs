namespace spellingBeeFruitAndVeg
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmitWord = new System.Windows.Forms.Button();
            this.lblAddNewWordHeading = new System.Windows.Forms.Label();
            this.lblAddNewWord = new System.Windows.Forms.Label();
            this.lblAddNewDescription = new System.Windows.Forms.Label();
            this.txtAddWord = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnGuideLines = new System.Windows.Forms.Button();
            this.lblGuessSectionHeading = new System.Windows.Forms.Label();
            this.lblGuessPrompt = new System.Windows.Forms.Label();
            this.lblDescriptionOutput = new System.Windows.Forms.Label();
            this.lblUserPrompt = new System.Windows.Forms.Label();
            this.txtUserInputGuess = new System.Windows.Forms.TextBox();
            this.lblExposeWord = new System.Windows.Forms.Label();
            this.lblWordOutput = new System.Windows.Forms.Label();
            this.btnDisplaySecretWord = new System.Windows.Forms.Button();
            this.btnCheckLetters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(124, 23);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(355, 52);
            this.lblHeading.TabIndex = 5;
            this.lblHeading.Text = "WELCOME TO THE ANUAL \r\nSPELLING-BEE";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Location = new System.Drawing.Point(12, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmitWord
            // 
            this.btnSubmitWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitWord.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitWord.Location = new System.Drawing.Point(497, 97);
            this.btnSubmitWord.Name = "btnSubmitWord";
            this.btnSubmitWord.Size = new System.Drawing.Size(131, 67);
            this.btnSubmitWord.TabIndex = 9;
            this.btnSubmitWord.Text = "Submit Word \r\nAnd Description";
            this.btnSubmitWord.UseVisualStyleBackColor = true;
            this.btnSubmitWord.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAddNewWordHeading
            // 
            this.lblAddNewWordHeading.AutoSize = true;
            this.lblAddNewWordHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblAddNewWordHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewWordHeading.Location = new System.Drawing.Point(9, 87);
            this.lblAddNewWordHeading.Name = "lblAddNewWordHeading";
            this.lblAddNewWordHeading.Size = new System.Drawing.Size(328, 18);
            this.lblAddNewWordHeading.TabIndex = 10;
            this.lblAddNewWordHeading.Text = "-- Add A New Word To The Game Below --";
            // 
            // lblAddNewWord
            // 
            this.lblAddNewWord.AutoSize = true;
            this.lblAddNewWord.BackColor = System.Drawing.Color.Transparent;
            this.lblAddNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewWord.Location = new System.Drawing.Point(7, 114);
            this.lblAddNewWord.Name = "lblAddNewWord";
            this.lblAddNewWord.Size = new System.Drawing.Size(125, 25);
            this.lblAddNewWord.TabIndex = 11;
            this.lblAddNewWord.Text = "Add Word : ";
            // 
            // lblAddNewDescription
            // 
            this.lblAddNewDescription.AutoSize = true;
            this.lblAddNewDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblAddNewDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewDescription.Location = new System.Drawing.Point(7, 139);
            this.lblAddNewDescription.Name = "lblAddNewDescription";
            this.lblAddNewDescription.Size = new System.Drawing.Size(182, 25);
            this.lblAddNewDescription.TabIndex = 12;
            this.lblAddNewDescription.Text = "Add Description : ";
            // 
            // txtAddWord
            // 
            this.txtAddWord.Location = new System.Drawing.Point(210, 120);
            this.txtAddWord.Name = "txtAddWord";
            this.txtAddWord.Size = new System.Drawing.Size(224, 20);
            this.txtAddWord.TabIndex = 13;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(210, 144);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(224, 20);
            this.txtAddDescription.TabIndex = 14;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClearFields.Location = new System.Drawing.Point(497, 170);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(131, 44);
            this.btnClearFields.TabIndex = 15;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnGuideLines
            // 
            this.btnGuideLines.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnGuideLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuideLines.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGuideLines.Location = new System.Drawing.Point(129, 514);
            this.btnGuideLines.Name = "btnGuideLines";
            this.btnGuideLines.Size = new System.Drawing.Size(325, 32);
            this.btnGuideLines.TabIndex = 18;
            this.btnGuideLines.Text = "GUIDE-LINES FOR GAME";
            this.btnGuideLines.UseVisualStyleBackColor = true;
            this.btnGuideLines.Click += new System.EventHandler(this.btnGuideLines_Click);
            // 
            // lblGuessSectionHeading
            // 
            this.lblGuessSectionHeading.AutoSize = true;
            this.lblGuessSectionHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblGuessSectionHeading.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessSectionHeading.Location = new System.Drawing.Point(124, 212);
            this.lblGuessSectionHeading.Name = "lblGuessSectionHeading";
            this.lblGuessSectionHeading.Size = new System.Drawing.Size(319, 52);
            this.lblGuessSectionHeading.TabIndex = 19;
            this.lblGuessSectionHeading.Text = " SPELLING-BEE\r\nFRUIT AND VEGETABLE";
            this.lblGuessSectionHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGuessPrompt
            // 
            this.lblGuessPrompt.AutoSize = true;
            this.lblGuessPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblGuessPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessPrompt.Location = new System.Drawing.Point(9, 277);
            this.lblGuessPrompt.Name = "lblGuessPrompt";
            this.lblGuessPrompt.Size = new System.Drawing.Size(433, 16);
            this.lblGuessPrompt.TabIndex = 20;
            this.lblGuessPrompt.Text = "Please Spell The Word Based On The Following Description :";
            // 
            // lblDescriptionOutput
            // 
            this.lblDescriptionOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescriptionOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescriptionOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.lblDescriptionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionOutput.Location = new System.Drawing.Point(12, 303);
            this.lblDescriptionOutput.Name = "lblDescriptionOutput";
            this.lblDescriptionOutput.Size = new System.Drawing.Size(442, 54);
            this.lblDescriptionOutput.TabIndex = 21;
            // 
            // lblUserPrompt
            // 
            this.lblUserPrompt.AutoSize = true;
            this.lblUserPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblUserPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPrompt.Location = new System.Drawing.Point(12, 367);
            this.lblUserPrompt.Name = "lblUserPrompt";
            this.lblUserPrompt.Size = new System.Drawing.Size(184, 16);
            this.lblUserPrompt.TabIndex = 22;
            this.lblUserPrompt.Text = "Type In The Field Below :";
            // 
            // txtUserInputGuess
            // 
            this.txtUserInputGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInputGuess.Location = new System.Drawing.Point(15, 386);
            this.txtUserInputGuess.Name = "txtUserInputGuess";
            this.txtUserInputGuess.Size = new System.Drawing.Size(439, 24);
            this.txtUserInputGuess.TabIndex = 23;
            // 
            // lblExposeWord
            // 
            this.lblExposeWord.AutoSize = true;
            this.lblExposeWord.BackColor = System.Drawing.Color.Transparent;
            this.lblExposeWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExposeWord.Location = new System.Drawing.Point(12, 415);
            this.lblExposeWord.Name = "lblExposeWord";
            this.lblExposeWord.Size = new System.Drawing.Size(186, 16);
            this.lblExposeWord.TabIndex = 24;
            this.lblExposeWord.Text = "Secret Word Revealed...  ";
            // 
            // lblWordOutput
            // 
            this.lblWordOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lblWordOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWordOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.lblWordOutput.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordOutput.Location = new System.Drawing.Point(12, 435);
            this.lblWordOutput.Name = "lblWordOutput";
            this.lblWordOutput.Size = new System.Drawing.Size(442, 54);
            this.lblWordOutput.TabIndex = 25;
            // 
            // btnDisplaySecretWord
            // 
            this.btnDisplaySecretWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplaySecretWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplaySecretWord.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDisplaySecretWord.Location = new System.Drawing.Point(497, 315);
            this.btnDisplaySecretWord.Name = "btnDisplaySecretWord";
            this.btnDisplaySecretWord.Size = new System.Drawing.Size(131, 42);
            this.btnDisplaySecretWord.TabIndex = 26;
            this.btnDisplaySecretWord.Text = "DISPLAY WORD";
            this.btnDisplaySecretWord.UseVisualStyleBackColor = true;
            this.btnDisplaySecretWord.Click += new System.EventHandler(this.btnDisplaySecretWord_Click);
            // 
            // btnCheckLetters
            // 
            this.btnCheckLetters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckLetters.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCheckLetters.Location = new System.Drawing.Point(497, 378);
            this.btnCheckLetters.Name = "btnCheckLetters";
            this.btnCheckLetters.Size = new System.Drawing.Size(131, 42);
            this.btnCheckLetters.TabIndex = 27;
            this.btnCheckLetters.Text = "CHECK LETTERS";
            this.btnCheckLetters.UseVisualStyleBackColor = true;
            this.btnCheckLetters.Click += new System.EventHandler(this.btnCheckLetters_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 558);
            this.Controls.Add(this.btnCheckLetters);
            this.Controls.Add(this.btnDisplaySecretWord);
            this.Controls.Add(this.lblWordOutput);
            this.Controls.Add(this.lblExposeWord);
            this.Controls.Add(this.txtUserInputGuess);
            this.Controls.Add(this.lblUserPrompt);
            this.Controls.Add(this.lblDescriptionOutput);
            this.Controls.Add(this.lblGuessPrompt);
            this.Controls.Add(this.lblGuessSectionHeading);
            this.Controls.Add(this.btnGuideLines);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.txtAddDescription);
            this.Controls.Add(this.txtAddWord);
            this.Controls.Add(this.lblAddNewDescription);
            this.Controls.Add(this.lblAddNewWord);
            this.Controls.Add(this.lblAddNewWordHeading);
            this.Controls.Add(this.btnSubmitWord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spelling-Bee : Fruit And Vegetables";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmitWord;
        private System.Windows.Forms.Label lblAddNewWordHeading;
        private System.Windows.Forms.Label lblAddNewWord;
        private System.Windows.Forms.Label lblAddNewDescription;
        private System.Windows.Forms.TextBox txtAddWord;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnGuideLines;
        private System.Windows.Forms.Label lblGuessSectionHeading;
        private System.Windows.Forms.Label lblGuessPrompt;
        private System.Windows.Forms.Label lblDescriptionOutput;
        private System.Windows.Forms.Label lblUserPrompt;
        private System.Windows.Forms.TextBox txtUserInputGuess;
        private System.Windows.Forms.Label lblExposeWord;
        private System.Windows.Forms.Label lblWordOutput;
        private System.Windows.Forms.Button btnDisplaySecretWord;
        private System.Windows.Forms.Button btnCheckLetters;
    }
}

