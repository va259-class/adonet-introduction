namespace Vektorel.Northwind.UI.Forms
{
    partial class FrmNewEmployee
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
            dtpHireDate = new DateTimePicker();
            dtpBirthDate = new DateTimePicker();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtPhone = new TextBox();
            label8 = new Label();
            txtTitle = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(213, 190);
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
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 9);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Soyadı";
            // 
            // dtpHireDate
            // 
            dtpHireDate.CustomFormat = "dd/MM/yyyy";
            dtpHireDate.Format = DateTimePickerFormat.Custom;
            dtpHireDate.Location = new Point(12, 73);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(135, 23);
            dtpHireDate.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(153, 73);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(135, 23);
            dtpBirthDate.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 29);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(135, 23);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(153, 29);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(135, 23);
            txtLastName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 7;
            label3.Text = "İşe Giriş Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 55);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 8;
            label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 99);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 9;
            label5.Text = "Ülke";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 99);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Şehir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 143);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 11;
            label7.Text = "Telefon";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(12, 117);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(135, 23);
            txtCountry.TabIndex = 12;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(153, 117);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(135, 23);
            txtCity.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 161);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(135, 23);
            txtPhone.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(153, 143);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 15;
            label8.Text = "Ünvan";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(153, 161);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(135, 23);
            txtTitle.TabIndex = 16;
            // 
            // FrmNewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 225);
            Controls.Add(txtTitle);
            Controls.Add(label8);
            Controls.Add(txtPhone);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(dtpBirthDate);
            Controls.Add(dtpHireDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNewEmployee";
            Text = "Yeni Personel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpHireDate;
        private DateTimePicker dtpBirthDate;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtPhone;
        private Label label8;
        private TextBox txtTitle;
    }
}