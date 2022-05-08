using Northwind.Business.Concrete;
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
            ProductManager productManager = new ProductManager();
            dgvProduct.DataSource = productManager.GetAllProducts().ToList();
        }
    }
}
