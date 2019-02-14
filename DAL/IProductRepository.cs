using System;
using Entities;
using System.Collections.Generic;

namespace DAL
{
    public interface IProductRepository
    {
        void Create(Product product);
        void Delete(Product product);
        //Product Get(Guid id);
        void Update(Product product);
        IEnumerable<Product> GetAll();


    }
}