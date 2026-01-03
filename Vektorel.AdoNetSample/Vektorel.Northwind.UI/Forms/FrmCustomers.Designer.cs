namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmCustomers
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
            dgvTable = new DataGridView();
            txtCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbCountries = new ComboBox();
            btnClear = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            SuspendLayout();
            // 
            // dgvTable
            // 
            dgvTable.AllowUserToAddRows = false;
            dgvTable.AllowUserToDeleteRows = false;
            dgvTable.AllowUserToResizeRows = false;
            dgvTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(12, 62);
            dgvTable.Name = "dgvTable";
            dgvTable.Size = new Size(410, 289);
            dgvTable.TabIndex = 0;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(12, 27);
            txtCode.MaxLength = 5;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Müşteri Kodu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 9);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Ülke";
            // 
            // cmbCountries
            // 
            cmbCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountries.FormattingEnabled = true;
            cmbCountries.Location = new Point(118, 27);
            cmbCountries.Name = "cmbCountries";
            cmbCountries.Size = new Size(121, 23);
            cmbCountries.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(245, 26);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Location = new Point(383, 357);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(39, 23);
            btnNext.TabIndex = 6;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrevious.Location = new Point(338, 357);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(39, 23);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // FrmCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 389);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnClear);
            Controls.Add(cmbCountries);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Controls.Add(dgvTable);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(450, 400);
            Name = "FrmCustomers";
            Text = "Müşteri Listesi";
            Load += FrmCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTable;
        private TextBox txtCode;
        private Label label1;
        private Label label2;
        private ComboBox cmbCountries;
        private Button btnClear;
        private Button btnNext;
        private Button btnPrevious;
    }
}