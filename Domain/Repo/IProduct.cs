using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entite;

namespace Domain.Repo
{
    public interface IProduct
    {
        Product create(Product product);
        Product Get( );
        IEnumerable<Product> GetAll( );
        Product Update( Product product );
        void Delete(int id);
    }
}
