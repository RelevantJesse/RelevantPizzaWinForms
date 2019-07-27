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
    public partial class frmCustomerSearch : Form
    {
        PizzaContext _context = new PizzaContext();
        public frmCustomerSearch()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAddress.Text)
                && string.IsNullOrWhiteSpace(txtName.Text)
                && string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                dgResults.DataSource = null;
                return;
            }

            List<Customer> customers = _context.Customers.Where(c => txtName.Text == "" || c.FirstName.Contains(txtName.Text) || c.LastName.Contains(txtName.Text))
                                                         .Where(c => txtAddress.Text == "" || c.StreetAddress.Contains(txtAddress.Text))
                                                         .Where(c => txtPhone.Text == "" || c.PhoneNumber.Contains(txtPhone.Text))
                                                        .ToList();

            dgResults.DataSource = customers;
        }

        private void BtnSelectCustomer_Click(object sender, EventArgs e)
        {
            if(dgResults.SelectedRows.Count == 0)
            {
                return;
            }

            Customer selectedCustomer = (Customer)dgResults.SelectedRows[0].DataBoundItem;

            ((frmOrder)Owner).OrderCustomer = selectedCustomer;


            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
