namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategoryName_search = new System.Windows.Forms.GroupBox();
            this.cbxCategoryName_search = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName_search = new System.Windows.Forms.GroupBox();
            this.tbxProductName_search = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductName_add = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitPrice_add_update = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit_add_update = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStock_add_update = new System.Windows.Forms.TextBox();
            this.cbxCategoryName_add_update = new System.Windows.Forms.ComboBox();
            this.tbxProductName_add_update = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUnitPrice_add = new System.Windows.Forms.Label();
            this.lblUnitsInStock_add = new System.Windows.Forms.Label();
            this.lblCategoryName_add = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit_add = new System.Windows.Forms.Label();
            this.lblProductName_add = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategoryName_search.SuspendLayout();
            this.gbxProductName_search.SuspendLayout();
            this.gbxProductName_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 220);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowTemplate.Height = 25;
            this.dgwProduct.Size = new System.Drawing.Size(616, 197);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_RowHeaderMouseClick);
            // 
            // gbxCategoryName_search
            // 
            this.gbxCategoryName_search.Controls.Add(this.cbxCategoryName_search);
            this.gbxCategoryName_search.Controls.Add(this.lblCategory);
            this.gbxCategoryName_search.Location = new System.Drawing.Point(12, 12);
            this.gbxCategoryName_search.Name = "gbxCategoryName_search";
            this.gbxCategoryName_search.Size = new System.Drawing.Size(248, 85);
            this.gbxCategoryName_search.TabIndex = 1;
            this.gbxCategoryName_search.TabStop = false;
            this.gbxCategoryName_search.Text = "Search by category";
            // 
            // cbxCategoryName_search
            // 
            this.cbxCategoryName_search.FormattingEnabled = true;
            this.cbxCategoryName_search.Location = new System.Drawing.Point(111, 37);
            this.cbxCategoryName_search.Name = "cbxCategoryName_search";
            this.cbxCategoryName_search.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoryName_search.TabIndex = 4;
            this.cbxCategoryName_search.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 42);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(99, 15);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category Name : ";
            // 
            // gbxProductName_search
            // 
            this.gbxProductName_search.Controls.Add(this.tbxProductName_search);
            this.gbxProductName_search.Controls.Add(this.lblProductName);
            this.gbxProductName_search.Location = new System.Drawing.Point(12, 124);
            this.gbxProductName_search.Name = "gbxProductName_search";
            this.gbxProductName_search.Size = new System.Drawing.Size(248, 90);
            this.gbxProductName_search.TabIndex = 0;
            this.gbxProductName_search.TabStop = false;
            this.gbxProductName_search.Text = "Search by product name";
            // 
            // tbxProductName_search
            // 
            this.tbxProductName_search.Location = new System.Drawing.Point(111, 43);
            this.tbxProductName_search.Name = "tbxProductName_search";
            this.tbxProductName_search.Size = new System.Drawing.Size(121, 23);
            this.tbxProductName_search.TabIndex = 4;
            this.tbxProductName_search.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 46);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(90, 15);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name :";
            // 
            // gbxProductName_add
            // 
            this.gbxProductName_add.Controls.Add(this.btnUpdate);
            this.gbxProductName_add.Controls.Add(this.tbxUnitPrice_add_update);
            this.gbxProductName_add.Controls.Add(this.tbxQuantityPerUnit_add_update);
            this.gbxProductName_add.Controls.Add(this.tbxUnitsInStock_add_update);
            this.gbxProductName_add.Controls.Add(this.cbxCategoryName_add_update);
            this.gbxProductName_add.Controls.Add(this.tbxProductName_add_update);
            this.gbxProductName_add.Controls.Add(this.btnAdd);
            this.gbxProductName_add.Controls.Add(this.lblUnitPrice_add);
            this.gbxProductName_add.Controls.Add(this.lblUnitsInStock_add);
            this.gbxProductName_add.Controls.Add(this.lblCategoryName_add);
            this.gbxProductName_add.Controls.Add(this.lblQuantityPerUnit_add);
            this.gbxProductName_add.Controls.Add(this.lblProductName_add);
            this.gbxProductName_add.Location = new System.Drawing.Point(377, 12);
            this.gbxProductName_add.Name = "gbxProductName_add";
            this.gbxProductName_add.Size = new System.Drawing.Size(251, 202);
            this.gbxProductName_add.TabIndex = 2;
            this.gbxProductName_add.TabStop = false;
            this.gbxProductName_add.Text = "Add Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(131, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitPrice_add_update
            // 
            this.tbxUnitPrice_add_update.Location = new System.Drawing.Point(124, 112);
            this.tbxUnitPrice_add_update.Name = "tbxUnitPrice_add_update";
            this.tbxUnitPrice_add_update.Size = new System.Drawing.Size(121, 23);
            this.tbxUnitPrice_add_update.TabIndex = 10;
            // 
            // tbxQuantityPerUnit_add_update
            // 
            this.tbxQuantityPerUnit_add_update.Location = new System.Drawing.Point(124, 82);
            this.tbxQuantityPerUnit_add_update.Name = "tbxQuantityPerUnit_add_update";
            this.tbxQuantityPerUnit_add_update.Size = new System.Drawing.Size(121, 23);
            this.tbxQuantityPerUnit_add_update.TabIndex = 9;
            // 
            // tbxUnitsInStock_add_update
            // 
            this.tbxUnitsInStock_add_update.Location = new System.Drawing.Point(124, 141);
            this.tbxUnitsInStock_add_update.Name = "tbxUnitsInStock_add_update";
            this.tbxUnitsInStock_add_update.Size = new System.Drawing.Size(121, 23);
            this.tbxUnitsInStock_add_update.TabIndex = 8;
            // 
            // cbxCategoryName_add_update
            // 
            this.cbxCategoryName_add_update.FormattingEnabled = true;
            this.cbxCategoryName_add_update.Location = new System.Drawing.Point(124, 51);
            this.cbxCategoryName_add_update.Name = "cbxCategoryName_add_update";
            this.cbxCategoryName_add_update.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoryName_add_update.TabIndex = 7;
            // 
            // tbxProductName_add_update
            // 
            this.tbxProductName_add_update.Location = new System.Drawing.Point(124, 19);
            this.tbxProductName_add_update.Name = "tbxProductName_add_update";
            this.tbxProductName_add_update.Size = new System.Drawing.Size(121, 23);
            this.tbxProductName_add_update.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUnitPrice_add
            // 
            this.lblUnitPrice_add.AutoSize = true;
            this.lblUnitPrice_add.Location = new System.Drawing.Point(12, 115);
            this.lblUnitPrice_add.Name = "lblUnitPrice_add";
            this.lblUnitPrice_add.Size = new System.Drawing.Size(64, 15);
            this.lblUnitPrice_add.TabIndex = 3;
            this.lblUnitPrice_add.Text = "Unit Price :";
            // 
            // lblUnitsInStock_add
            // 
            this.lblUnitsInStock_add.AutoSize = true;
            this.lblUnitsInStock_add.Location = new System.Drawing.Point(12, 144);
            this.lblUnitsInStock_add.Name = "lblUnitsInStock_add";
            this.lblUnitsInStock_add.Size = new System.Drawing.Size(85, 15);
            this.lblUnitsInStock_add.TabIndex = 4;
            this.lblUnitsInStock_add.Text = "Units In Stock :";
            // 
            // lblCategoryName_add
            // 
            this.lblCategoryName_add.AutoSize = true;
            this.lblCategoryName_add.Location = new System.Drawing.Point(12, 54);
            this.lblCategoryName_add.Name = "lblCategoryName_add";
            this.lblCategoryName_add.Size = new System.Drawing.Size(96, 15);
            this.lblCategoryName_add.TabIndex = 4;
            this.lblCategoryName_add.Text = "Category Name :";
            // 
            // lblQuantityPerUnit_add
            // 
            this.lblQuantityPerUnit_add.AutoSize = true;
            this.lblQuantityPerUnit_add.Location = new System.Drawing.Point(12, 85);
            this.lblQuantityPerUnit_add.Name = "lblQuantityPerUnit_add";
            this.lblQuantityPerUnit_add.Size = new System.Drawing.Size(104, 15);
            this.lblQuantityPerUnit_add.TabIndex = 5;
            this.lblQuantityPerUnit_add.Text = "Quantity Per Unit :";
            // 
            // lblProductName_add
            // 
            this.lblProductName_add.AutoSize = true;
            this.lblProductName_add.Location = new System.Drawing.Point(12, 22);
            this.lblProductName_add.Name = "lblProductName_add";
            this.lblProductName_add.Size = new System.Drawing.Size(90, 15);
            this.lblProductName_add.TabIndex = 3;
            this.lblProductName_add.Text = "Product Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 429);
            this.Controls.Add(this.gbxProductName_add);
            this.Controls.Add(this.gbxProductName_search);
            this.Controls.Add(this.gbxCategoryName_search);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategoryName_search.ResumeLayout(false);
            this.gbxCategoryName_search.PerformLayout();
            this.gbxProductName_search.ResumeLayout(false);
            this.gbxProductName_search.PerformLayout();
            this.gbxProductName_add.ResumeLayout(false);
            this.gbxProductName_add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategoryName_search;
        private System.Windows.Forms.ComboBox cbxCategoryName_search;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName_search;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxProductName_search;
        private System.Windows.Forms.GroupBox gbxProductName_add;
        private System.Windows.Forms.Label lblProductName_add;
        private System.Windows.Forms.Label lblCategoryName_add;
        private System.Windows.Forms.Label lblQuantityPerUnit_add;
        private System.Windows.Forms.TextBox tbxUnitPrice_add_update;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit_add_update;
        private System.Windows.Forms.TextBox tbxUnitsInStock_add_update;
        private System.Windows.Forms.ComboBox cbxCategoryName_add_update;
        private System.Windows.Forms.TextBox tbxProductName_add_update;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblUnitPrice_add;
        private System.Windows.Forms.Label lblUnitsInStock_add;
        private System.Windows.Forms.Button btnUpdate;
    }
}
