using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebServiceMVC.Models;

namespace WebServiceMVC.Models
{
    public class WebServiceMVCContext : DbContext
    {
        public WebServiceMVCContext (DbContextOptions<WebServiceMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebServiceMVC.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
