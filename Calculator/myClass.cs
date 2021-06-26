using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class myClass
    {
        public String num2 = "";

        public void Negation()
        {
            num2 = (Double.Parse(num2) * -1).ToString();
        }
    }
}
