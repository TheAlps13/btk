using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IProductService productManager = new ProductManager(new EfProductDal());
            dgvProduct.DataSource = productManager.GetAllProducts().ToList();
        }
    }
}
