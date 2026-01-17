namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmUpdateProduct
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
            grbDetails = new GroupBox();
            cmbSuppliers = new ComboBox();
            label6 = new Label();
            cmbCategories = new ComboBox();
            nudStok = new NumericUpDown();
            nudPrice = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtProductId = new TextBox();
            button1 = new Button();
            grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // grbDetails
            // 
            grbDetails.Controls.Add(cmbSuppliers);
            grbDetails.Controls.Add(label6);
            grbDetails.Controls.Add(cmbCategories);
            grbDetails.Controls.Add(nudStok);
            grbDetails.Controls.Add(nudPrice);
            grbDetails.Controls.Add(label5);
            grbDetails.Controls.Add(label4);
            grbDetails.Controls.Add(label3);
            grbDetails.Controls.Add(txtProductName);
            grbDetails.Controls.Add(label2);
            grbDetails.Location = new Point(12, 35);
            grbDetails.Name = "grbDetails";
            grbDetails.Size = new Size(243, 253);
            grbDetails.TabIndex = 0;
            grbDetails.TabStop = false;
            grbDetails.Text = "Ürün Bilgileri";
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(6, 213);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(231, 23);
            cmbSuppliers.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 195);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 8;
            label6.Text = "Tedarikçi";
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(6, 169);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(231, 23);
            cmbCategories.TabIndex = 7;
            // 
            // nudStok
            // 
            nudStok.Location = new Point(6, 125);
            nudStok.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudStok.Name = "nudStok";
            nudStok.Size = new Size(231, 23);
            nudStok.TabIndex = 6;
            nudStok.TextAlign = HorizontalAlignment.Right;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(6, 81);
            nudPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(231, 23);
            nudPrice.TabIndex = 5;
            nudPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 151);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Ürün Çeşidi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Stok";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Fiyatı";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(6, 37);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(231, 23);
            txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün Kodu";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(82, 6);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(173, 23);
            txtProductId.TabIndex = 2;
            txtProductId.KeyDown += txtProductId_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(180, 294);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 333);
            Controls.Add(button1);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Controls.Add(grbDetails);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateProduct";
            Text = "Ürün Güncelleme";
            Load += FrmUpdateProduct_Load;
            grbDetails.ResumeLayout(false);
            grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDetails;
        private Label label2;
        private Label label1;
        private TextBox txtProductId;
        private ComboBox cmbSuppliers;
        private Label label6;
        private ComboBox cmbCategories;
        private NumericUpDown nudStok;
        private NumericUpDown nudPrice;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtProductName;
        private Button button1;
    }
}