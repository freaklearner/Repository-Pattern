using RepositoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> Get();

        Product Get(int id);

        void Post(Product product);

        bool Put(Product product);

        bool Delete(int id);
    }
}
