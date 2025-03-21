using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise4_ShippingCosts.Interfaces
{
    public interface IShippingCosts
    {
        public double CalculateShippingCosts(double price);
    }
}
