using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.SRP
{
    /// <Bài 2: Hệ thống gửi email>
    /// Hệ thống cần có chức năng:
    /// 
    /// Gửi email đến khách hàng.
    /// Ghi log mỗi lần gửi email.
    /// Kiểm tra email hợp lệ trước khi gửi.
    /// 📝 Yêu cầu:
    /// 
    /// Không viết tất cả logic vào một class EmailService.
    /// Viết các class riêng biệt, mỗi class chỉ có một trách nhiệm.
    /// </summary>

    // 1. Chứa thông tin mail
    public class Email
    {
        public int EmailID { get; set; }
        public string EmailSender { get; set; }
        public string EmailReceiver { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public Email(int id, string send, string received, string subject, string body)
        {
            EmailID = id;
            EmailSender = send;
            EmailReceiver = received;
            EmailSubject = subject;
            EmailBody = body;
        }
    }

    // 2. Kiểm tra tính hợp lệ của mail
    public class EmailValidator
    {
        public bool IsValid(Email email)
        {
            return IsValidMailAddress(email.EmailSender) && IsValidMailAddress(email.EmailReceiver);
        }
        public bool IsValidMailAddress(string Email)
        {
            try
            {
                var EmailAddress = new MailAddress(Email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    // 3. Gửi mail
    public class EmailSender
    {
        public void SendEmail(Email email)
        {
            Console.WriteLine($"Email {email.EmailSubject} has been sent from {email.EmailSender} to {email.EmailReceiver}");
        }
    }

    // 4. Email logger
    public class EmailLogger
    {
        public void LogEmail(Email email)
        {
            Console.WriteLine($"LOG: Email \"{email.EmailSubject}\" sent from {email.EmailSender} to {email.EmailReceiver}.");
        }
    }

    // 5. Lưu trữ mail
    public class EmailRepository
    {
        private readonly List<Email> _emails = new List<Email>();
        public void SaveEmail(Email email)
        {
            _emails.Add(email);
            Console.WriteLine($"Email {email.EmailSubject} has been saved.");
        }
        public List<Email> GetAllEmails()
        {
            return _emails;
        }
    }

    // 6. Thao tác liên quan với mail
    public class EmailService
    {
        private readonly EmailRepository _repository;
        private readonly EmailSender _sender;
        private readonly EmailValidator _validator;
        private readonly EmailLogger _logger;

        public EmailService(EmailRepository repository, EmailSender sender, EmailValidator validator, EmailLogger logger)
        {
            _repository = repository;
            _sender = sender;
            _validator = validator;
            _logger = logger;
        }

        public void ProcessEmail(Email email)
        {
            if (_validator.IsValid(email))
            {
                _sender.SendEmail(email);
                _repository.SaveEmail(email);
                _logger.LogEmail(email);
            }
            else
            {
                Console.WriteLine("Email is not valid.");
            }
        }
    }
}
