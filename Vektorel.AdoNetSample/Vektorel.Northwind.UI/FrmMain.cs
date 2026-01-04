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

        private void OpenForm<T>() where T : Form
        {
            var f = Activator.CreateInstance<T>();
            f.ShowDialog();
        }
    }
}
