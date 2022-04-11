
namespace E_Trade_Entity_Framework_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(442, 198);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(82, 158);
            this.btnDeleteProduct.TabIndex = 13;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdateProduct);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(248, 193);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(188, 163);
            this.gbxUpdate.TabIndex = 12;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update product";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(117, 108);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(59, 42);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(91, 19);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(86, 20);
            this.tbxNameUpdate.TabIndex = 2;
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(91, 83);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(86, 20);
            this.tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(9, 22);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(41, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name :";
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(91, 53);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(86, 20);
            this.tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(9, 55);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(37, 13);
            this.lblUnitPriceUpdate.TabIndex = 3;
            this.lblUnitPriceUpdate.Text = "Price :";
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(9, 86);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(80, 13);
            this.lblStockAmountUpdate.TabIndex = 4;
            this.lblStockAmountUpdate.Text = "Stock Amount :";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.lblUnitPrice);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Location = new System.Drawing.Point(12, 193);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(188, 163);
            this.gbxAdd.TabIndex = 11;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(91, 19);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(86, 20);
            this.tbxName.TabIndex = 2;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(91, 83);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(86, 20);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(91, 53);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(86, 20);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(9, 55);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(37, 13);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Price :";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(9, 86);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(80, 13);
            this.lblStockAmount.TabIndex = 4;
            this.lblStockAmount.Text = "Stock Amount :";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwProducts.RowTemplate.Height = 25;
            this.dgwProducts.Size = new System.Drawing.Size(512, 175);
            this.dgwProducts.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 360);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}

