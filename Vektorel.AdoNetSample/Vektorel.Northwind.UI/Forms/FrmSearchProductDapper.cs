using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.Northwind.UI.Managers;
using Vektorel.Northwind.UI.Models;

namespace Vektorel.Northwind.UI.Forms
{
    public partial class FrmSearchProductDapper : Form
    {
        private readonly DataManager dataManager;
        public FrmSearchProductDapper()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        private void FrmSearchProductDapper_Load(object sender, EventArgs e)
        {
            var connection = dataManager.GetConnection();
            var query = "select CategoryId as Id, CategoryName as Label from Categories order by Label";
            var categories = connection.Query<DataOption>(query);
            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = nameof(DataOption.Label);
            cmbCategories.ValueMember = nameof(DataOption.Id);
            cmbCategories.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var qb = new StringBuilder();

            var filter = new ProductFilter
            {
                Name = !string.IsNullOrEmpty(txtProduct.Text) ? txtProduct.Text + "%" : string.Empty,
                CategoryID = cmbCategories.SelectedIndex > -1 ? Convert.ToInt32(cmbCategories.SelectedValue) : -1
            };

            qb.AppendLine("select ProductName as Name, UnitPrice as Price, UnitsInStock as Stock");
            qb.AppendLine("from Products");

            //arama kriteri varsa
            if (filter.HasFilter)
            {
                var hasCriteria = false;
                qb.Append("where ");

                if (filter.HasNameFilter)
                {
                    qb.AppendLine("ProductName like @Name");
                    hasCriteria = true;
                }

                if (filter.HasCategoryFilter)
                {
                    if (hasCriteria)
                    {
                        qb.Append("and ");
                    }
                    qb.AppendLine("CategoryId = @CategoryID");
                }
            }

            var query = qb.ToString();
            var connection = dataManager.GetConnection();
            var products = connection.Query<ProductDTO>(query, filter);
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCategories.SelectedIndex = -1;
            txtProduct.Clear();
        }
    }

    class ProductDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    class ProductFilter
    {
        public string Name { get; set; }
        public int CategoryID { get; set; }

        public bool HasFilter
        {
            get
            {
                return HasNameFilter || HasCategoryFilter;
            }
        }

        public bool HasNameFilter => !string.IsNullOrEmpty(Name);
        public bool HasCategoryFilter => CategoryID > -1;
    }
}
