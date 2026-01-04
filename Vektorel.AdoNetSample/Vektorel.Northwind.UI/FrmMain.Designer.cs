namespace Vektorel.Northwind.UI
{
    partial class FrmMain
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
            btnSearchProduct = new Button();
            btnSuppliers = new Button();
            btnOutOfStock = new Button();
            btnCustomers = new Button();
            btnEmployees = new Button();
            button16 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            SuspendLayout();
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(12, 12);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(118, 23);
            btnSearchProduct.TabIndex = 0;
            btnSearchProduct.Text = "Ürün Ara";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(12, 41);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(118, 23);
            btnSuppliers.TabIndex = 1;
            btnSuppliers.Text = "Tedarikçi Listesi";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnOutOfStock
            // 
            btnOutOfStock.Location = new Point(12, 99);
            btnOutOfStock.Name = "btnOutOfStock";
            btnOutOfStock.Size = new Size(118, 23);
            btnOutOfStock.TabIndex = 3;
            btnOutOfStock.Text = "Stokta Olmayanlar";
            btnOutOfStock.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(12, 70);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(118, 23);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Müşteri Listesi";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(12, 128);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(118, 23);
            btnEmployees.TabIndex = 4;
            btnEmployees.Text = "Personel Listesi";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // button16
            // 
            button16.Location = new Point(136, 12);
            button16.Name = "button16";
            button16.Size = new Size(118, 23);
            button16.TabIndex = 8;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(136, 41);
            button5.Name = "button5";
            button5.Size = new Size(118, 23);
            button5.TabIndex = 9;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(136, 99);
            button6.Name = "button6";
            button6.Size = new Size(118, 23);
            button6.TabIndex = 11;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(136, 70);
            button7.Name = "button7";
            button7.Size = new Size(118, 23);
            button7.TabIndex = 10;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(136, 128);
            button9.Name = "button9";
            button9.Size = new Size(118, 23);
            button9.TabIndex = 12;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(260, 128);
            button10.Name = "button10";
            button10.Size = new Size(118, 23);
            button10.TabIndex = 17;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(260, 99);
            button11.Name = "button11";
            button11.Size = new Size(118, 23);
            button11.TabIndex = 16;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(260, 70);
            button12.Name = "button12";
            button12.Size = new Size(118, 23);
            button12.TabIndex = 15;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(260, 41);
            button13.Name = "button13";
            button13.Size = new Size(118, 23);
            button13.TabIndex = 14;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(260, 12);
            button14.Name = "button14";
            button14.Size = new Size(118, 23);
            button14.TabIndex = 13;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 163);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button16);
            Controls.Add(btnEmployees);
            Controls.Add(btnOutOfStock);
            Controls.Add(btnCustomers);
            Controls.Add(btnSuppliers);
            Controls.Add(btnSearchProduct);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "Northwind";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearchProduct;
        private Button btnSuppliers;
        private Button btnOutOfStock;
        private Button btnCustomers;
        private Button btnEmployees;
        private Button button16;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}
