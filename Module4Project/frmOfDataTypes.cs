using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Zach Scheffler
   Obj-Oriented Programming ITD-2343
   24 May, 2023*/

namespace Module4Project
{
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
        }

        private void btnByte_Click(object sender, EventArgs e)
        {
            byte leftOperand = 5;
            byte rightOperand = 25;
            byte result = (byte)(leftOperand + rightOperand);

            //code here is adding left and right operands.

            label1.Text = string.Format("{0} + {1} = {2}", leftOperand, rightOperand, result);
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            short leftOperand = 100;
            short rightOperand = 75;
            short result = (short)(leftOperand - rightOperand);

            //code here is subtracting left and right operands.

            label1.Text = string.Format("{0} - {1} = {2}", leftOperand, rightOperand, result);
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int leftOperand = 25;
            int rightOperand = 5;
            int result = leftOperand / rightOperand;

            //dividing left from right operands

            label1.Text = string.Format("{0} / {1} = {2}", leftOperand, rightOperand, result);
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            long leftOperand = 50;
            long rightOperand = 7;
            long result = leftOperand % rightOperand;

            //this is giving the remainder after divindg left from right

            label1.Text = string.Format("{0} % {1} = {2}", leftOperand, rightOperand, result);
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float leftOperand = 10.5f;
            float rightOperand = 3.2f;
            float result = leftOperand % rightOperand;

            //gives the remainder accurate to 7 digits

            label1.Text = string.Format("{0} % {1} = {2:0.#######}", leftOperand, rightOperand, result);
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double leftOperand = 20.25;
            double rightOperand = 4.25;
            double result = leftOperand / rightOperand;

            //divides left from right accurate to 16 digits

            label1.Text = string.Format("{0} / {1} = {2:0.################}", leftOperand, rightOperand, result);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal leftOperand = 15.5m;
            decimal rightOperand = 2.5m;
            decimal result = leftOperand * rightOperand;

            //multiplies left and right accurate to 25 digits

            string format = "{0} * {1} = {2:0.###############################}";
            label1.Text = string.Format(format, leftOperand, rightOperand, result);

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double number = 64;
            double result = Math.Sqrt(number);

            //uses Math.Sqrt class to perform square root calc

            label1.Text = string.Format("The square root of {0} is {1}", number, result);
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            double operand = 3.14159;
            int decimalPlaces = 2;

            //uses Math.Round to round to specified number of digits

            double roundedResult = Math.Round(operand, decimalPlaces);
            label1.Text = string.Format("Round({0}, {1}) = {2}", operand, decimalPlaces, roundedResult);
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            double startNumber = 2.0;
            double exponent = 3.0;
            double result = Math.Pow(startNumber, exponent);

            //uses Math.Pow class to find the exponents

            label1.Text = string.Format("{0} ^ {1} = {2}", startNumber, exponent, result);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label1.Text = " ";

            //clears out the label
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            //closes the application
        }
    }
}
