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
    public partial class OrderForm : Form
    {
        private readonly CafeData _db;
        private readonly Order _order;
        private readonly BindingList<OrderDetail> _orderDetails;
        public OrderForm(CafeData db, Order order)
        {
            _db = db;
            _order = order;
            _orderDetails = new BindingList<OrderDetail>(order.OrderDetails);
            _orderDetails.ListChanged += _orderDetails_ListChanged;
            InitializeComponent();
            dgvOrderDetails.DataSource = _orderDetails;
            LoadProducts();
            UpdateTableInfo();
        }

        private void _orderDetails_ListChanged(object? sender, ListChangedEventArgs e)
        {
            UpdateTableInfo();
        }

        private void UpdateTableInfo()
        {
            Text = $"Order (Table {_order.TableNo})-{_order.StartTime?.ToLongTimeString()}";
            lblTableNo.Text = _order.TableNo.ToString("00");
            lblTotalPrice.Text = _order.TotalPriceTRY;
        }

        private void LoadProducts()
        {
            cboProduct.DataSource = _db.Products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = (Product)cboProduct.SelectedItem;
            if (product == null) return;

            var orderDetail = _orderDetails.FirstOrDefault(x => x.ProductName == product.ProductName);

            if (orderDetail == null)
            {

                _orderDetails.Add(new OrderDetail()
                {
                    ProductName = product.ProductName,
                    Quantity = (int)nudQuantity.Value,
                    UnitPrice = product.UnitPrice
                });

            }
            else
            {
                orderDetail.Quantity += (int)nudQuantity.Value;
                _orderDetails.ResetBindings();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            CompleteOrder("Are you sure that you want to check out?", _order.TotalPrice(), OrderState.Paid);
        }

        private void CompleteOrder(string message, decimal paintAmount, OrderState newState)
        {
            DialogResult dr = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(dr==DialogResult.Yes)
            {
                _order.PaidAmount= paintAmount;
                _order.State= newState;
                _order.EndTime= DateTime.Now;
                _db.ActiveOrders.Remove(_order);
                _db.PastOrders.Add(_order);
                DialogResult=DialogResult.OK;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CompleteOrder("Are you sure that you want to cancel the order?", 0, OrderState.Canceled);
        }
    }
}
