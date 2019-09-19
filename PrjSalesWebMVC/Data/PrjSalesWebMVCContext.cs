using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PrjSalesWebMVC.Models
{
    public class PrjSalesWebMVCContext : DbContext
    {
        public PrjSalesWebMVCContext (DbContextOptions<PrjSalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PrjSalesWebMVC.Models.Department> Department { get; set; }
    }
}
