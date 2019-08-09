using RelevantPizza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelevantPizzaWinForms
{
    public partial class frmOrder : Form
    {
        public Customer OrderCustomer { get; set; }

        private DataTable _orderItems;

        public frmOrder()
        {
            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            PopulateDropdowns();
            BuildOrderItemsSchema();

            dgOrderItems.DataSource = _orderItems;
            dgOrderItems.Columns["InventoryItems"].Visible = false;
        }

        private void BuildOrderItemsSchema()
        {
            _orderItems = new DataTable();
            _orderItems.Columns.Add("Type", typeof(OrderItemType));
            _orderItems.Columns.Add("Price", typeof(decimal));
            _orderItems.Columns.Add("Details", typeof(string));
            _orderItems.Columns.Add("InventoryItems", typeof(IEnumerable<InventoryItem>));
        }

        private void PopulateDropdowns()
        {
            foreach (OrderType type in Enum.GetValues(typeof(OrderType)))
            {
                cmbOrderType.Items.Add(type);
            }
        }

        private void BtnCustomerSearch_Click(object sender, EventArgs e)
        {
            frmCustomerSearch cs = new frmCustomerSearch();
            cs.ShowDialog(this);

            if(cs.DialogResult == DialogResult.OK)
            {
                txtCustomer.Text = OrderCustomer.FirstName + " " + OrderCustomer.LastName;
            }
        }

        private void BtnAddOrderItem_Click(object sender, EventArgs e)
        {
            frmAddOrderItem addItem = new frmAddOrderItem();
            if(addItem.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            DataRow row = _orderItems.NewRow();
            row["Type"] = addItem.Type;
            row["Details"] = string.Join(", ", addItem.InventoryItems.Select(i => i.Name));
            row["InventoryItems"] = addItem.InventoryItems;

            _orderItems.Rows.Add(row);
        }
    }
}
