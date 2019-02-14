using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using System.IO;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace DAL
{
    public class ProductRepository : IProductRepository
    {
        public void Create(Product product)
        {

            using (ProductContext db = new ProductContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
                Console.WriteLine("Продукт успешно сохранен");
            }

            //string CurrentFile = "C:\\123.txt";
            //using (FileStream stream = File.Open(CurrentFile, FileMode.Append))
            //{
            //    using (BinaryWriter writter = new BinaryWriter(stream))
            //    {
            //        writter.Write(product.Id);
            //        writter.Write(product.UPC);
            //        writter.Write(product.Name);
            //        writter.Write(product.Category);
            //        writter.Write(product.Height);
            //        writter.Write(product.Width);
            //        writter.Write(product.Depth);
            //        writter.Write(product.Cost);
            //        writter.Write(product.Price);
            //    }
            //}
        }

        public void Delete(Product product)
        {
            using (ProductContext db = new ProductContext())
            {
                db.Products.Attach(product);
                db.Products.Remove(product);
                db.SaveChanges();
                Console.WriteLine("Продукт успешно удален");
            }
        }
        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            using (ProductContext db = new ProductContext())
            {
                var products = from p in db.Products
                               select p;

                return products.ToList();
                //foreach (var p in products)
                //    Console.WriteLine("{0} {1} {2} {3} {4}uah {5}uah", p.Id, p.UPC, p.Name, p.Category, p.Cost, p.Price);
            }
        }

        
        //public Product Get(Guid id) //Возвращает данные о продукте
        //{
        //    throw new NotImplementedException();
        //}
    }
}
