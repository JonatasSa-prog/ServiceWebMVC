using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebServiceMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} Size should be between {2} and {1}")]
        public String Name { get; set; }

        [Required(ErrorMessage = "{0} Required")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Display(Name = "Birth Date")]
        [Required(ErrorMessage = "{0} Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]

        public DateTime Date { get; set; }
        [Required(ErrorMessage = "{0} Required")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        
        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime date, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            Sales.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            Sales.Remove(salesRecord);
        }

        public double TotalSales(DateTime ini, DateTime end)
        {
            return Sales.Where(p => p.Date >= ini && p.Date <= end).Sum(p => p.Amount);          
        }
    }
}
