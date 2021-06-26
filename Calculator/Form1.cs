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

        myClass calc = new myClass();

        public String Operation = "";
        public String operation_symbol = "";
        public String Num = "";
        public static String TextBox = "";
        public bool checkOperation = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            Num = num.Text;
            Number();
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            operation_symbol = operation.Text;
            OperationButton();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            calc.CE();
            textBox.Text = calc.num2;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            calc.C();
            textBox.Text = calc.num2;
            currentOp.Text = calc.CurrentOperation;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Equal();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            calc.num2 = textBox.Text;
            calc.BackSpace();
            textBox.Text = calc.num2;
        }

        private void negate_click(object sender, EventArgs e)
        {
            calc.num2 = textBox.Text;
            calc.Negation();
            textBox.Text = calc.num2;
        }

        private void Number()
        {
            if ((textBox.Text == "0") || (checkOperation))
            {
                textBox.Clear();
            }
            if (Num == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text = textBox.Text += Num;
                    checkOperation = false;
                }
            }
            else
            {
                textBox.Text = textBox.Text += Num;
                checkOperation = false;
            }
        }

        private void OperationButton()
        {
            if (calc.Result != 0)
            {
                buttonEqual.PerformClick();
                Operation = operation_symbol;
                currentOp.Text = calc.Result + " " + Operation;
                checkOperation = true;
            }
            else
            {
                Operation = operation_symbol;
                calc.Result = Double.Parse(textBox.Text);
                currentOp.Text = calc.Result + " " + Operation;
                checkOperation = true;
            }
        }

        private void CE()
        {
            textBox.Text = "0";
            calc.Result = 0;
        }

        private void Equal()
        {
            switch (Operation)
            {
                case "+":
                    textBox.Text = (calc.Result + Double.Parse(textBox.Text)).ToString();
                    break;
                case "−":
                    textBox.Text = (calc.Result - Double.Parse(textBox.Text)).ToString();
                    break;
                case "÷":
                    textBox.Text = (calc.Result / Double.Parse(textBox.Text)).ToString();
                    break;
                case "×":
                    textBox.Text = (calc.Result * Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            calc.Result = Double.Parse(textBox.Text);
            currentOp.Text = "";
        }
    }
}
