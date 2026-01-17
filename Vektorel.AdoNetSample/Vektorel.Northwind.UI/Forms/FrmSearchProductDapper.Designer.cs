namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmSearchProductDapper
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
            dgvProducts = new DataGridView();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            txtProduct = new TextBox();
            cmbCategories = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 56);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.Size = new Size(522, 315);
            dgvProducts.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(332, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 8);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Ürün Çeşidi";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(12, 26);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(154, 23);
            txtProduct.TabIndex = 4;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(172, 27);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(154, 23);
            cmbCategories.TabIndex = 5;
            // 
            // FrmSearchProductDapper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 383);
            Controls.Add(cmbCategories);
            Controls.Add(txtProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(dgvProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSearchProductDapper";
            Text = "Ürün Arama";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnSearch;
        private Label label1;
        private Label label2;
        private TextBox txtProduct;
        private ComboBox cmbCategories;
    }
}