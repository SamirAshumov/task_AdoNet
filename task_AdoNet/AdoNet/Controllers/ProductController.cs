using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Controllers
{
    public class ProductController
    {

        IProductService _productService = new ProductService();

        public void AddProduct()
        {
            Console.WriteLine("Enter product name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter product price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter product category: ");
            string category = Console.ReadLine();

            Product product = new Product()
            {
                Name = name,
                Price = price,
                Category = category
            };

            _productService.AddProduct(product);
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter product id: ");
            int id = int.Parse(Console.ReadLine());

            _productService.DeleteProduct(id);
        }

        public void UpdateProduct()
        {
            GetAllProducts();

            Console.WriteLine("Enter product id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new product name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter new product price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter new product category: ");
            string category = Console.ReadLine();

            Product newProduct = new Product()
            {
                Name = name,
                Price = price,
                Category = category
            };

            _productService.UpdateProduct(id, newProduct);
        }

        public void GetAllProducts()
        {
            foreach (var item in _productService.GetAllProducts())
            {
                Console.WriteLine($"{item.ProductID} - {item.Name} - {item.Price} - {item.Category}");
            }
        }

        public void GetProduct()
        {
            Console.WriteLine("Enter product id: ");
            int id = int.Parse(Console.ReadLine());

            Product product = _productService.GetProduct(id);

            Console.WriteLine($"{product.ProductID} - {product.Name} - {product.Price} - {product.Category}");
        }
    }
}
