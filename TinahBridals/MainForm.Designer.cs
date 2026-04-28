namespace TinahBridals
{
    partial class TInahBridalSpot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            button1 = new Button();
            button2 = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.RosyBrown;
            lblTitle.Location = new Point(134, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(267, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tinah Bridal Spot ";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.RosyBrown;
            lblSubtitle.Location = new Point(152, 40);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(225, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Boutique Mangement System ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(183, 110, 121);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(200, 90);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 2;
            button1.Text = "New Sale";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(183, 110, 121);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(200, 167);
            button2.Name = "button2";
            button2.Size = new Size(200, 45);
            button2.TabIndex = 3;
            button2.Text = "View Transactions ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(183, 110, 121);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(200, 259);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 45);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // TInahBridalSpot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 240);
            ClientSize = new Size(591, 465);
            Controls.Add(btnExit);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(200, 45);
            MaximizeBox = false;
            Name = "TInahBridalSpot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tinah Bridal Spot";
            Load += TInahBridalSpot_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button button1;
        private Button button2;
        private Button btnExit;
    }
}
