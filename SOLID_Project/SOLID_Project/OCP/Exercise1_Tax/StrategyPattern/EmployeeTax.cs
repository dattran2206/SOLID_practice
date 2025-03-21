using SOLID_Project.OCP.Exercise1_Tax.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise1_Tax.StrategyPattern
{
    public class EmployeeTax : ITaxCaculator
    {
        public double CalculateTax(double income)
        {
            return income * 0.1;
        }
    }
}
