using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise1_Tax.Interfaces
{
    public interface ITaxCaculator
    {
        public double CalculateTax(double income);
    }
}
