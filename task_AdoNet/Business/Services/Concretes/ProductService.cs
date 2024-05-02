using Business.Services.Abstracts;
using Core.Models;
using Data.RepositoryConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
    public class ProductService : IProductService
    {

        ProductRepository _productRepository = new ProductRepository();
        public void AddProduct(Product product)
        {
            string command = $"Insert Into Products (Name, Price, Category) values ('{product.Name}','{product.Price}','{product.Category}')";
            _productRepository.Add(command);
        }

        public void DeleteProduct(int id)
        {
            string command = $"DELETE FROM Products WHERE Id = {id}";
            _productRepository.Delete(command);
        }

        public List<Product> GetAllProducts()
        {
            string command = "SELECT * FROM Products";
            return _productRepository.GetAll(command);
        }

        public Product GetProduct(int id)
        {
            string command = $"SELECT * FROM Products WHERE Id = {id}";
            return _productRepository.Get(command);
        }

        public void UpdateProduct(int id, Product newProduct)
        {
            string command = $"SELECT * FROM Products WHERE Id = {id}";
            Product product = _productRepository.Get(command);

            if (product == null) throw new NullReferenceException();

            product.Name = newProduct.Name;
            product.Price = newProduct.Price;
            product.Category = newProduct.Category;

            string updateCommand = $"UPDATE Products SET Name = '{product.Name}', Price = '{product.Price}', Category = '{product.Category}' WHERE Id = {id}";
            _productRepository.Update(updateCommand);
        }

    }
}
