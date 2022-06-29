//if we want to add new taxes all we need to do 
//is create a new class for the tax
//implement the Itax intefrace in it
//define the methods that are in the Itax
//add an instance of the new class to the IList and it shoud be almost done
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //we read the console for the salary
            Console.WriteLine("Input salary: ");
            double salary = double.Parse(Console.ReadLine());
            //create a new TaxCalculator
            TaxCalculator taxCalculator = new TaxCalculator();
            //save the return data from the Calculate(salary) in a new variable 
            double tax = taxCalculator.Calculate(salary);
            //print the tax and the net salary
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Net salary: {(salary - tax)}");
        }
    }
}
