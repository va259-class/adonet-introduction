namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmNewProduct
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
            btnSave = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            cmbCategories = new ComboBox();
            label3 = new Label();
            cmbSuppliers = new ComboBox();
            label4 = new Label();
            nudPrice = new NumericUpDown();
            label5 = new Label();
            nudStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(132, 254);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 23);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Kategori";
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(12, 71);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(195, 23);
            cmbCategories.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Tedarikçi";
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(12, 115);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(195, 23);
            cmbSuppliers.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "Fiyat";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(12, 159);
            nudPrice.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            nudPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(195, 23);
            nudPrice.TabIndex = 8;
            nudPrice.TextAlign = HorizontalAlignment.Right;
            nudPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 9;
            label5.Text = "Stok";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(12, 203);
            nudStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(195, 23);
            nudStock.TabIndex = 10;
            nudStock.TextAlign = HorizontalAlignment.Right;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FrmNewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 291);
            Controls.Add(nudStock);
            Controls.Add(label5);
            Controls.Add(nudPrice);
            Controls.Add(label4);
            Controls.Add(cmbSuppliers);
            Controls.Add(label3);
            Controls.Add(cmbCategories);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNewProduct";
            Text = "Yeni Ürün";
            Load += FrmNewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private ComboBox cmbCategories;
        private Label label3;
        private ComboBox cmbSuppliers;
        private Label label4;
        private NumericUpDown nudPrice;
        private Label label5;
        private NumericUpDown nudStock;
    }
}