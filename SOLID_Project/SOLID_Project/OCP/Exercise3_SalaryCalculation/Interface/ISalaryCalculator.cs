using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise3_SalaryCalculation.Interface
{
    public interface ISalaryCalculator
    {
        public double CalculateSalary(double basicSalary, double reward);
    }
}
