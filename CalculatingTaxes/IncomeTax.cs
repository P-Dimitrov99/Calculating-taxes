using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingTaxes
{
    //we make use of Itax and define the 2 methods
    public class IncomeTax : ITax
    {
        public bool CheckRequirements(double salary)
        {
            return salary > 1000;
        }

        public double Calculate(double salary)
        {
            return (salary - 1000) * 0.1;
        }
    }
}
