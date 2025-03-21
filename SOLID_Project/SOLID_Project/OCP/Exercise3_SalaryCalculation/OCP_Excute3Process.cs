using SOLID_Project.OCP.Exercise3_SalaryCalculation.Context;
using SOLID_Project.OCP.Exercise3_SalaryCalculation.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise3_SalaryCalculation
{
    public static class OCP_Excute3Process
    {
        public static void Process()
        {
            Console.Write("Type basic salary: ");
            double basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Type reward: ");
            double reward = Convert.ToDouble(Console.ReadLine());

            SalaryCalculatorContext permanent = new SalaryCalculatorContext(new PermanentEmployee());
            Console.WriteLine($"Salary of permanent employee is {permanent.GetSalary(basicSalary, reward):#,##0} VND");

            SalaryCalculatorContext contract = new SalaryCalculatorContext(new ContractEmployee());
            Console.WriteLine($"Salary of contract employee is {contract.GetSalary(basicSalary, reward):#,##0} VND");

            SalaryCalculatorContext intern = new SalaryCalculatorContext(new Intern());
            Console.WriteLine($"Salary of intern is {intern.GetSalary(basicSalary):#,##0} VND");

            Console.WriteLine();
        }
    }
}
