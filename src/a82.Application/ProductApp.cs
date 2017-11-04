using a82.Data;
using a82.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a82.Application
{
    public class ProductApp : IProductApp
    {
        private IProductRepository _repo;

        public ProductApp(IProductRepository repo)
        {
            _repo = repo;
        }

        public List<Product> GetAll()
        {
            var all = _repo.SelectAllProducts();

            return all;
        }

        public Product Get(string objectId)
        {
            return _repo.GetProduct(objectId);
        }

        public Product Insert(Product entity)
        {
            return _repo.InsertProduct(entity);
        }

        public Product Update(Product entity)
        {
            return _repo.UpdateProduct(entity._id, entity);
        }

        public bool Delete(string id)
        {
            return _repo.RemoveProduct(id);
        }
    }
}
