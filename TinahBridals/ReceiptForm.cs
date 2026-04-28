using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TinahBridals
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(string itemName,double unitPrice, int Quantity, double totalAmount, double amountPaid, double Balance, string Date)
        {
            InitializeComponent();
            lblItem.Text = "Item:" + itemName;
            lblUnitPrice.Text = "Unit Price: " + unitPrice.ToString("F2");
            lblQuantity.Text = "Quantity: " + Quantity;
            lblTotal.Text = "Total Amount: " + totalAmount.ToString("F2");
            lblAmountPaid.Text = "Amount Paid " + amountPaid.ToString("F2");
            lblBalance.Text = "Balance: " + Balance.ToString("F2");
            lblDate.Text = "Date: " + Date;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
