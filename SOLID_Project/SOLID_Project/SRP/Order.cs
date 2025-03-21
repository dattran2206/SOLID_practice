using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.SRP
{
    /// <Bài 4: Hệ thống quản lý đơn hàng>
    /// Viết một hệ thống với các chức năng:
    /// 
    /// Tạo đơn hàng từ danh sách sản phẩm.
    /// Lưu đơn hàng vào database.
    /// Gửi thông báo cho khách hàng sau khi đặt hàng thành công.
    /// 📝 Yêu cầu:
    /// 
    /// Mỗi class chỉ có một trách nhiệm duy nhất.
    /// Sử dụng Dependency Injection nếu cần.
    /// </summary>
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderName { get; set; }
        public List<Product> Products { get; set; }

        public Order(int orderID, string orderName, List<Product> products)
        {
            OrderID = orderID;
            OrderName = orderName;
            Products = products;
        }
    }

    public interface IOrderRepository
    {
        public void SaveOrder(Order order);
        public List<Order> GetAllOrders();
    }

    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new List<Order>();
        public void SaveOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            _orders.Add(order);
            Console.WriteLine($"Order {order.OrderName} has been saved.");
        }
        public List<Order> GetAllOrders()
        {
            return _orders;
        }
    }

    public interface IOrderNotification
    {
        public void SendNotification(Order order, Email email);
    }

    public class OrderEmailNotification : IOrderNotification
    {
        private readonly EmailService _emailService;
        public OrderEmailNotification(EmailService emailService)
        {
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService)); ;
        }
        public void SendNotification(Order order, Email email)
        {
            if (order == null || email == null)
            {
                throw new ArgumentNullException("Order or Email cannot be null.");
            }
            _emailService.ProcessEmail(email);
            Console.WriteLine($"Notification has been sent for {email.EmailReceiver} about order {order.OrderName}");
        }
    }

    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderNotification _orderNotification;
        public OrderService(IOrderRepository orderRepository, IOrderNotification orderNotification)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _orderNotification = orderNotification ?? throw new ArgumentNullException(nameof(orderNotification));
        }
        public void CreateOrder(Order order, Email email)
        {
            if (order == null || email == null)
            {
                throw new ArgumentNullException("Order or Email cannot be null.");
            }
            _orderRepository.SaveOrder(order);
            _orderNotification.SendNotification(order, email);
        }
    }
}
