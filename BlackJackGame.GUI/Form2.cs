using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame.GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            chkShowPlayerValueColor.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                double budget = Convert.ToDouble(tbxBudget.Text);
                double bet = Convert.ToDouble(tbxBet.Text);
                if(tbxName.Text == "")
                {
                    MessageBox.Show("Please enter your name!");
                }
                else
                {
                    Form1 f1 = new Form1(chkShowPlayerValue.Checked, chkShowPlayerValueColor.Checked, tbxName.Text, budget, bet);
                    f1.Show();
                }
               
            }
            catch
            {
                MessageBox.Show("Please enter a budget and bet");
            }
            
        }

     
        private void chkShowPlayerValue_CheckedChanged(object sender, EventArgs e)
        {
           if(chkShowPlayerValue.Checked)
           {
             chkShowPlayerValueColor.Enabled = true;
           }

           else
           { 
             chkShowPlayerValueColor.Enabled = false;
           }
        }
    }
}
