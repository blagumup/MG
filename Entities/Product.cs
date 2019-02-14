using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string UPC { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
    }

    public class Planogramm
    {
        public Guid id { get; set; }
        public string Name { get; set; }
    }

    public class Stand
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
    }

    public class Shelf
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
    }



}
