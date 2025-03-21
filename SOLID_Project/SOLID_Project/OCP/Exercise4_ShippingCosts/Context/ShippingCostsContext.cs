using SOLID_Project.OCP.Exercise4_ShippingCosts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise4_ShippingCosts.Context
{
    public class ShippingCostsContext
    {
        private readonly IShippingCosts _shippingCosts;

        public ShippingCostsContext(IShippingCosts shippingCosts)
        {
            _shippingCosts = shippingCosts;
        }
        public double CalculateShippingCosts(double price) => _shippingCosts.CalculateShippingCosts(price);
    }
}
