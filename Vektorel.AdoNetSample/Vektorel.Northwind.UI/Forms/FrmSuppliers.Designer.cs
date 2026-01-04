namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmSuppliers
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
            lstSupplier = new ListView();
            clhName = new ColumnHeader();
            clhContact = new ColumnHeader();
            clhTitle = new ColumnHeader();
            clhPhone = new ColumnHeader();
            clhCity = new ColumnHeader();
            label1 = new Label();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // lstSupplier
            // 
            lstSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstSupplier.Columns.AddRange(new ColumnHeader[] { clhName, clhContact, clhPhone, clhCity, clhTitle });
            lstSupplier.Location = new Point(12, 40);
            lstSupplier.Name = "lstSupplier";
            lstSupplier.Size = new Size(489, 327);
            lstSupplier.Sorting = SortOrder.Ascending;
            lstSupplier.TabIndex = 0;
            lstSupplier.UseCompatibleStateImageBehavior = false;
            lstSupplier.View = View.Details;
            // 
            // clhName
            // 
            clhName.Text = "Firma";
            clhName.Width = 120;
            // 
            // clhContact
            // 
            clhContact.Text = "Yetkili";
            // 
            // clhTitle
            // 
            clhTitle.Text = "Yetkili Ünvanı";
            clhTitle.Width = 120;
            // 
            // clhPhone
            // 
            clhPhone.Text = "İrtibat Numarası";
            clhPhone.Width = 100;
            // 
            // clhCity
            // 
            clhCity.Text = "Şehir";
            clhCity.Width = 80;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(325, 12);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "Ara";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(356, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(145, 23);
            txtSearch.TabIndex = 2;
            // 
            // FrmSuppliers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 379);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(lstSupplier);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSuppliers";
            Text = "Tedarikçiler";
            Load += FrmSuppliers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstSupplier;
        private ColumnHeader clhName;
        private ColumnHeader clhContact;
        private ColumnHeader clhPhone;
        private ColumnHeader clhCity;
        private ColumnHeader clhTitle;
        private Label label1;
        private TextBox txtSearch;
    }
}