namespace TexasHoldemOdds
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
            this.computerHandLabel = new System.Windows.Forms.Label();
            this.playerHandLabel = new System.Windows.Forms.Label();
            this.sharedCardsLabel = new System.Windows.Forms.Label();
            this.computerBestHandLabel = new System.Windows.Forms.Label();
            this.playerBestHandLabel = new System.Windows.Forms.Label();
            this.playerOddsLabel = new System.Windows.Forms.Label();
            this.computerOddsLabel = new System.Windows.Forms.Label();
            this.potLabel = new System.Windows.Forms.Label();
            this.playerMoneyLabel = new System.Windows.Forms.Label();
            this.computerMoneyLabel = new System.Windows.Forms.Label();
            this.foldButton = new System.Windows.Forms.Button();
            this.raiseButton = new System.Windows.Forms.Button();
            this.newRoundButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // computerHandLabel
            // 
            this.computerHandLabel.AutoSize = true;
            this.computerHandLabel.Location = new System.Drawing.Point(415, 146);
            this.computerHandLabel.Name = "computerHandLabel";
            this.computerHandLabel.Size = new System.Drawing.Size(111, 25);
            this.computerHandLabel.TabIndex = 0;
            this.computerHandLabel.Text = "Computer:";
            // 
            // playerHandLabel
            // 
            this.playerHandLabel.AutoSize = true;
            this.playerHandLabel.Location = new System.Drawing.Point(441, 566);
            this.playerHandLabel.Name = "playerHandLabel";
            this.playerHandLabel.Size = new System.Drawing.Size(85, 25);
            this.playerHandLabel.TabIndex = 1;
            this.playerHandLabel.Text = "Player: ";
            // 
            // sharedCardsLabel
            // 
            this.sharedCardsLabel.AutoSize = true;
            this.sharedCardsLabel.Location = new System.Drawing.Point(446, 341);
            this.sharedCardsLabel.Name = "sharedCardsLabel";
            this.sharedCardsLabel.Size = new System.Drawing.Size(150, 25);
            this.sharedCardsLabel.TabIndex = 2;
            this.sharedCardsLabel.Text = "SharedCards: ";
            // 
            // computerBestHandLabel
            // 
            this.computerBestHandLabel.AutoSize = true;
            this.computerBestHandLabel.Location = new System.Drawing.Point(420, 208);
            this.computerBestHandLabel.Name = "computerBestHandLabel";
            this.computerBestHandLabel.Size = new System.Drawing.Size(223, 25);
            this.computerBestHandLabel.TabIndex = 3;
            this.computerBestHandLabel.Text = "Computer Best Hand: ";
            // 
            // playerBestHandLabel
            // 
            this.playerBestHandLabel.AutoSize = true;
            this.playerBestHandLabel.Location = new System.Drawing.Point(446, 629);
            this.playerBestHandLabel.Name = "playerBestHandLabel";
            this.playerBestHandLabel.Size = new System.Drawing.Size(191, 25);
            this.playerBestHandLabel.TabIndex = 4;
            this.playerBestHandLabel.Text = "Player Best Hand: ";
            // 
            // playerOddsLabel
            // 
            this.playerOddsLabel.AutoSize = true;
            this.playerOddsLabel.Location = new System.Drawing.Point(451, 706);
            this.playerOddsLabel.Name = "playerOddsLabel";
            this.playerOddsLabel.Size = new System.Drawing.Size(75, 25);
            this.playerOddsLabel.TabIndex = 5;
            this.playerOddsLabel.Text = "Odds: ";
            // 
            // computerOddsLabel
            // 
            this.computerOddsLabel.AutoSize = true;
            this.computerOddsLabel.Location = new System.Drawing.Point(425, 69);
            this.computerOddsLabel.Name = "computerOddsLabel";
            this.computerOddsLabel.Size = new System.Drawing.Size(75, 25);
            this.computerOddsLabel.TabIndex = 6;
            this.computerOddsLabel.Text = "Odds: ";
            // 
            // potLabel
            // 
            this.potLabel.AutoSize = true;
            this.potLabel.Location = new System.Drawing.Point(351, 429);
            this.potLabel.Name = "potLabel";
            this.potLabel.Size = new System.Drawing.Size(80, 25);
            this.potLabel.TabIndex = 7;
            this.potLabel.Text = "Pot: $0";
            // 
            // playerMoneyLabel
            // 
            this.playerMoneyLabel.AutoSize = true;
            this.playerMoneyLabel.Location = new System.Drawing.Point(128, 575);
            this.playerMoneyLabel.Name = "playerMoneyLabel";
            this.playerMoneyLabel.Size = new System.Drawing.Size(30, 25);
            this.playerMoneyLabel.TabIndex = 8;
            this.playerMoneyLabel.Text = "$:";
            // 
            // computerMoneyLabel
            // 
            this.computerMoneyLabel.AutoSize = true;
            this.computerMoneyLabel.Location = new System.Drawing.Point(128, 69);
            this.computerMoneyLabel.Name = "computerMoneyLabel";
            this.computerMoneyLabel.Size = new System.Drawing.Size(30, 25);
            this.computerMoneyLabel.TabIndex = 9;
            this.computerMoneyLabel.Text = "$:";
            // 
            // foldButton
            // 
            this.foldButton.Location = new System.Drawing.Point(1268, 429);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(151, 50);
            this.foldButton.TabIndex = 10;
            this.foldButton.Text = "Fold";
            this.foldButton.UseVisualStyleBackColor = true;
            this.foldButton.Click += new System.EventHandler(this.foldButton_Click);
            // 
            // raiseButton
            // 
            this.raiseButton.Location = new System.Drawing.Point(1441, 429);
            this.raiseButton.Name = "raiseButton";
            this.raiseButton.Size = new System.Drawing.Size(151, 50);
            this.raiseButton.TabIndex = 11;
            this.raiseButton.Text = "Raise $10";
            this.raiseButton.UseVisualStyleBackColor = true;
            this.raiseButton.Click += new System.EventHandler(this.raiseButton_Click);
            // 
            // newRoundButton
            // 
            this.newRoundButton.Location = new System.Drawing.Point(1641, 429);
            this.newRoundButton.Name = "newRoundButton";
            this.newRoundButton.Size = new System.Drawing.Size(210, 50);
            this.newRoundButton.TabIndex = 12;
            this.newRoundButton.Text = "New Round";
            this.newRoundButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 1136);
            this.Controls.Add(this.newRoundButton);
            this.Controls.Add(this.raiseButton);
            this.Controls.Add(this.foldButton);
            this.Controls.Add(this.computerMoneyLabel);
            this.Controls.Add(this.playerMoneyLabel);
            this.Controls.Add(this.potLabel);
            this.Controls.Add(this.computerOddsLabel);
            this.Controls.Add(this.playerOddsLabel);
            this.Controls.Add(this.playerBestHandLabel);
            this.Controls.Add(this.computerBestHandLabel);
            this.Controls.Add(this.sharedCardsLabel);
            this.Controls.Add(this.playerHandLabel);
            this.Controls.Add(this.computerHandLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label computerHandLabel;
        private System.Windows.Forms.Label playerHandLabel;
        private System.Windows.Forms.Label sharedCardsLabel;
        private System.Windows.Forms.Label computerBestHandLabel;
        private System.Windows.Forms.Label playerBestHandLabel;
        private System.Windows.Forms.Label playerOddsLabel;
        private System.Windows.Forms.Label computerOddsLabel;
        private System.Windows.Forms.Label potLabel;
        private System.Windows.Forms.Label playerMoneyLabel;
        private System.Windows.Forms.Label computerMoneyLabel;
        private System.Windows.Forms.Button foldButton;
        private System.Windows.Forms.Button raiseButton;
        private System.Windows.Forms.Button newRoundButton;
    }
}

