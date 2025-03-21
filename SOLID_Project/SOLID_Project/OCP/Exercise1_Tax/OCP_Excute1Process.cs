using SOLID_Project.OCP.Exercise1_Tax.Context;
using SOLID_Project.OCP.Exercise1_Tax.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise1_Tax
{
    public static class OCP_Excute1Process
    {
        public static void Process()
        {
            Console.Write("Thu nhap can tinh: ");
            double income = Convert.ToDouble(Console.ReadLine()); //thu nhập

            //Nhân viên
            TaxContext employeeTaxContext = new TaxContext(new EmployeeTax());
            Console.WriteLine($"Thue nhan vien phai nop: {employeeTaxContext.GetTax(income)} VND");

            //Freelancer
            TaxContext freelancerTaxContext = new TaxContext(new FreelancerTax());
            Console.WriteLine($"Thue freelancer phai nop: {freelancerTaxContext.GetTax(income)} VND");

            //Business
            TaxContext businessTaxContext = new TaxContext(new BusinessTax());
            Console.WriteLine($"Thue business phai nop: {businessTaxContext.GetTax(income)} VND");

            Console.WriteLine();
        }
    }
}
