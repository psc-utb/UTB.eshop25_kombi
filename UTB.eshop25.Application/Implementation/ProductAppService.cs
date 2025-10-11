using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.eshop25.Application.Abstraction;
using UTB.eshop25.Domain.Entities;
using UTB.eshop25.Infrastructure.Database;

namespace UTB.eshop25.Application.Implementation
{
    public class ProductAppService : IProductAppService
    {
        EshopDbContext _dbContext;
        public ProductAppService(EshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Product> SelectAll()
        {
            return _dbContext.Products.ToList();
        }
    }
}
