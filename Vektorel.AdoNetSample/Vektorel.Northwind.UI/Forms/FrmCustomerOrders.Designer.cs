namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmCustomerOrders
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
            txtCustomerCode = new TextBox();
            label1 = new Label();
            dgvOrders = new DataGridView();
            btnNewOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCustomerCode.CharacterCasing = CharacterCasing.Upper;
            txtCustomerCode.Location = new Point(96, 6);
            txtCustomerCode.MaxLength = 5;
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.Size = new Size(144, 23);
            txtCustomerCode.TabIndex = 0;
            txtCustomerCode.KeyDown += txtCustomerCode_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Kodu";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 35);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(532, 296);
            dgvOrders.TabIndex = 2;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(246, 6);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(75, 23);
            btnNewOrder.TabIndex = 3;
            btnNewOrder.Text = "Yeni Sipariş";
            btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // FrmCustomerOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 342);
            Controls.Add(btnNewOrder);
            Controls.Add(dgvOrders);
            Controls.Add(label1);
            Controls.Add(txtCustomerCode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCustomerOrders";
            Text = "Müşteri Siparişleri";
            Load += FrmCustomerOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerCode;
        private Label label1;
        private DataGridView dgvOrders;
        private Button btnNewOrder;
    }
}