﻿using a82.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace a82.Data
{
    public interface IProductRepository
    {
        Product InsertProduct(Product obj);

        List<Product> SelectAllProducts();

        List<Product> Filter(string jsonQuery);

        Product GetProduct(string id);

        Product UpdateProduct(string id, Product obj);

        bool RemoveProduct(string id);
    }
}
