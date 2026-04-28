using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TinahBridals
{
    public partial class ViewTransactionsForm : Form
    {
        public ViewTransactionsForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvTransactionHistory.DataSource = db.GetAllTransactions();
        }

        private void ViewTransactionsForm_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            dgvTransactionHistory.DataSource = db.GetAllTransactions();
        }
    }
}
