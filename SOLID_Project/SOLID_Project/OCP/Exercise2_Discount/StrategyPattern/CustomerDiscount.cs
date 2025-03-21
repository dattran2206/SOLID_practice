using SOLID_Project.OCP.Exercise2_Discount.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise2_Discount.StrategyPattern
{
    public class CustomerDiscount : IDiscountCalculator
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.05;
        }
    }
}
