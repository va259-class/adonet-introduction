using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Vektorel.Northwind.UI.Managers;

namespace Vektorel.Northwind.UI.Forms
{
    public partial class FrmCategorySales : Form
    {
        public FrmCategorySales()
        {
            InitializeComponent();
        }

        private void FrmCategorySales_Load(object sender, EventArgs e)
        {
            cmbYear.Items.AddRange([1996, 1997, 1998]);
            cmbYear.SelectedIndex = 0;
        }

        private void UpdateChart()
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();
            var query = @"select c.CategoryName, sum(od.UnitPrice * od.Quantity) as Total 
                          from [Order Details] od
                          inner join Orders o on od.OrderID = o.OrderID
                          inner join Products p on od.ProductID = p.ProductID
                          inner join Categories c on p.CategoryID = c.CategoryID
                          where datepart(year, o.OrderDate) = @p1
                          group by c.CategoryName
                          order by c.CategoryName";
            var dm = new DataManager();
            using var reader = dm.GetReader(query, cmbYear.SelectedItem);
            int index = 0;
            while (reader.Read())
            {
                var label = reader["CategoryName"].ToString();
                var value = Convert.ToDecimal(reader["Total"]);
                chart1.Series[0].Points.AddXY(index, value);
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(index, index + 0.5, label);
                index++;
            }

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }
    }

    // Gerek kalmadı
    record CategorySale(string CategoryName, decimal Total);
}
