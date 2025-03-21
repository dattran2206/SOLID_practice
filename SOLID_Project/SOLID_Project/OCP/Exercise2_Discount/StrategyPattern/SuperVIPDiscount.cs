using SOLID_Project.OCP.Exercise2_Discount.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise2_Discount.StrategyPattern
{
    public class SuperVIPDiscount : IDiscountCalculator
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.15;
        }
    }
}
