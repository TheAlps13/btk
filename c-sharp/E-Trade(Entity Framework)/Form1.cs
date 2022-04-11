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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(ETradeContext eTradeContext = new ETradeContext())
            {
                dgwProducts.DataSource = eTradeContext.Products.ToList();
                eTradeContext.SaveChanges();
            }
        }
    }
}
