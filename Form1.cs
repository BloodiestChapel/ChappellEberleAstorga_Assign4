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
        // Calculator Variables
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        // Graph Variables
        private static Pen blackPen;
        private static Pen selectedPen;
        private static int xMax = 10;
        private static int xMin = -10;
        private static int yMax = 10;
        private static int yMin = -10;

        public Form1()
        {
            InitializeComponent();
            blackPen = new Pen(Color.Black);
            selectedPen = new Pen(Color.White);
        }

        private void graphPanel_Clear(Object sender, EventArgs e)
        {

            Graphics g = graphPanel.CreateGraphics();

            //xMin = Convert.ToInt32(xMinRange.Value);
            //xMax = Convert.ToInt32(xMaxRange.Value);
            //yMin = Convert.ToInt32(yMinRange.Value);
            //yMax = Convert.ToInt32(yMaxRange.Value);

            SolidBrush blackBrush = new SolidBrush(Color.Black);
            g.FillRectangle(
                blackBrush,
                0,
                0,
                graphPanel.Width,
                graphPanel.Height
                );

            //// Horizontal 
            //g.DrawLine(
            //    blackPen,
            //    0,
            //    (float)yMax * (600 / ((float)yMax - (float)yMin)),
            //    graphPanel.Width,
            //    (float)yMax * (600 / ((float)yMax - (float)yMin))
            //    );
            
            //// Vertical 
            //g.DrawLine(
            //    blackPen,
            //    (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)),
            //    0,
            //    (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)),
            //    graphPanel.Height
            //    );
        }

        private void graphPanel_DrawAxes(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Horizontal 
            g.DrawLine(
                blackPen,
                0,
                (float)yMax * (600 / ((float)yMax - (float)yMin)),
                graphPanel.Width,
                (float)yMax * (600 / ((float)yMax - (float)yMin))
                );
            
            // Vertical 
            g.DrawLine(
                blackPen,
                (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)),
                0,
                (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)),
                graphPanel.Height
                );

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Sets max x value for graph
        private void buttonXMin_Click(object sender, EventArgs e)
        {
            outputBox.Text = "Please enter max value for 'X'\n";


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
            //outputBox.Text = "Please enter "
        }

        private void buttonEqChoose_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                // Choose font color
                buttonEqChoose.BackColor = colorDlg.Color;

                // Makes sure font is readable by inverting color of font
                Color background = buttonEqChoose.BackColor;
                background = Color.FromArgb(background.ToArgb() ^ 0xffffff);
                buttonEqChoose.ForeColor = background;
            }
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

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    outputBox.Text = result.ToString();
                    break;

                case '-':
                    result = num1 - num2;
                    outputBox.Text = result.ToString();
                    break;

                case '*':
                    result = num1 * num2;
                    outputBox.Text = result.ToString();
                    break;

                case '÷':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        outputBox.Text = result.ToString();
                    }
                    else
                    {
                        outputBox.Text = "Ya can't divide by 0, bro...";
                    }
                    break;

                case '\0':
                    break;
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

        private void buttonClearGraph_Click(object sender, EventArgs e)
        {

            Graphics g = graphPanel.CreateGraphics();

            //xMin = -10;
            //xMax = 10;
            //yMin = -10;
            //yMax = 10;

            SolidBrush backgroundDarkGray = new SolidBrush(Color.DarkGray);
            g.FillRectangle(
                backgroundDarkGray,
                0,
                0,
                graphPanel.Width,
                graphPanel.Height
                );

            // Horizontal 
            g.DrawLine(
                blackPen,
                0,
                graphPanel.Height/2,
                graphPanel.Width,
                graphPanel.Height/2
                );
            
            // Vertical 
            g.DrawLine(
                blackPen,
                graphPanel.Width/2, // x1
                0,                  // y1
                graphPanel.Width/2, // x2
                graphPanel.Height   // y2
                );
        }
    }
}