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

        private void OpenForm<T>() where T : Form 
        {
            var f = Activator.CreateInstance<T>();
            f.ShowDialog();
        }
    }
}
