using SOLID_Project.OCP.Exercise4_ShippingCosts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise4_ShippingCosts.StrategyPattern
{
    public class GiaoHangNhanhCosts : IShippingCosts
    {
        public double CalculateShippingCosts(double price) => price;
    }
}
