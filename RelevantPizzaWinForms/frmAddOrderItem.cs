using RelevantPizza.Data;
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
    public partial class frmAddOrderItem : Form
    {
        private PizzaContext _context = new PizzaContext();

        private BindingList<InventoryItem> _inventoryItems;
        public BindingList<InventoryItem> InventoryItems
        {
            get
            {
                if(_inventoryItems == null)
                {
                    _inventoryItems = new BindingList<InventoryItem>();
                }

                return _inventoryItems;
            }
        }
        public OrderItemType Type { get; private set; }

        public frmAddOrderItem()
        {
            InitializeComponent();
        }

        private void PopulateDropdowns()
        {
            foreach (OrderItemType type in Enum.GetValues(typeof(OrderItemType)))
            {
                cmbItemType.Items.Add(type);
            }

            foreach (InventoryItemType type in Enum.GetValues(typeof(InventoryItemType)))
            {
                cmbDetailType.Items.Add(type);
            }
        }

        private void AddOrderItem_Load(object sender, EventArgs e)
        {
            PopulateDropdowns();

            dgOrderItemDetails.DataSource = InventoryItems;
            foreach (DataGridViewColumn column in dgOrderItemDetails.Columns)
            {
                if(column.Name != "Name" && column.Name != "Type")
                {
                    column.Visible = false;
                }
            }
        }

        private void CmbDetailType_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbDetailType.SelectedIndex > -1)
            {
                lblDetailName.Visible = true;
                cmbDetailItems.Visible = true;

                lblDetailName.Text = cmbDetailType.SelectedItem.ToString();

                cmbDetailItems.DataSource = _context.InventoryItems.Where(i => i.Type == (InventoryItemType)cmbDetailType.SelectedItem).ToList();
                cmbDetailItems.DisplayMember = "Name";
                cmbDetailItems.ValueMember = "ID";

            }
            else
            {
                lblDetailName.Visible = false;
                cmbDetailItems.Visible = false;

                lblDetailName.Text = string.Empty;
                cmbDetailItems.DataSource = null;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnAddDetail_Click(object sender, EventArgs e)
        {
            if(cmbDetailItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a detail item");
                return;
            }

            InventoryItem item = _context.InventoryItems.FirstOrDefault(i => i.ID == (int)cmbDetailItems.SelectedValue);

            if (!InventoryItems.Any(i => i.ID == item.ID))
            {
                InventoryItems.Add(item);
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if(cmbItemType.SelectedIndex == -1)
            {
                MessageBox.Show("Must select Item Type");
                return;
            }

            if (InventoryItems.Count == 0)
            {
                MessageBox.Show("Must add detail items");
                return;
            }

            Type = (OrderItemType)cmbItemType.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnClearItem_Click(object sender, EventArgs e)
        {
            dgOrderItemDetails.Rows.Clear();
        }
    }
}
