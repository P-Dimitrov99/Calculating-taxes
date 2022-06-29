using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingTaxes
{
    //we create an interface Itax which will hold 2 methods
    //one to check requirements and one to calculate tax
    public interface ITax
    {
        bool CheckRequirements(double salary);

        double Calculate(double salary);
    }

}
