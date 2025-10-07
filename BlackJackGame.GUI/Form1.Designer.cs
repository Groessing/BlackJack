
namespace BlackJackGame.GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHIT = new System.Windows.Forms.Button();
            this.btnSTAND = new System.Windows.Forms.Button();
            this.picCardDeck = new System.Windows.Forms.PictureBox();
            this.picDealerCard7 = new System.Windows.Forms.PictureBox();
            this.picDealerCard6 = new System.Windows.Forms.PictureBox();
            this.picDealerCard5 = new System.Windows.Forms.PictureBox();
            this.picDealerCard4 = new System.Windows.Forms.PictureBox();
            this.picDealerCard3 = new System.Windows.Forms.PictureBox();
            this.picDealerCard2 = new System.Windows.Forms.PictureBox();
            this.picDealerCard1 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard7 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard6 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard5 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard4 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.tbxPlayerValue = new System.Windows.Forms.TextBox();
            this.lblCards = new System.Windows.Forms.Label();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCardDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHIT
            // 
            this.btnHIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHIT.Location = new System.Drawing.Point(22, 193);
            this.btnHIT.Name = "btnHIT";
            this.btnHIT.Size = new System.Drawing.Size(104, 33);
            this.btnHIT.TabIndex = 0;
            this.btnHIT.Text = "HIT";
            this.btnHIT.UseVisualStyleBackColor = true;
            this.btnHIT.Click += new System.EventHandler(this.btnHIT_Click);
            // 
            // btnSTAND
            // 
            this.btnSTAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTAND.Location = new System.Drawing.Point(22, 255);
            this.btnSTAND.Name = "btnSTAND";
            this.btnSTAND.Size = new System.Drawing.Size(104, 33);
            this.btnSTAND.TabIndex = 1;
            this.btnSTAND.Text = "STAND";
            this.btnSTAND.UseVisualStyleBackColor = true;
            this.btnSTAND.Click += new System.EventHandler(this.btnSTAND_Click);
            // 
            // picCardDeck
            // 
            this.picCardDeck.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picCardDeck.Location = new System.Drawing.Point(12, 402);
            this.picCardDeck.Name = "picCardDeck";
            this.picCardDeck.Size = new System.Drawing.Size(189, 260);
            this.picCardDeck.TabIndex = 2;
            this.picCardDeck.TabStop = false;
            // 
            // picDealerCard7
            // 
            this.picDealerCard7.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picDealerCard7.Location = new System.Drawing.Point(317, 12);
            this.picDealerCard7.Name = "picDealerCard7";
            this.picDealerCard7.Size = new System.Drawing.Size(189, 260);
            this.picDealerCard7.TabIndex = 4;
            this.picDealerCard7.TabStop = false;
            // 
            // picDealerCard6
            // 
            this.picDealerCard6.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picDealerCard6.Location = new System.Drawing.Point(317, 70);
            this.picDealerCard6.Name = "picDealerCard6";
            this.picDealerCard6.Size = new System.Drawing.Size(189, 260);
            this.picDealerCard6.TabIndex = 5;
            this.picDealerCard6.TabStop = false;
            // 
            // picDealerCard5
            // 
            this.picDealerCard5.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picDealerCard5.Location = new System.Drawing.Point(317, 136);
            this.picDealerCard5.Name = "picDealerCard5";
            this.picDealerCard5.Size = new System.Drawing.Size(189, 260);
            this.picDealerCard5.TabIndex = 6;
            this.picDealerCard5.TabStop = false;
            // 
            // picDealerCard4
            // 
            this.picDealerCard4.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picDealerCard4.Location = new System.Drawing.Point(317, 209);
            this.picDealerCard4.Name = "picDealerCard4";
            this.picDealerCard4.Size = new System.Drawing.Size(189, 260);
            this.picDealerCard4.TabIndex = 7;
            this.picDealerCard4.TabStop = false;
            // 
            // picDealerCard3
            // 
            this.picDealerCard3.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picDealerCard3.Location = new System.Drawing.Point(317, 278);
            this.picDealerCard3.Name = "picDealerCard3";
            this.picDealerCard3.Size = new System.Drawing.Size(189, 260);
            this.picDealerCard3.TabIndex = 8;
            this.picDealerCard3.TabStop = false;
            // 
            // picDealerCard2
            // 
            this.picDealerCard2.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picDealerCard2.Location = new System.Drawing.Point(317, 347);
            this.picDealerCard2.Name = "picDealerCard2";
            this.picDealerCard2.Size = new System.Drawing.Size(189, 260);
            this.picDealerCard2.TabIndex = 9;
            this.picDealerCard2.TabStop = false;
            // 
            // picDealerCard1
            // 
            this.picDealerCard1.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picDealerCard1.Location = new System.Drawing.Point(317, 402);
            this.picDealerCard1.Name = "picDealerCard1";
            this.picDealerCard1.Size = new System.Drawing.Size(189, 260);
            this.picDealerCard1.TabIndex = 10;
            this.picDealerCard1.TabStop = false;
            // 
            // picPlayerCard7
            // 
            this.picPlayerCard7.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picPlayerCard7.Location = new System.Drawing.Point(612, 12);
            this.picPlayerCard7.Name = "picPlayerCard7";
            this.picPlayerCard7.Size = new System.Drawing.Size(189, 260);
            this.picPlayerCard7.TabIndex = 11;
            this.picPlayerCard7.TabStop = false;
            // 
            // picPlayerCard6
            // 
            this.picPlayerCard6.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picPlayerCard6.Location = new System.Drawing.Point(612, 70);
            this.picPlayerCard6.Name = "picPlayerCard6";
            this.picPlayerCard6.Size = new System.Drawing.Size(189, 260);
            this.picPlayerCard6.TabIndex = 12;
            this.picPlayerCard6.TabStop = false;
            // 
            // picPlayerCard5
            // 
            this.picPlayerCard5.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picPlayerCard5.Location = new System.Drawing.Point(612, 136);
            this.picPlayerCard5.Name = "picPlayerCard5";
            this.picPlayerCard5.Size = new System.Drawing.Size(189, 260);
            this.picPlayerCard5.TabIndex = 13;
            this.picPlayerCard5.TabStop = false;
            // 
            // picPlayerCard4
            // 
            this.picPlayerCard4.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picPlayerCard4.Location = new System.Drawing.Point(612, 209);
            this.picPlayerCard4.Name = "picPlayerCard4";
            this.picPlayerCard4.Size = new System.Drawing.Size(189, 260);
            this.picPlayerCard4.TabIndex = 14;
            this.picPlayerCard4.TabStop = false;
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picPlayerCard3.Location = new System.Drawing.Point(612, 278);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(189, 260);
            this.picPlayerCard3.TabIndex = 15;
            this.picPlayerCard3.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picPlayerCard2.Location = new System.Drawing.Point(612, 347);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(189, 260);
            this.picPlayerCard2.TabIndex = 16;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard1
            // 
            this.picPlayerCard1.BackgroundImage = global::BlackJackGame.GUI.Properties.Resources.CardSkin;
            this.picPlayerCard1.Location = new System.Drawing.Point(612, 402);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(189, 260);
            this.picPlayerCard1.TabIndex = 17;
            this.picPlayerCard1.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(668, 665);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(62, 24);
            this.lblPlayer.TabIndex = 18;
            this.lblPlayer.Text = "Player";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(369, 665);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(65, 24);
            this.lblDealer.TabIndex = 19;
            this.lblDealer.Text = "Dealer";
            // 
            // tbxPlayerValue
            // 
            this.tbxPlayerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayerValue.Location = new System.Drawing.Point(1038, 278);
            this.tbxPlayerValue.Name = "tbxPlayerValue";
            this.tbxPlayerValue.Size = new System.Drawing.Size(61, 29);
            this.tbxPlayerValue.TabIndex = 20;
            // 
            // lblCards
            // 
            this.lblCards.AutoSize = true;
            this.lblCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCards.Location = new System.Drawing.Point(61, 665);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(59, 24);
            this.lblCards.TabIndex = 21;
            this.lblCards.Text = "Cards";
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.AutoSize = true;
            this.lblPlayerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerValue.Location = new System.Drawing.Point(884, 283);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(129, 24);
            this.lblPlayerValue.TabIndex = 23;
            this.lblPlayerValue.Text = "Player\'s Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 717);
            this.Controls.Add(this.lblPlayerValue);
            this.Controls.Add(this.lblCards);
            this.Controls.Add(this.tbxPlayerValue);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.picPlayerCard1);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard3);
            this.Controls.Add(this.picPlayerCard4);
            this.Controls.Add(this.picPlayerCard5);
            this.Controls.Add(this.picPlayerCard6);
            this.Controls.Add(this.picPlayerCard7);
            this.Controls.Add(this.picDealerCard1);
            this.Controls.Add(this.picDealerCard2);
            this.Controls.Add(this.picDealerCard3);
            this.Controls.Add(this.picDealerCard4);
            this.Controls.Add(this.picDealerCard5);
            this.Controls.Add(this.picDealerCard6);
            this.Controls.Add(this.picDealerCard7);
            this.Controls.Add(this.picCardDeck);
            this.Controls.Add(this.btnSTAND);
            this.Controls.Add(this.btnHIT);
            this.Name = "Form1";
            this.Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.picCardDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHIT;
        private System.Windows.Forms.Button btnSTAND;
        private System.Windows.Forms.PictureBox picCardDeck;
        private System.Windows.Forms.PictureBox picDealerCard7;
        private System.Windows.Forms.PictureBox picDealerCard6;
        private System.Windows.Forms.PictureBox picDealerCard5;
        private System.Windows.Forms.PictureBox picDealerCard4;
        private System.Windows.Forms.PictureBox picDealerCard3;
        private System.Windows.Forms.PictureBox picDealerCard2;
        private System.Windows.Forms.PictureBox picDealerCard1;
        private System.Windows.Forms.PictureBox picPlayerCard7;
        private System.Windows.Forms.PictureBox picPlayerCard6;
        private System.Windows.Forms.PictureBox picPlayerCard5;
        private System.Windows.Forms.PictureBox picPlayerCard4;
        private System.Windows.Forms.PictureBox picPlayerCard3;
        private System.Windows.Forms.PictureBox picPlayerCard2;
        private System.Windows.Forms.PictureBox picPlayerCard1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.TextBox tbxPlayerValue;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.Label lblPlayerValue;
    }
}

