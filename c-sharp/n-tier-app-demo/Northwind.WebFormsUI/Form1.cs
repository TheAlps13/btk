using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFranework;
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
            cbxCategory.DataSource = _categorService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.DataSource = _productService.GetProductByCategoryId((int)cbxCategory.SelectedValue);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
