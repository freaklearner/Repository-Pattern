using RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Model
{
    public class ProductImplementation : IProduct
    {
        ProductDbContext context;

        public ProductImplementation(ProductDbContext productDbContext)
        {
            context = productDbContext;
        }

        public IEnumerable<Product> Get()
        {
            return context.Products.ToList();
        }

        public Product Get(int id)
        {
            var product = context.Products.Find(id);
            return product;
        }

        public void Post(Product product)
        {
            context.Add(product);
            context.SaveChanges(true);
        }

        public bool Put(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        

        
    }
}
