using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entities;
using DAL;
using BL;
using System.Data.Entity.SqlServer;
using System.Data.Entity;

namespace MerchGod
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please select an action:");
                Console.WriteLine("1. Create Product");
                Console.WriteLine("2. Delete Product");
                Console.WriteLine("3. Update Product (not release)");
                Console.WriteLine("4. View oll products");
                Console.WriteLine("5. Exit");
                string action = Console.ReadLine();

                ProductRepository productRepository = new ProductRepository();
                ProductService productService = new ProductService(productRepository);


                switch (action)
                {
                    case "1":
                        Console.WriteLine("Enter Product ID");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter Product UPC");
                        string upc = Console.ReadLine();
                        Console.WriteLine("Enter Product Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Product Category");
                        string category = Console.ReadLine();
                        Console.WriteLine("Enter Product Height");
                        double height = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Width");
                        double width = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Depth");
                        double depth = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Cost");
                        decimal cost = Decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Price");
                        decimal price = Decimal.Parse(Console.ReadLine());


                        //Product product = new Product(); лишнее

                        //productRepository.Create(product);

                        // создать экземпляр класса продукт и к нему вызвать метод ниже
                        //productService
                        //трай

                        productService.CreateProduct(id,
                                    upc,
                                    name,
                                    category,
                                    height,
                                    width,
                                    depth,
                                    cost,
                                    price); //Данные, введенные пользователем

                        //кетч
                        break;

                    case "2":
                        Console.WriteLine("Enter Product ID");
                        string id_del = Console.ReadLine();

                        productService.DeleteProduct(id_del);
                        break;

                    case "3":
                        Console.WriteLine("OOps)");
                        break;

                    //case "4":
                    //    productService.WiewAll();
                    //    break;

                    case "5":
                        Console.WriteLine("Good bay");
                        Thread.Sleep(3000);
                        return;

                }
            }
        }
    }
}
