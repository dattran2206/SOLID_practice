using SOLID_Project.OCP.Exercise1_Tax.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise1_Tax.Context
{
    public class TaxContext
    {
        private readonly ITaxCaculator _taxCalculator;
        public TaxContext(ITaxCaculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }
        public string GetTax(double income)
        {
            return _taxCalculator.CalculateTax(income).ToString("n0");
        }
    }
}
