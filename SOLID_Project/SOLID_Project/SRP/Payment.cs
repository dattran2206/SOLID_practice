using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SOLID_Project.SRP
{
    /// <Bài 3: Hệ thống thanh toán>
    /// Viết hệ thống thanh toán với các chức năng:
    /// 
    /// Tính tổng tiền dựa vào danh sách sản phẩm.
    /// Xử lý thanh toán qua nhiều cổng(PayPal, Stripe, MoMo, VNPay).
    /// Gửi hóa đơn đến email khách hàng.
    /// 📝 Yêu cầu:
    /// 
    /// Viết code sao cho có thể dễ dàng thêm cổng thanh toán mới mà không sửa code cũ.
    /// Tách biệt các chức năng khác nhau (tính toán, xử lý thanh toán, gửi hóa đơn).
    /// </summary>

    // 1. Thông tin thanh toán
    public class Payment
    {
        public int PaymentID { get; set; }
        public string PaymentSubject { get; set; }
        public List<Product> Products { get; set; }
        public Payment(int id, string subject, List<Product> products)
        {
            PaymentID = id;
            PaymentSubject = subject;
            Products = products;
        }
    }

    // 2 . Tính tổng tiền
    public class PaymentCalculator
    {
        public double CalculateTotal(List<Product> products)
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price * product.Qty;
            }
            return total;
        }
    }

    // 3. Xử lý thanh toán qua nhiều cổng
    public interface IPaymentGateway
    {
        public void ProcessPayment(Payment payment);
    }

    public class PayPal : IPaymentGateway
    {
        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine($"Payment {payment.PaymentID} has been processed via PayPal.");
        }
    }
    public class Stripe : IPaymentGateway
    {
        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine($"Payment {payment.PaymentID} has been processed via Stripe.");
        }
    }
    public class MoMo : IPaymentGateway
    {
        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine($"Payment {payment.PaymentID} has been processed via MoMo.");
        }
    }
    public class VNPay : IPaymentGateway
    {
        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine($"Payment {payment.PaymentID} has been processed via VNPay.");
        }
    }

    // 4. Gửi mail hoá đơn
    public class PaymentEmailInvoice
    {
        private readonly EmailService _emailService;
        public PaymentEmailInvoice(EmailService emailService)
        {
            _emailService = emailService;
        }
        public void SendInvoice(Payment payment, Email email, double totalPrice)
        {
            Console.WriteLine($"Invoice for payment '{payment.PaymentSubject}' sent to {email.EmailReceiver}. Total amount: {totalPrice}");

            _emailService.ProcessEmail(email);
        }
    }

    // 5. Lưu trữ thông tin thanh toán
    public class PaymentRepository
    {
        private readonly List<Payment> _payments = new List<Payment>();
        public void SavePayment(Payment payment)
        {
            _payments.Add(payment);
            Console.WriteLine($"Payment {payment.PaymentSubject} has been saved.");
        }
        public List<Payment> GetAllPayments()
        {
            return _payments;
        }
    }

    // 6. Thao tác liên quan đến thanh toán
    public class PaymentService
    {
        private readonly PaymentCalculator _paymentCalculator;
        private readonly PaymentRepository _paymentRepository;
        private readonly PaymentEmailInvoice _emailInvoice;
        private readonly IPaymentGateway _paymentGateway;
        public PaymentService(PaymentCalculator calculator, PaymentRepository repository, PaymentEmailInvoice emailInvoice, IPaymentGateway paymentGateway)
        {
            _paymentCalculator = calculator;
            _paymentRepository = repository;
            _emailInvoice = emailInvoice;
            _paymentGateway = paymentGateway;
        }
        public void Process(Payment payment, Email email)
        {
            double totalPrice = _paymentCalculator.CalculateTotal(payment.Products);

            _paymentGateway.ProcessPayment(payment);
            _emailInvoice.SendInvoice(payment, email, totalPrice);
            _paymentRepository.SavePayment(payment);
        }
    }
}
