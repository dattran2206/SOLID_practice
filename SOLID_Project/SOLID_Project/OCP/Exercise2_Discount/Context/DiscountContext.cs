using SOLID_Project.OCP.Exercise2_Discount.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise2_Discount.Context
{
    public class DiscountContext
    {
        private readonly IDiscountCalculator _discountCalculator;
        public DiscountContext(IDiscountCalculator discountCalculator)
        {
            _discountCalculator = discountCalculator;
        }
        public string GetDiscount(double income)
        {
            return _discountCalculator.CalculateDiscount(income).ToString("n0");
        }
    }
}
