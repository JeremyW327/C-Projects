using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeReturn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal cost = Convert.ToDecimal(txtBoxCost.Text);
            decimal paid = Convert.ToDecimal(txtBoxPaid.Text);

            if (paid < cost)
                MessageBox.Show("Insufficient Funds.");
            else
            {
                decimal change = paid - cost;
                var remainder = change - Math.Truncate(change);

                if (remainder != 0)
                    CalculateCurrency(remainder);
                txtBoxChange.Text = change.ToString();
            }

        }

        void CalculateCurrency(decimal change)
        {
            //Calculate how many quarters, nickles, dimes, pennies are needed
            //to give the correct change
            //declare values of change
            decimal quarterValue = 0.25M;
            decimal dimeValue = 0.10M;
            decimal nickleValue = 0.05M;
            decimal pennyValue = 0.01M;

            //will store amount of each currency needed 
            int quarter = 0, dime = 0, nickle = 0, penny = 0;
            
            //calcute how many quarters are needed
            while (change - quarterValue >= 0)
            {
                change = change - quarterValue;
                quarter++;
            }

            //calcute how many dimes are needed
            while (change - dimeValue >= 0)
            {
                change = change - dimeValue;
                dime++;
            }

            //calcute how many nickles are needed
            while (change - nickleValue >= 0)
            {
                change = change - nickleValue;
                nickle++;
            }

            //calcute how many pennies are needed
            while (change - pennyValue >= 0)
            {
                change = change - pennyValue;
                penny++;
            }

            //display amount of each currency needed
            txtBoxQuarters.Text = quarter.ToString();
            txtBoxDimes.Text = dime.ToString();
            txtBoxNickles.Text = nickle.ToString();
            txtBoxPennies.Text = penny.ToString();
        }
    }
}
