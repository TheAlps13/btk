using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFranework;
using Northwind.Entities.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        IProductService _productService = new ProductManager(new EfProductDal());
        ICategoryService _categorService = new CategoryManager(new EfCategoryDal());
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAllProducts().ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategoryName_search.DataSource = _categorService.GetAll();
            cbxCategoryName_search.DisplayMember = "CategoryName";
            cbxCategoryName_search.ValueMember = "CategoryId";

            cbxCategoryName_add_update.DataSource = _categorService.GetAll();
            cbxCategoryName_add_update.DisplayMember = "CategoryName";
            cbxCategoryName_add_update.ValueMember = "CategoryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory((int)cbxCategoryName_search.SelectedValue);
            }
            catch (Exception ex)
            {

            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            string productName = tbxProductName_search.Text;
            if (productName == null)
                dgwProduct.DataSource = _productService.GetAllProducts();
            else
                dgwProduct.DataSource = _productService.GetProductsByName(productName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.AddProduct(new Product
            {
                ProductName = tbxProductName_add_update.Text,
                CategoryId = (int)cbxCategoryName_add_update.SelectedValue,
                UnitPrice = Convert.ToInt32(tbxQuantityPerUnit_add_update.Text),
                QuantityPerUnit = tbxQuantityPerUnit_add_update.Text,
                UnitsInStock = Convert.ToInt16(tbxUnitsInStock_add_update.Text)
            });
            LoadProducts();
        }

        private void dgvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dgvSelectedRow = dgwProduct.CurrentRow.Cells;
            tbxProductName_add_update.Text = dgvSelectedRow[2].Value.ToString();
            tbxQuantityPerUnit_add_update.Text = dgvSelectedRow[4].Value.ToString();
            tbxUnitPrice_add_update.Text = dgvSelectedRow[3].Value.ToString();
            tbxUnitsInStock_add_update.Text = dgvSelectedRow[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.UpdateProduct(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProductName_add_update.Text,
                CategoryId = Convert.ToInt32(cbxCategoryName_add_update.SelectedValue),
                QuantityPerUnit = tbxQuantityPerUnit_add_update.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice_add_update.Text),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStock_add_update.Text)
            });
            LoadProducts();
        }
    }
}
