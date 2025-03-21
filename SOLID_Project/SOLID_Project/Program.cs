using SOLID_Project;
using SOLID_Project.OCP.Exercise1_Tax;
using SOLID_Project.SRP;

//#region Bài 1: Quản lý sản phẩm
//// Khởi tạo các thành phần cần thiết
//ProductRepository productRepository = new ProductRepository();
//ProductExportReport productExportReport = new ProductExportReport();
//ProductService productService = new ProductService(productRepository, productExportReport);

//productService.AddProduct(new Product(1, "Laptop", 10, 10000));
//productService.AddProduct(new Product(2, "Mouse", 11, 500));
//productService.AddProduct(new Product(3, "keyboard", 12, 600));
//productService.AddProduct(new Product(4, "Monitor", 13, 1500));

////productService.ExportReportCSV("C:\\dattt\\LEARN\\SOLID_Project\\ProductReport.csv");
//#endregion

//#region Bài 3: Hệ thống thanh toán
//// Khởi tạo các thành phần cần thiết
//PaymentCalculator calculator = new PaymentCalculator();
//PaymentRepository repository = new PaymentRepository();
//EmailService emailService = new EmailService(new EmailRepository(), new EmailSender(), new EmailValidator(), new EmailLogger());
//PaymentEmailInvoice emailInvoice = new PaymentEmailInvoice(emailService);

//// Chọn phương thức thanh toán (có thể đổi sang Stripe, MoMo, VNPay, v.v.)
//IPaymentGateway paymentGateway = new PayPal();

//// Khởi tạo dịch vụ thanh toán
//PaymentService paymentService = new PaymentService(calculator, repository, emailInvoice, paymentGateway);

//// Tạo sản phẩm và thanh toán
//List<Product> products = productRepository.GetAllProducts();
//Payment payment = new Payment(1, "Order #001", products);
//Email email = new Email(1, "seller@example.com", "buyer@example.com", "Payment Invoice", "Your invoice is attached.");

//// Xử lý thanh toán
//paymentService.Process(payment, email);
//#endregion
MainProcess.Process();

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();