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
            dgvProduct.DataSource = _productService.GetAllProducts().ToList();
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

            cbxCategoryName_add.DataSource = _categorService.GetAll();
            cbxCategoryName_add.DisplayMember = "CategoryName";
            cbxCategoryName_add.ValueMember = "CategoryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.DataSource = _productService.GetProductsByCategory((int)cbxCategoryName_search.SelectedValue);
            }
            catch (Exception ex)
            {

            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            string productName = tbxProductName_search.Text;
            if (productName == null)
                dgvProduct.DataSource = _productService.GetAllProducts();
            else
                dgvProduct.DataSource = _productService.GetProductsByName(productName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.AddProduct(new Product
            {
                ProductName = tbxProductName_add.Text,
                CategoryId = (int)cbxCategoryName_add.SelectedValue,
                UnitPrice = Convert.ToInt32(tbxQuantityPerUnit_add.Text),
                QuantityPerUnit = tbxQuantityPerUnit_add.Text,
                UnitsInStock = Convert.ToInt16(tbxUnitsInStock_add.Text)
            });
            LoadProducts();
        }
    }
}
