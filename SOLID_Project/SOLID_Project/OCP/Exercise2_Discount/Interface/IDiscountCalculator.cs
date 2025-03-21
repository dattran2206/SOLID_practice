using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise2_Discount.Interface
{
    public interface IDiscountCalculator
    {
        public double CalculateDiscount(double price);
    }
}
