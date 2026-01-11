namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmCreateOrderDetail
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
            cmbProducts = new ComboBox();
            label1 = new Label();
            txtStock = new TextBox();
            nudStock = new NumericUpDown();
            label2 = new Label();
            nudPrice = new NumericUpDown();
            btnAdd = new Button();
            label3 = new Label();
            dgvDetails = new DataGridView();
            btnComplete = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(56, 6);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(227, 23);
            cmbProducts.TabIndex = 0;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(289, 6);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(68, 23);
            txtStock.TabIndex = 2;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(377, 6);
            nudStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(68, 23);
            nudStock.TabIndex = 3;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 39);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Fiyat";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(56, 35);
            nudPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(227, 23);
            nudPrice.TabIndex = 5;
            nudPrice.TextAlign = HorizontalAlignment.Right;
            nudPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(289, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 9);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 7;
            label3.Text = " / ";
            // 
            // dgvDetails
            // 
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(12, 74);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.Size = new Size(433, 227);
            dgvDetails.TabIndex = 8;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(329, 307);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(116, 23);
            btnComplete.TabIndex = 9;
            btnComplete.Text = "Siparişi Tamamla";
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // FrmCreateOrderDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 339);
            Controls.Add(btnComplete);
            Controls.Add(dgvDetails);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(nudPrice);
            Controls.Add(label2);
            Controls.Add(nudStock);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Controls.Add(cmbProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCreateOrderDetail";
            Text = "Sipariş Detayı";
            Load += FrmCreateOrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProducts;
        private Label label1;
        private TextBox txtStock;
        private NumericUpDown nudStock;
        private Label label2;
        private NumericUpDown nudPrice;
        private Button btnAdd;
        private Label label3;
        private DataGridView dgvDetails;
        private Button btnComplete;
    }
}