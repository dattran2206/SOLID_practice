using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.SRP
{
    /// <Bài 1: Quản lý sản phẩm>
    /// Viết một hệ thống quản lý sản phẩm với các chức năng:
    /// 
    /// Thêm sản phẩm vào danh sách.
    /// Xuất báo cáo sản phẩm (ví dụ: xuất ra file CSV).
    /// Lưu thông tin sản phẩm vào cơ sở dữ liệu.
    /// 📝 Yêu cầu:
    /// 
    /// Viết code sao cho mỗi class chỉ có một trách nhiệm duy nhất.
    /// Không đặt toàn bộ logic trong một class duy nhất.
    /// </summary>
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, int qty, double price)
        {
            ProductID = id;
            ProductName = name;
            Qty = qty;
            Price = price;
        }
    }
    public class ProductRepository
    {
        private readonly List<Product> _products = new List<Product>();
        
        public void SaveProduct(Product product)
        {
            _products.Add(product);
            Console.WriteLine($"Product {product.ProductName} has been saved.");
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
    public class ProductExportReport
    {
        public void GenerateCSVReport(List<Product> Products, string FilePath)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.WriteLine("ProductID,ProductName,Qty, Price");
                foreach (var product in Products)
                {
                    writer.WriteLine($"{product.ProductID},{product.ProductName},{product.Qty},{product.Price}");
                }
                Console.WriteLine($"CSV Report has been generated at {FilePath}");
            }
        }
    }
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly ProductExportReport _productExportReport;

        public ProductService(ProductRepository Repository, ProductExportReport Report)
        {
            _productRepository = Repository;
            _productExportReport = Report;
        }

        public void AddProduct(Product Product)
        {
            _productRepository.SaveProduct(Product);
        }
        public void ExportReportCSV(string FilePath)
        {
            var products = _productRepository.GetAllProducts();
            _productExportReport.GenerateCSVReport(products, FilePath);
        }
    }
}
