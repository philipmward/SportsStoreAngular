using SportsStore.Data.Entities;
using System.Data.Entity;

namespace SportsStore.Data.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}