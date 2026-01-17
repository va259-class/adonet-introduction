using Vektorel.Northwind.UI.Forms;

namespace Vektorel.Northwind.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCustomers>();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenForm<FrmEmployees>();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            OpenForm<FrmSuppliers>();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            OpenForm<FrmSearchProduct>();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            OpenForm<FrmNewCategory>();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            OpenForm<FrmNewProduct>();
        }

        private void btnCustomerOrders_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCustomerOrders>();
        }

        private void btnProductSales_Click(object sender, EventArgs e)
        {
            OpenForm<FrmProductSales>();
        }

        private void btnCategorySales_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCategorySales>();
        }

        private void btnCustomersDapper_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCustomersDapper>();
        }

        private void btnSearchProductDapper_Click(object sender, EventArgs e)
        {
            OpenForm<FrmSearchProductDapper>();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            OpenForm<FrmUpdateProduct>();
        }

        private void btnNeEmployee_Click(object sender, EventArgs e)
        {
            OpenForm<FrmNewEmployee>();
        }

        private void OpenForm<T>() where T : Form
        {
            var f = Activator.CreateInstance<T>();
            f.ShowDialog();
        }
    }
}
