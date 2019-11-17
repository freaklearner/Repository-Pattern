using RepositoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Interfaces
{
    interface IProduct
    {
        IEnumerable<Product> Get();

        Product Get(int id);

        bool Post(Product product);

        bool Put(Product product);

        bool Delete(int id);
    }
}
