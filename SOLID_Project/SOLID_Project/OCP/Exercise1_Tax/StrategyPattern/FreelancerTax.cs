using SOLID_Project.OCP.Exercise1_Tax.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise1_Tax.StrategyPattern
{
    public class FreelancerTax : ITaxCaculator
    {
        public double CalculateTax(double income)
        {
            return income * 0.15;
        }
    }
}
