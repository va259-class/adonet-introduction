namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmSearchProduct
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
            cmbCategories = new ComboBox();
            cmbSuppliers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnClear = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 50);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(560, 349);
            dgvProducts.TabIndex = 0;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(69, 17);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(121, 23);
            cmbCategories.TabIndex = 1;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.DropDownHeight = 150;
            cmbSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuppliers.DropDownWidth = 220;
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.IntegralHeight = false;
            cmbSuppliers.Location = new Point(255, 17);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(172, 23);
            cmbSuppliers.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Tedarikçi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Kategori";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(433, 17);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(514, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(58, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // FrmSearchProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbSuppliers);
            Controls.Add(cmbCategories);
            Controls.Add(dgvProducts);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(600, 450);
            Name = "FrmSearchProduct";
            Text = "Ürün Bilgileri";
            Load += FrmSearchProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private ComboBox cmbCategories;
        private ComboBox cmbSuppliers;
        private Label label1;
        private Label label2;
        private Button btnClear;
        private Button btnSearch;
    }
}