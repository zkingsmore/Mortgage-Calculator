using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortgage_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //first check if the payment was calculated without errors
            if(calculatePayment() == 0)
            {
                //with errors
                paymentLbl.Text = "";
            }
            else
            {
                //show the calculation
                paymentLbl.Text = "Your monthly payment will be $" + calculatePayment().ToString() + ".";
            }
        }

        public double calculatePayment()
        {
            //down payment of the loan with validation
            int d;
            bool dIsInt = int.TryParse(downInput.Text, out d);
            if(dIsInt)
            {
                d = int.Parse(downInput.Text);
                downErr.Text = "";
            }
            else
            {
                downErr.Text = "Enter an integer.";
            }

            //interest rate of the loan with validation
            double r;
            bool rIsDouble = double.TryParse(interestInput.Text, out r);
            if(rIsDouble)
            {
                //calculate percentage for the user
                r = double.Parse(interestInput.Text) / 100;
                interestErr.Text = "";
            }
            else
            {
                interestErr.Text = "Enter an integer";
            }

            //number of years for the loan with validation
            int t;
            bool tIsInt = int.TryParse(termInput.Text, out t);
            if(tIsInt)
            {
                t = int.Parse(termInput.Text);
                termErr.Text = "";
            }
            else
            {
                termErr.Text = "Enter an integer.";
            }

            //payments per year which is a constant 12
            int n = 12;

            //home value with validation
            int h;
            bool hIsInt = int.TryParse(valueInput.Text, out h);
            if(hIsInt)
            {
                h = int.Parse(valueInput.Text);
                valueErr.Text = "";
            }
            else
            {
                valueErr.Text = "Enter an integer.";
            }

            //validating whether the down payment is smaller than the home value
            //if the down payment is larger, change the hIsInt to false to force the user to input correct numbers
            if(!homeIsLarger(h, d))
            {
                valueErr.Text = "Down payment must be less than home value.";
                downErr.Text = "Home value must be larger than the down payment.";
                hIsInt = false;
            }

            //monthly income with validation
            int i;
            bool iIsInt = int.TryParse(incomeInput.Text, out i);
            if(iIsInt)
            {
                i = int.Parse(interestInput.Text);
                incomeErr.Text = "";
            }
            else
            {
                incomeErr.Text = "Enter an integer.";
            }

            //calculate the loan amount
            int p = h - d;

            //calculate the power for the payment equation
            double power = Math.Pow((1 + (r / n)), (n * t));

            //calculated payment that is returned rounded to 2 decimal places
            double payment = Math.Round(((p * (r/n)) * power) / (power - 1), 2);

            //if any boolean is false, change payment to 0 to hide the value
            if(!dIsInt || !rIsDouble || !tIsInt || !hIsInt || !iIsInt)
            {
                payment = 0;
            }

            return payment;
        }

        private Boolean homeIsLarger(int home, int loan)
        {
            bool hIsSmaller = false;

            if(home > loan)
            {
                hIsSmaller = true;
            }

            return hIsSmaller;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            downInput.Text = downInput.Text.Remove(0, downInput.TextLength);
            downErr.Text = "";

            interestInput.Text = interestInput.Text.Remove(0, interestInput.TextLength);
            interestErr.Text = "";

            termInput.Text = termInput.Text.Remove(0, termInput.TextLength);
            termErr.Text = "";

            valueInput.Text = valueInput.Text.Remove(0, valueInput.TextLength);
            valueErr.Text = "";

            incomeInput.Text = incomeInput.Text.Remove(0, incomeInput.TextLength);
            incomeErr.Text = "";

            paymentLbl.Text = "";
        }
    }
}
