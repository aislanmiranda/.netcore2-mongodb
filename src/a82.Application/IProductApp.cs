using a82.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace a82.Application
{
    public interface IProductApp
    {
        List<Product> GetAll();
        Product Get(string objectId);
        Product Insert(Product entity);
        Product Update(Product entity);
        bool Delete(string id);
    }
}
