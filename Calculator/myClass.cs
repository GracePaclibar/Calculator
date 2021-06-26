using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class myClass
    {
        public Double Result = 0;
        public String num2 = "";
        public String CurrentOperation = "";

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
