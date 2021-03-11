using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChappellEberleAstorga_Assign4
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonXMin_Click(object sender, EventArgs e)
        {

        }

        private void buttonXMax_Click(object sender, EventArgs e)
        {

        }

        private void buttonXInt_Click(object sender, EventArgs e)
        {

        }

        private void buttonYMin_Click(object sender, EventArgs e)
        {

        }

        private void buttonYMax_Click(object sender, EventArgs e)
        {

        }

        private void buttonYInt_Click(object sender, EventArgs e)
        {

        }

        private void buttonEqWhite_Click(object sender, EventArgs e)
        {

        }

        private void buttonEqRed_Click(object sender, EventArgs e)
        {

        }

        private void buttonEqGreen_Click(object sender, EventArgs e)
        {

        }

        private void buttonEqBlue_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '÷';
            input = string.Empty;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;

            double num1;
            double num2;

            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                outputBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                outputBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                outputBox.Text = result.ToString();
            }
            else if (operation == '÷')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    outputBox.Text = result.ToString();
                }
                else
                {
                    outputBox.Text = "Ya can't divide by 0, bro...";
                }
            }

        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {

        }

        private void buttonCubic_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuad_Click(object sender, EventArgs e)
        {

        }

        private void buttonLinear_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "1";
            outputBox.Text += input;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "2";
            outputBox.Text += input;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "3";
            outputBox.Text += input;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "4";
            outputBox.Text += input;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "5";
            outputBox.Text += input;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "6";
            outputBox.Text += input;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "7";
            outputBox.Text += input;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "8";
            outputBox.Text += input;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "9";
            outputBox.Text += input;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += "0";
            outputBox.Text += input;

        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += '-';
            outputBox.Text += input;

        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input += '.';
            outputBox.Text += input;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }
    }
}
