using SOLID_Project.OCP.Exercise4_ShippingCosts.Context;
using SOLID_Project.OCP.Exercise4_ShippingCosts.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise4_ShippingCosts
{
    public static class OCP_Excute4_Process
    {
        public static void Process()
        {
            ShippingCostsContext GHN = new ShippingCostsContext(new GiaoHangNhanhCosts());
            Console.WriteLine($"The price of GHN is {GHN.CalculateShippingCosts(30000):#,##0} VND");

            ShippingCostsContext GHTK = new ShippingCostsContext(new GiaoHangTietKiemCosts());
            Console.WriteLine($"The price of GHN is {GHTK.CalculateShippingCosts(20000):#,##0} VND");

            ShippingCostsContext GHTC = new ShippingCostsContext(new GiaoHangTieuChuanCosts());
            Console.WriteLine($"The price of GHTC is {GHN.CalculateShippingCosts(10000):#,##0} VND");

            Console.WriteLine();
        }
    }
}
