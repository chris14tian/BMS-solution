namespace TinahBridals
{
    partial class ReceiptForm
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
            lblTitle = new Label();
            lblDivider = new Label();
            lblItem = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            lblTotal = new Label();
            lblAmountPaid = new Label();
            lblBalance = new Label();
            lblDate = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(183, 110, 121);
            lblTitle.Location = new Point(45, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tinah Bridal Spot";
            // 
            // lblDivider
            // 
            lblDivider.AutoSize = true;
            lblDivider.ForeColor = Color.FromArgb(183, 110, 121);
            lblDivider.Location = new Point(1, 53);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(377, 15);
            lblDivider.TabIndex = 1;
            lblDivider.Text = "--------------------------------------------------------------------------";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItem.Location = new Point(7, 83);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(51, 16);
            lblItem.TabIndex = 2;
            lblItem.Text = "Item :";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitPrice.Location = new Point(7, 133);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(87, 16);
            lblUnitPrice.TabIndex = 3;
            lblUnitPrice.Text = "Unit Price :";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(12, 190);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 16);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(12, 251);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 16);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total Amount :";
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountPaid.Location = new Point(12, 307);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(100, 15);
            lblAmountPaid.TabIndex = 6;
            lblAmountPaid.Text = "Amount Paid :";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(12, 360);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(72, 16);
            lblBalance.TabIndex = 7;
            lblBalance.Text = "Balance :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(10, 406);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(48, 16);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date :";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(183, 110, 121);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(230, 418);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close ";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 240);
            ClientSize = new Size(384, 461);
            Controls.Add(btnClose);
            Controls.Add(lblDate);
            Controls.Add(lblBalance);
            Controls.Add(lblAmountPaid);
            Controls.Add(lblTotal);
            Controls.Add(lblQuantity);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblItem);
            Controls.Add(lblDivider);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            Load += ReceiptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDivider;
        private Label lblItem;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblTotal;
        private Label lblAmountPaid;
        private Label lblBalance;
        private Label lblDate;
        private Button btnClose;
    }
}