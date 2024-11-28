
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankA

{ 
    public partial class Form1 : Form
    {
        BankAccount Account1= new BankAccount("");
        BankAccount Account2 = new BankAccount("");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            double amount;
            if (double.TryParse(Numbers1.Text, out amount)) 
              {
                if (Account1.Deposit(amount))
                {
                    showing.Text = "Deposit succseeful";
                }
                else
                {
                    showing.Text = "invalid deposit amount";
                }
                    }
            else

            {
                showing.Text = " enter valid amount";
            }
            Numbers2.Text = ("Balance : " + Convert.ToString(Account1.CheckBalance()));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(Numbers1.Text, out amount))
            {
                if (Account1.Withdraw(amount))
                {
                    showing.Text = "withdraw succseeful";
                }
                else
                {
                    showing.Text = "invalid withdraw amount";
                }
            }
            else

            {
                showing.Text = " enter valid amount";
            }
            Numbers2.Text = ("Balance : "+ Convert.ToString(Account1.CheckBalance()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(Numbers1.Text, out amount))
            {
                if (Account1.Transfer(Account2,amount))
                {
                    showing.Text = "transfer succseeful";
                }
                else
                {
                    showing.Text = "invalid tranfer amount";
                }
            }
            else

            {
                showing.Text = " enter valid amount";
            }
            Numbers2.Text = ("Balance :" + Convert.ToString(Account1.CheckBalance()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Numbers2.Text = ("Balance :" + Convert.ToString(Account1.CheckBalance()));
            Numbers1.Text = 
            showing.Text = ("");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string qq = Convert.ToString(BankAccount.TotalAccounts);
            showing.Text = qq;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BankAccount A1 = new BankAccount();
            showing.Text = Convert.ToString(BankAccount.TotalAccounts);

            
        }

        private void Numbers1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
