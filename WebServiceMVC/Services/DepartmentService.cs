using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceMVC.Models;

namespace WebServiceMVC.Services
{
    public class DepartmentService
    {
        private readonly WebServiceMVCContext _context;
        public DepartmentService(WebServiceMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(p => p.Name).ToList();
        }
    }
}
