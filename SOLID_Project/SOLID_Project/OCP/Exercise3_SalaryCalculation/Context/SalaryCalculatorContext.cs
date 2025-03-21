using SOLID_Project.OCP.Exercise3_SalaryCalculation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise3_SalaryCalculation.Context
{
    public class SalaryCalculatorContext
    {
        private readonly ISalaryCalculator _salaryCalculatior;

        public SalaryCalculatorContext(ISalaryCalculator salaryCalculatior)
        {
            _salaryCalculatior = salaryCalculatior;
        }

        public double GetSalary(double basicSalary, double reward = 0) => _salaryCalculatior.CalculateSalary(basicSalary, reward);
    }
}
