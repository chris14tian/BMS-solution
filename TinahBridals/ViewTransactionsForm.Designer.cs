namespace TinahBridals
{
    partial class ViewTransactionsForm
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
            dgvTransactionHistory = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvTransactionHistory
            // 
            dgvTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionHistory.Location = new Point(12, 12);
            dgvTransactionHistory.Name = "dgvTransactionHistory";
            dgvTransactionHistory.Size = new Size(650, 350);
            dgvTransactionHistory.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(183, 110, 112);
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(234, 409);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(180, 40);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load Transactions";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // ViewTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 240);
            ClientSize = new Size(684, 461);
            Controls.Add(btnLoad);
            Controls.Add(dgvTransactionHistory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "ViewTransactionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction History ";
            Load += ViewTransactionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactionHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTransactionHistory;
        private Button btnLoad;
    }
}