using System;
using Practice.Models;

namespace Practice.Services
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        Product GetProductByName(string name);
        Product AddProduct(Product product);

        public Product UpdateProducts(Product product);
    }
}
