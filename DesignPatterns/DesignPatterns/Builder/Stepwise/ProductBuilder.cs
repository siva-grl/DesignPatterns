using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Stepwise
{
    public class ProductBuilder
    {
        private Product product = new Product();

        public ProductBuilder SetName(string name)
        {
            product.Name = name;
            return this;
        }

        public ProductBuilder SetPrice(decimal price)
        {
            product.Price = price;
            return this;
        }

        public ProductBuilder SetDescription(string description)
        {
            product.Description = description;
            return this;
        }

        public ProductBuilder SetStock(int stock)
        {
            product.Stock = stock;
            return this;
        }

        public Product Build()
        {
            return product;
        }
    }
}
