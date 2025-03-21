using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Project.SRP
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
    public class EmployeeRepository
    {
        public void AddEmployee(Employee employee)
        {
            // Code to add employee
        }
        public void SaveEmployee(Employee employee)
        {
            // Code to save employee
        }
    }
    public class EmployeeReport
    {
        public void GenerateReport()
        {
            // Code to generate report
        }
    }

    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly EmployeeReport _employeeReport;

        public EmployeeService(EmployeeRepository repository, EmployeeReport report)
        {
            _employeeRepository = repository;
            _employeeReport = report;
        }
        public void ProcessEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
            _employeeRepository.SaveEmployee(employee);
            _employeeReport.GenerateReport();
        }
    }
}
