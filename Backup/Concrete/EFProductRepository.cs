using SportsStore.Data.Abstract;
using SportsStore.Data.Entities;
using System.Collections.Generic;

namespace SportsStore.Data.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return _context.Products; }
        }
    }
}