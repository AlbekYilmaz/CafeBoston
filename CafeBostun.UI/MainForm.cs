using CafeBoston.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBostun.UI
{
    public partial class MainForm : Form
    {
        CafeData db = new CafeData();
        public MainForm()
        {
            InitializeComponent();
            SeedSampleProducts();
            LoadTables();
        }

        private void SeedSampleProducts()
        {
            db.Products.Add(new Product() { ProductName = "Cola", UnitPrice = 14.50m });
            db.Products.Add(new Product() { ProductName = "Tea", UnitPrice = 9m });
        }

        private void LoadTables()
        {
            for (int i = 1; i <= db.TableCount; i++)
            {
                var lvi = new ListViewItem($"Table{i}");
                lvi.Tag = i;
                lvi.ImageKey = "empty";
                lvwTables.Items.Add(lvi);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lvwTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwTables_DoubleClick(object sender, EventArgs e)
        {
            var selectedLvi = lvwTables.SelectedItems[0];
            int tableNo = (int)selectedLvi.Tag;

            var order = db.ActiveOrders.FirstOrDefault(x => x.TableNo == tableNo);
            if (order == null)
            {
                order = new Order() { TableNo = tableNo };
                db.ActiveOrders.Add(order);
                selectedLvi.ImageKey = "Full";
            }
            var frmOrder = new OrderForm(db, order);
            var dr=frmOrder.ShowDialog();
            if(dr == DialogResult.OK)
            {
                selectedLvi.ImageKey = "empty";
            }

        }

        private void tsmiOrderHistory_Click(object sender, EventArgs e)
        {
            new OrderHistoryForm(db).ShowDialog();
        }
    }
}
