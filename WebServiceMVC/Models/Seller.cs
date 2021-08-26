using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime Date { get; set; }
        public double BaseSalary { get; set; }

        public Seller(int id, string name, string email, DateTime date, double baseSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
            BaseSalary = baseSalary;
        }

        //public void addSales()
    }
}
