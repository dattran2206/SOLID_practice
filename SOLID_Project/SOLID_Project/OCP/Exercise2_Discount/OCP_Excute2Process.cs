using SOLID_Project.OCP.Exercise2_Discount.Context;
using SOLID_Project.OCP.Exercise2_Discount.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.OCP.Exercise2_Discount
{
    public static class OCP_Excute2Process
    {
        public static void Process()
        {
            Console.Write("Nhap tong tien tren hoa don: ");
            double totalPrice = Convert.ToDouble(Console.ReadLine());

            //Khách thường
            DiscountContext customer = new DiscountContext(new CustomerDiscount());
            Console.WriteLine($"Khach hang thuong duoc giam gia: {customer.GetDiscount(totalPrice)} VND");

            //Khách VIP
            DiscountContext vip = new DiscountContext(new VIPDiscount());
            Console.WriteLine($"Khach hang VIP duoc giam gia: {vip.GetDiscount(totalPrice)} VND");

            //Khách SuperVIP
            DiscountContext superVip = new DiscountContext(new SuperVIPDiscount());
            Console.WriteLine($"Khach hang SuperVIP duoc giam gia: {superVip.GetDiscount(totalPrice)} VND");
            Console.WriteLine();
        }
    }
}
