namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmNewOrder
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
            dtpOrderDate = new DateTimePicker();
            btnCreate = new Button();
            label2 = new Label();
            label3 = new Label();
            txtCustomer = new TextBox();
            label4 = new Label();
            cmbEmployee = new ComboBox();
            label1 = new Label();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(96, 33);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(206, 23);
            dtpOrderDate.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(198, 91);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(104, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Sipariş Oluştur";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 36);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Sipariş Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 7);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "Müşteri Kodu";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(96, 4);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(206, 23);
            txtCustomer.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 65);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "Satış Temsilcisi";
            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(97, 62);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(205, 23);
            cmbEmployee.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 124);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "Toplam Tutar";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(96, 120);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(206, 23);
            txtTotal.TabIndex = 9;
            // 
            // FrmNewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 152);
            Controls.Add(txtTotal);
            Controls.Add(label1);
            Controls.Add(cmbEmployee);
            Controls.Add(label4);
            Controls.Add(txtCustomer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCreate);
            Controls.Add(dtpOrderDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNewOrder";
            Text = "Yeni Sipariş";
            Load += FrmNewOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpOrderDate;
        private Button btnCreate;
        private Label label2;
        private Label label3;
        private TextBox txtCustomer;
        private Label label4;
        private ComboBox cmbEmployee;
        private Label label1;
        private TextBox txtTotal;
    }
}