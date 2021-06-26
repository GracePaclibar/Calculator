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


        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            calc.Num = num.Text;
            calc.num2 = textBox.Text;
            calc.Number();
            textBox.Text = calc.num2;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button operation = (Button)sender;
            calc.operation_symbol = operation.Text;
            calc.num2 = textBox.Text;
            calc.OperationButton();
            currentOp.Text = calc.CurrentOperation;
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
            calc.num2 = textBox.Text;
            calc.Equal();
            textBox.Text = calc.num2;
            currentOp.Text = calc.CurrentOperation;
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
            if ((textBox.Text == "0") || (calc.checkOperation))
            {
                textBox.Clear();
            }
            if (calc.Num == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text = textBox.Text += calc.Num;
                    calc.checkOperation = false;
                }
            }
            else
            {
                textBox.Text = textBox.Text += calc.Num;
                calc.checkOperation = false;
            }
        }
    }
}
