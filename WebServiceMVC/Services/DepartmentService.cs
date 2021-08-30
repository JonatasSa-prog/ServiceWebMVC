using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace WebServiceMVC.Services
{
    public class DepartmentService
    {
        private readonly WebServiceMVCContext _context;
        public DepartmentService(WebServiceMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(p => p.Name).ToListAsync();
        }
    }
}
