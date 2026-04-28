using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TinahBridals
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }
        private void CalculateTotal()
        {
            double unitPrice;
            int quantity;
            if (double.TryParse(txtUnitPrice.Text, out unitPrice) && int.TryParse(txtQuantity.Text, out quantity))
            {
                double total = unitPrice * quantity;
                txtAmount.Text = total.ToString("F2");
            }
            else
            {
                txtAmount.Text = "";
            }
        }
        private void CalculateBalance()
        {
            double totalAmount;
            double amountPaid;
            if (double.TryParse(txtAmount.Text, out totalAmount) && double.TryParse(txtAmountPaid.Text, out amountPaid))
            {
                double balance = totalAmount - amountPaid;
                txtBalance.Text = balance.ToString("F2");
            }
            else
            {
                txtBalance.Text = "";
            }
        }
        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            if (cmbItemName.Text == "" || txtUnitPrice.Text == "" || txtAmountPaid.Text == "")
            {
                MessageBox.Show("Please fill in missing fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string itemName = cmbItemName.Text;
                double unitPrice = double.Parse(txtUnitPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);
                double TotalAmount = double.Parse(txtAmount.Text);
                double amountPaid = double.Parse(txtAmountPaid.Text);
                double balance = double.Parse(txtBalance.Text);
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                DatabaseHelper db = new DatabaseHelper();
                db.SaveTransactions(itemName, unitPrice, quantity, TotalAmount, amountPaid, balance, date);
                MessageBox.Show("Transaction successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please fill in the amount paid field before generating a receipt.");
                return;
            }
            ReceiptForm receipt = new ReceiptForm
                (cmbItemName.Text,
                double.Parse(txtUnitPrice.Text),
                int.Parse(txtQuantity.Text),
                double.Parse(txtAmount.Text),
                double.Parse(txtAmountPaid.Text),
                double.Parse(txtBalance.Text),
                dateTimePicker1.Value.ToString("yyyy-MM-dd")
                );
            receipt.Show();
        }       

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();

        }
    }
}
