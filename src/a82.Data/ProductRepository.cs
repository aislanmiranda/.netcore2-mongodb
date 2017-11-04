using a82.Data.Mongo;
using a82.Domain;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace a82.Data
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository() : base("Products"){
        }
        public Product InsertProduct(Product obj)
        {
            return base.Insert(obj);
        }

        public List<Product> SelectAllProducts()
        {
            return base.SelectAll();//.Select(p => p as Product).ToList();
        }

        public new List<Product> Filter(string jsonQuery)
        {
            return base.Filter(jsonQuery);//.Select(p => p as Product).ToList();
        }

        public Product GetProduct(string id)
        {
            var result = base.Get(id);// as Product;

            return result as Product;
        }
        public Product UpdateProduct(string id, Product obj)
        {
            return base.Update(id, obj);// as Product;
        }

        public bool RemoveProduct(string id)
        {
            return base.Remove(id);
        }

    }
}
