namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmNewCategory
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
            label2 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(114, 120);
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
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Kategori Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Açıklama";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.MaxLength = 15;
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 23);
            txtName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 71);
            txtDescription.MaxLength = 120;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(177, 23);
            txtDescription.TabIndex = 4;
            // 
            // FrmNewCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 157);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNewCategory";
            Text = "Yeni Kategori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtDescription;
    }
}