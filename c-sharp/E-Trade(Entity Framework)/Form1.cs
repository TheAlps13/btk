using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Trade_Entity_Framework_
{
    public partial class Form1 : Form
    {
        private ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAllProducts();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.AddProduct(new Product()
            {
                Name = tbxName.Text,
                UnitPrice = Decimal.Parse(tbxUnitPrice.Text),
                StockAmount = Int32.Parse(tbxStockAmount.Text)
            });

            LoadProducts();
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            _productDal.UpdateProduct(new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Decimal.Parse(tbxUnitPriceUpdate.Text),
                StockAmount = Int32.Parse(tbxStockAmountUpdate.Text)
            });

            LoadProducts();
        }
        private void dgwProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            _productDal.DeleteProduct(new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });

            LoadProducts();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == String.Empty)
                LoadProducts();
            else
            {
                 dgwProducts.DataSource = _productDal.GetProductByName(tbxSearch.Text);
            }
        }
    }
}
