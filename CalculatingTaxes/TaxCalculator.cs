using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingTaxes
{
    //then we need a final class where the calculations will take place
    public class TaxCalculator
    {
        //first we create a IList to hold the instances of IncomeTax and SocialContributionTax
        private readonly IList<ITax> _mTaxes = new List<ITax>();

        public TaxCalculator()
        {
            //here we create the instances of the 2 classes and add them to the list
            _mTaxes.Add(new IncomeTax());
            _mTaxes.Add(new SocialContributionTax());
        }
        //this is where the calculations take place
        public double Calculate(double salary)
        {
            double taxAmount = 0;
            double tempSalary = salary;
            foreach (ITax tax in _mTaxes)
            {
                if (tax.CheckRequirements(tempSalary))
                {
                    taxAmount += tax.Calculate(tempSalary);
                    tempSalary -= taxAmount;
                }
            }

            return taxAmount;
        }
    }
}
