using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entities;
using BL;

namespace MG_WindowsForms
{
    public partial class ProductListForm : Form
    {
        ProductService productService;

        public ProductListForm()
        {

            InitializeComponent();

            ProductRepository productRepository = new ProductRepository();
            productService = new ProductService(productRepository);

            

            ProductListData.DataSource = productService.WiewAll(); //Достаем список из базы данных
            //ProductListData.SelectedCells[0].OwningRow.DataBoundItem // Это продукт
        }

        
    }
}
