using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstracts
{
    public interface IProductService
    {

        void DeleteProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(int id, Product newProduct);

        Product GetProduct(int id);
        List<Product> GetAllProducts();












    }
}
