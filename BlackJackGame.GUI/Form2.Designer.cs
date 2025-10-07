
namespace BlackJackGame.GUI
{
    partial class Form2
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
            this.btnStart = new System.Windows.Forms.Button();
            this.chkShowPlayerValue = new System.Windows.Forms.CheckBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.tbxBudget = new System.Windows.Forms.TextBox();
            this.chkShowPlayerValueColor = new System.Windows.Forms.CheckBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.tbxBet = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 39);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkShowPlayerValue
            // 
            this.chkShowPlayerValue.AutoSize = true;
            this.chkShowPlayerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPlayerValue.Location = new System.Drawing.Point(12, 277);
            this.chkShowPlayerValue.Name = "chkShowPlayerValue";
            this.chkShowPlayerValue.Size = new System.Drawing.Size(252, 28);
            this.chkShowPlayerValue.TabIndex = 1;
            this.chkShowPlayerValue.Text = "Show Player\'s Hand Value";
            this.chkShowPlayerValue.UseVisualStyleBackColor = true;
            this.chkShowPlayerValue.CheckedChanged += new System.EventHandler(this.chkShowPlayerValue_CheckedChanged);
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(12, 76);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(70, 24);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Text = "Budget";
            // 
            // tbxBudget
            // 
            this.tbxBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBudget.Location = new System.Drawing.Point(98, 71);
            this.tbxBudget.Name = "tbxBudget";
            this.tbxBudget.Size = new System.Drawing.Size(100, 29);
            this.tbxBudget.TabIndex = 3;
            // 
            // chkShowPlayerValueColor
            // 
            this.chkShowPlayerValueColor.AutoSize = true;
            this.chkShowPlayerValueColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPlayerValueColor.Location = new System.Drawing.Point(12, 311);
            this.chkShowPlayerValueColor.Name = "chkShowPlayerValueColor";
            this.chkShowPlayerValueColor.Size = new System.Drawing.Size(322, 28);
            this.chkShowPlayerValueColor.TabIndex = 4;
            this.chkShowPlayerValueColor.Text = "Show Player\'s Hand Value In Color";
            this.chkShowPlayerValueColor.UseVisualStyleBackColor = true;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(12, 123);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(37, 24);
            this.lblBet.TabIndex = 5;
            this.lblBet.Text = "Bet";
            // 
            // tbxBet
            // 
            this.tbxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBet.Location = new System.Drawing.Point(98, 120);
            this.tbxBet.Name = "tbxBet";
            this.tbxBet.Size = new System.Drawing.Size(100, 29);
            this.tbxBet.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(98, 31);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 29);
            this.tbxName.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxBet);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.chkShowPlayerValueColor);
            this.Controls.Add(this.tbxBudget);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.chkShowPlayerValue);
            this.Controls.Add(this.btnStart);
            this.Name = "Form2";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkShowPlayerValue;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox tbxBudget;
        private System.Windows.Forms.CheckBox chkShowPlayerValueColor;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.TextBox tbxBet;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
    }
}