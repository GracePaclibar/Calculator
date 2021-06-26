using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class myClass
    {
        public String Operation = "";
        public String operation_symbol = "";
        public Double Result = 0;
        public String num2 = "";
        public String CurrentOperation = "";
        public bool checkOperation = false;

        public void OperationButton()
        {
            if (Result != 0)
            {
                Equal();
                Operation = operation_symbol;
                CurrentOperation = Result + " " + Operation;
                checkOperation = true;
            }
            else
            {
                Operation = operation_symbol;
                Result = Double.Parse(num2);
                CurrentOperation = Result + " " + Operation;
                checkOperation = true;
            }
        }

        public void CE()
        {
            num2 = "0";
            Result = 0;
        }

        public void C()
        {
            num2 = "0";
            Result = 0;
            CurrentOperation = "";
        }

        public void Equal()
        {
            switch (Operation)
            {
                case "+":
                    num2 = (Result + Double.Parse(num2)).ToString();
                    break;
                case "−":
                    num2 = (Result - Double.Parse(num2)).ToString();
                    break;
                case "÷":
                    num2 = (Result / Double.Parse(num2)).ToString();
                    break;
                case "×":
                    num2 = (Result * Double.Parse(num2)).ToString();
                    break;
                default:
                    break;
            }
            Result = Double.Parse(num2);
            CurrentOperation = "";
        }

        public void BackSpace()
        {
            try
            {
                num2 = num2.Remove(num2.Length - 1, 1);
                if (num2 == "")
                {
                    num2 = "0";
                }

            }
            catch
            {

            }
        }

        public void Negation()
        {
            num2 = (Double.Parse(num2) * -1).ToString();
        }
    } 
}
