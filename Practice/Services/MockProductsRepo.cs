using Practice.Services;
using Practice.Models;
using Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Services
{
    public class MockProductsRepo: IProductRepo
    {
        public List<Product> Products { get; set; }

        public MockProductsRepo()
        {
            Products = new List<Product>()
            {
                new Product(){
                    Id = 1,
                    ProductName = "MacBook Pro",
                    ShortDescription = "Best Laptop For iOS Development",
                    Price = 245000
                },
                new Product(){
                    Id = 2,
                    ProductName = "iPhone Max Pro",
                    ShortDescription = "Best Smart Phone",
                    Price = 115000
                }
            };
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return Products;
        }

        public Product GetProductById(int id)
        {
            var product = Products.SingleOrDefault(p => p.Id == id);
            return product;
        }

        public Product GetProductByName(string name)
        {
            var product = Products.SingleOrDefault(p => p.ProductName.Equals(name));
            return product;
        }

        public Product AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProducts(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
