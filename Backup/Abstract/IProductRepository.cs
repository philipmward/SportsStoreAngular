using SportsStore.Data.Entities;
using System.Collections.Generic;

namespace SportsStore.Data.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}