namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmProductSales
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
            dgvOrders = new DataGridView();
            cmbProducts = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbYears = new ComboBox();
            label3 = new Label();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 39);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.Size = new Size(526, 320);
            dgvOrders.TabIndex = 0;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(51, 10);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(217, 23);
            cmbProducts.TabIndex = 1;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 13);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 3;
            label2.Text = "Yıl";
            // 
            // cmbYears
            // 
            cmbYears.FormattingEnabled = true;
            cmbYears.Location = new Point(300, 10);
            cmbYears.Name = "cmbYears";
            cmbYears.Size = new Size(100, 23);
            cmbYears.TabIndex = 4;
            cmbYears.SelectedIndexChanged += cmbYears_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 368);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Toplam";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(438, 365);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 6;
            // 
            // FrmProductSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 392);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(cmbYears);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbProducts);
            Controls.Add(dgvOrders);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProductSales";
            Text = "Ürün Satışları";
            Load += FrmProductSales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private ComboBox cmbProducts;
        private Label label1;
        private Label label2;
        private ComboBox cmbYears;
        private Label label3;
        private TextBox txtTotal;
    }
}