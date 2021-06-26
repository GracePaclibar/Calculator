using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double Result = 0;
        String Operation = "";
        bool checkOperation = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (checkOperation))
            {
                textBox.Clear();
            }
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text = textBox.Text += num.Text;
                    checkOperation = false;
                }
            }
            else
            {
                textBox.Text = textBox.Text += num.Text;
                checkOperation = false;
            }
            
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            if (Result != 0)
            {
                buttonEqual.PerformClick();
                Operation = operation.Text;
                currentOp.Text = Result + " " + Operation;
                checkOperation = true;
            }
            else
            {
                Operation = operation.Text;
                Result = Double.Parse(textBox.Text);
                currentOp.Text = Result + " " + Operation;
                checkOperation = true;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            Result = 0;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            Result = 0;
            currentOp.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch(Operation)
            {
                case "+":
                    textBox.Text = (Result + Double.Parse(textBox.Text)).ToString();
                    break;
                case "−":
                    textBox.Text = (Result - Double.Parse(textBox.Text)).ToString();
                    break;
                case "÷":
                    textBox.Text = (Result / Double.Parse(textBox.Text)).ToString();
                    break;
                case "×":
                    textBox.Text = (Result * Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            Result = Double.Parse(textBox.Text);
            currentOp.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                if(textBox.Text == "")
                {
                    textBox.Text = "0";
                }

            }
            catch
            {

            }
        }

        private void negate_click(object sender, EventArgs e)
        {
            textBox.Text = (Double.Parse(textBox.Text) * -1).ToString();
        }

    }
}
