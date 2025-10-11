using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.eshop25.Domain.Entities;

namespace UTB.eshop25.Infrastructure.Database
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EshopDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }
    }
}
