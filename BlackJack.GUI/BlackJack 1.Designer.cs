
namespace BlackJack.GUI
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
            this.picDeck = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picPlayer3 = new System.Windows.Forms.PictureBox();
            this.picPlayer4 = new System.Windows.Forms.PictureBox();
            this.btnCreateDeck = new System.Windows.Forms.Button();
            this.tbxCardsCount = new System.Windows.Forms.TextBox();
            this.lblCardsCount = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer4)).BeginInit();
            this.SuspendLayout();
            // 
            // picDeck
            // 
            this.picDeck.BackgroundImage = global::BlackJack.GUI.Properties.Resources.CardSkin;
            this.picDeck.Location = new System.Drawing.Point(714, 434);
            this.picDeck.Name = "picDeck";
            this.picDeck.Size = new System.Drawing.Size(189, 260);
            this.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDeck.TabIndex = 0;
            this.picDeck.TabStop = false;
            this.picDeck.Click += new System.EventHandler(this.picDeck_Click);
            // 
            // picPlayer1
            // 
            this.picPlayer1.BackgroundImage = global::BlackJack.GUI.Properties.Resources.CardSkin;
            this.picPlayer1.Location = new System.Drawing.Point(120, 42);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(189, 260);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer1.TabIndex = 1;
            this.picPlayer1.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackgroundImage = global::BlackJack.GUI.Properties.Resources.CardSkin;
            this.picPlayer2.Location = new System.Drawing.Point(507, 42);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(189, 260);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer2.TabIndex = 2;
            this.picPlayer2.TabStop = false;
            // 
            // picPlayer3
            // 
            this.picPlayer3.BackgroundImage = global::BlackJack.GUI.Properties.Resources.CardSkin;
            this.picPlayer3.Location = new System.Drawing.Point(872, 42);
            this.picPlayer3.Name = "picPlayer3";
            this.picPlayer3.Size = new System.Drawing.Size(189, 260);
            this.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer3.TabIndex = 3;
            this.picPlayer3.TabStop = false;
            // 
            // picPlayer4
            // 
            this.picPlayer4.BackgroundImage = global::BlackJack.GUI.Properties.Resources.CardSkin;
            this.picPlayer4.Location = new System.Drawing.Point(1206, 42);
            this.picPlayer4.Name = "picPlayer4";
            this.picPlayer4.Size = new System.Drawing.Size(189, 260);
            this.picPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer4.TabIndex = 4;
            this.picPlayer4.TabStop = false;
            // 
            // btnCreateDeck
            // 
            this.btnCreateDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDeck.Location = new System.Drawing.Point(532, 510);
            this.btnCreateDeck.Name = "btnCreateDeck";
            this.btnCreateDeck.Size = new System.Drawing.Size(133, 118);
            this.btnCreateDeck.TabIndex = 5;
            this.btnCreateDeck.Text = "Neuer Stapel";
            this.btnCreateDeck.UseVisualStyleBackColor = true;
            this.btnCreateDeck.Click += new System.EventHandler(this.btnCreateDeck_Click);
            // 
            // tbxCardsCount
            // 
            this.tbxCardsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCardsCount.Location = new System.Drawing.Point(982, 532);
            this.tbxCardsCount.Name = "tbxCardsCount";
            this.tbxCardsCount.ReadOnly = true;
            this.tbxCardsCount.Size = new System.Drawing.Size(100, 34);
            this.tbxCardsCount.TabIndex = 6;
            // 
            // lblCardsCount
            // 
            this.lblCardsCount.AutoSize = true;
            this.lblCardsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardsCount.Location = new System.Drawing.Point(977, 477);
            this.lblCardsCount.Name = "lblCardsCount";
            this.lblCardsCount.Size = new System.Drawing.Size(203, 29);
            this.lblCardsCount.TabIndex = 7;
            this.lblCardsCount.Text = "Karten am Stapel:";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(158, 9);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(110, 29);
            this.lblPlayer1.TabIndex = 8;
            this.lblPlayer1.Text = "Spieler 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(543, 10);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(110, 29);
            this.lblPlayer2.TabIndex = 9;
            this.lblPlayer2.Text = "Spieler 2";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3.Location = new System.Drawing.Point(913, 9);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(110, 29);
            this.lblPlayer3.TabIndex = 10;
            this.lblPlayer3.Text = "Spieler 3";
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer4.Location = new System.Drawing.Point(1251, 9);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(110, 29);
            this.lblPlayer4.TabIndex = 11;
            this.lblPlayer4.Text = "Spieler 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 733);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblCardsCount);
            this.Controls.Add(this.tbxCardsCount);
            this.Controls.Add(this.btnCreateDeck);
            this.Controls.Add(this.picPlayer4);
            this.Controls.Add(this.picPlayer3);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.picDeck);
            this.Name = "Form1";
            this.Text = "BlackJack 1";
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDeck;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox picPlayer3;
        private System.Windows.Forms.PictureBox picPlayer4;
        private System.Windows.Forms.Button btnCreateDeck;
        private System.Windows.Forms.TextBox tbxCardsCount;
        private System.Windows.Forms.Label lblCardsCount;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayer4;
    }
}

