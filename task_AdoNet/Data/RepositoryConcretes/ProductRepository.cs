using Core.Models;
using Core.RepositoryAbstracts;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcretes 
{
    public class ProductRepository : IProductRepository
    {
        AppDbContext _appDbContext = new AppDbContext();
        public void Add(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public void Delete(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public Product Get(string command) 
        {
            var dt = _appDbContext.Query(command);
            Product product = null;
            foreach (DataRow item in dt.Rows)
            {
                product = new Product
                {
                    ProductID = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Price = decimal.Parse(item[2].ToString()),
                    Category = item[3].ToString()
                };
            }

            return product;
        }

        public List<Product> GetAll(string command)
        {
            var dt = _appDbContext.Query(command);
            List<Product> products = new List<Product>();

            foreach (DataRow item in dt.Rows)
            {
                Product product = new Product
                {
                    ProductID = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                    Price = decimal.Parse(item[2].ToString()),
                    Category = item[3].ToString()
                };

                products.Add(product);
            }

            return products;
        }

        public void Update(string command)
        {
            _appDbContext.NonQuery(command);
        }

    }
}
