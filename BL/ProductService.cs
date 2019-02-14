using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Entities;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace BL
{

    public class ProductService //будет создавать обьект продукт и передавать в репозиторий
    {

        private IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product CreateProduct(string id,
                               string upc,
                               string name,
                               string category,
                               double height,
                               double width,
                               double depth,
                               decimal cost,
                               decimal price) //Данные, введенные пользователем
        {
            // get category from DB    Проверки сдесь

            Product product = new Product
            {
                Id = id,
                UPC = upc, // проверить на уникальность
                Name = name,
                Category = category,
                Height = height,
                Width = width,
                Depth = depth,
                Cost = cost,
                Price = price//Инициализируем
            };

            // проверить на наличие ид категории
            productRepository.Create(product);


            return product;
        }

        public Product DeleteProduct(string id) //Данные, введенные пользователем
        {
            // get category from DB    Проверки сдесь

            Product product = new Product
            {
                Id = id,
            };

            // проверить на наличие ид категории
            productRepository.Delete(product);


            return product;
        }

        public IEnumerable<Product> WiewAll()
        {
            return productRepository.GetAll();
        }


    }
}
