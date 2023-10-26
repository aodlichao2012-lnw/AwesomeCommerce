using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entite;
using Domain.Repo;

namespace Data.Repo
{
    public class ProductRepository : IProduct
    {
        public readonly ProductingContext ProductingContexts;
        public ProductRepository(ProductingContext producting) {

            ProductingContexts = producting;
        }
        public Product create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
