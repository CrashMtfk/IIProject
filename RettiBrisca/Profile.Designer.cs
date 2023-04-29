namespace RettiBrisca
{
    partial class Profile
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserPoints = new System.Windows.Forms.Label();
            this.txtPriceTitle = new System.Windows.Forms.TextBox();
            this.txtDiscountsTitle = new System.Windows.Forms.TextBox();
            this.discountsTable = new System.Windows.Forms.DataGridView();
            this.pricesTable = new System.Windows.Forms.DataGridView();
            this.txtDiscountTitle = new System.Windows.Forms.TextBox();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.txtUserPoints = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMakeAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.discountsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Location = new System.Drawing.Point(17, 16);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(132, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "User\'s Name";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUserPoints
            // 
            this.lblUserPoints.AutoSize = true;
            this.lblUserPoints.Location = new System.Drawing.Point(13, 48);
            this.lblUserPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPoints.Name = "lblUserPoints";
            this.lblUserPoints.Size = new System.Drawing.Size(55, 17);
            this.lblUserPoints.TabIndex = 1;
            this.lblUserPoints.Text = "Points :";
            // 
            // txtPriceTitle
            // 
            this.txtPriceTitle.Location = new System.Drawing.Point(169, 124);
            this.txtPriceTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriceTitle.Name = "txtPriceTitle";
            this.txtPriceTitle.ReadOnly = true;
            this.txtPriceTitle.Size = new System.Drawing.Size(132, 22);
            this.txtPriceTitle.TabIndex = 2;
            this.txtPriceTitle.Text = "PRICES";
            this.txtPriceTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiscountsTitle
            // 
            this.txtDiscountsTitle.Location = new System.Drawing.Point(652, 123);
            this.txtDiscountsTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiscountsTitle.Name = "txtDiscountsTitle";
            this.txtDiscountsTitle.ReadOnly = true;
            this.txtDiscountsTitle.Size = new System.Drawing.Size(175, 22);
            this.txtDiscountsTitle.TabIndex = 3;
            this.txtDiscountsTitle.Text = "AVAILABLE DISCOUNTS";
            this.txtDiscountsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discountsTable
            // 
            this.discountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discountsTable.Location = new System.Drawing.Point(579, 155);
            this.discountsTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discountsTable.Name = "discountsTable";
            this.discountsTable.Size = new System.Drawing.Size(320, 294);
            this.discountsTable.TabIndex = 4;
            // 
            // pricesTable
            // 
            this.pricesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricesTable.Location = new System.Drawing.Point(87, 155);
            this.pricesTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pricesTable.Name = "pricesTable";
            this.pricesTable.Size = new System.Drawing.Size(320, 293);
            this.pricesTable.TabIndex = 5;
            // 
            // txtDiscountTitle
            // 
            this.txtDiscountTitle.Location = new System.Drawing.Point(579, 459);
            this.txtDiscountTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiscountTitle.Name = "txtDiscountTitle";
            this.txtDiscountTitle.Size = new System.Drawing.Size(201, 22);
            this.txtDiscountTitle.TabIndex = 6;
            this.txtDiscountTitle.Text = "Discount\'s name";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(785, 459);
            this.btnAddDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(113, 25);
            this.btnAddDiscount.TabIndex = 7;
            this.btnAddDiscount.Text = "Get Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            // 
            // txtUserPoints
            // 
            this.txtUserPoints.Location = new System.Drawing.Point(67, 44);
            this.txtUserPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserPoints.Name = "txtUserPoints";
            this.txtUserPoints.ReadOnly = true;
            this.txtUserPoints.Size = new System.Drawing.Size(132, 22);
            this.txtUserPoints.TabIndex = 8;
            this.txtUserPoints.Text = "User\'s points";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(951, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.Location = new System.Drawing.Point(169, 455);
            this.btnMakeAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(144, 28);
            this.btnMakeAppointment.TabIndex = 10;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = true;
            this.btnMakeAppointment.Click += new System.EventHandler(this.btnMakeAppointment_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnMakeAppointment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtUserPoints);
            this.Controls.Add(this.btnAddDiscount);
            this.Controls.Add(this.txtDiscountTitle);
            this.Controls.Add(this.pricesTable);
            this.Controls.Add(this.discountsTable);
            this.Controls.Add(this.txtDiscountsTitle);
            this.Controls.Add(this.txtPriceTitle);
            this.Controls.Add(this.lblUserPoints);
            this.Controls.Add(this.txtUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.discountsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserPoints;
        private System.Windows.Forms.TextBox txtPriceTitle;
        private System.Windows.Forms.TextBox txtDiscountsTitle;
        private System.Windows.Forms.DataGridView discountsTable;
        private System.Windows.Forms.DataGridView pricesTable;
        private System.Windows.Forms.TextBox txtDiscountTitle;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.TextBox txtUserPoints;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMakeAppointment;
    }
}