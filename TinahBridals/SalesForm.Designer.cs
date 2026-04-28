namespace TinahBridals
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblName = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblTotal = new Label();
            lblBalance = new Label();
            lblAmountPaid = new Label();
            lblDate = new Label();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtAmount = new TextBox();
            txtAmountPaid = new TextBox();
            txtBalance = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSaveTransaction = new Button();
            btnReceipt = new Button();
            cmbItemName = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 31);
            label1.TabIndex = 0;
            label1.Text = "Sales Form";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(183, 110, 121);
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(7, 85);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 16);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.BackColor = Color.FromArgb(183, 110, 121);
            lblUnitPrice.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitPrice.ForeColor = Color.White;
            lblUnitPrice.Location = new Point(7, 158);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(82, 16);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Unit price ";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.FromArgb(183, 110, 121);
            lblQuantity.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(7, 226);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 16);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(183, 110, 121);
            lblTotal.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(7, 285);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 16);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total Amount";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = Color.FromArgb(183, 110, 121);
            lblBalance.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(7, 431);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(64, 16);
            lblBalance.TabIndex = 5;
            lblBalance.Text = "Balance";
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.BackColor = Color.FromArgb(183, 110, 121);
            lblAmountPaid.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountPaid.ForeColor = Color.White;
            lblAmountPaid.Location = new Point(7, 366);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(99, 16);
            lblAmountPaid.TabIndex = 6;
            lblAmountPaid.Text = "AmountPaid";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.FromArgb(183, 110, 121);
            lblDate.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(7, 504);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(40, 16);
            lblDate.TabIndex = 7;
            lblDate.Text = "Date";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(147, 144);
            txtUnitPrice.Multiline = true;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(250, 30);
            txtUnitPrice.TabIndex = 9;
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(145, 212);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 30);
            txtQuantity.TabIndex = 10;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.FromArgb(240, 224, 224);
            txtAmount.Location = new Point(147, 283);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(250, 30);
            txtAmount.TabIndex = 11;
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Location = new Point(148, 352);
            txtAmountPaid.Multiline = true;
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(250, 30);
            txtAmountPaid.TabIndex = 12;
            txtAmountPaid.TextChanged += txtAmountPaid_TextChanged;
            // 
            // txtBalance
            // 
            txtBalance.BackColor = Color.FromArgb(240, 224, 224);
            txtBalance.Location = new Point(146, 417);
            txtBalance.Multiline = true;
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(250, 30);
            txtBalance.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(144, 497);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // btnSaveTransaction
            // 
            btnSaveTransaction.BackColor = Color.FromArgb(183, 110, 121);
            btnSaveTransaction.FlatStyle = FlatStyle.Flat;
            btnSaveTransaction.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveTransaction.ForeColor = Color.White;
            btnSaveTransaction.Location = new Point(131, 554);
            btnSaveTransaction.Name = "btnSaveTransaction";
            btnSaveTransaction.Size = new Size(147, 34);
            btnSaveTransaction.TabIndex = 14;
            btnSaveTransaction.Text = "Save Transaction";
            btnSaveTransaction.UseVisualStyleBackColor = false;
            btnSaveTransaction.Click += btnSaveTransaction_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.FromArgb(183, 110, 121);
            btnReceipt.FlatStyle = FlatStyle.Flat;
            btnReceipt.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceipt.ForeColor = Color.White;
            btnReceipt.Location = new Point(334, 554);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(130, 34);
            btnReceipt.TabIndex = 15;
            btnReceipt.Text = "Receipt ";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // cmbItemName
            // 
            cmbItemName.FormattingEnabled = true;
            cmbItemName.Items.AddRange(new object[] { "Wedding Dress", "Bridesmaid Dress", "Sash" });
            cmbItemName.Location = new Point(147, 73);
            cmbItemName.Name = "cmbItemName";
            cmbItemName.Size = new Size(121, 23);
            cmbItemName.TabIndex = 16;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 240);
            ClientSize = new Size(527, 602);
            Controls.Add(cmbItemName);
            Controls.Add(btnReceipt);
            Controls.Add(btnSaveTransaction);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtBalance);
            Controls.Add(txtAmountPaid);
            Controls.Add(txtAmount);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblDate);
            Controls.Add(lblAmountPaid);
            Controls.Add(lblBalance);
            Controls.Add(lblTotal);
            Controls.Add(lblQuantity);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblTotal;
        private Label lblBalance;
        private Label lblAmountPaid;
        private Label lblDate;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtAmount;
        private TextBox txtAmountPaid;
        private TextBox txtBalance;
        private DateTimePicker dateTimePicker1;
        private Button btnSaveTransaction;
        private Button btnReceipt;
        private ComboBox cmbItemName;
    }
}