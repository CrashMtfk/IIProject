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
            this.txtUserName.Location = new System.Drawing.Point(13, 13);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "User\'s Name";
            // 
            // lblUserPoints
            // 
            this.lblUserPoints.AutoSize = true;
            this.lblUserPoints.Location = new System.Drawing.Point(10, 39);
            this.lblUserPoints.Name = "lblUserPoints";
            this.lblUserPoints.Size = new System.Drawing.Size(42, 13);
            this.lblUserPoints.TabIndex = 1;
            this.lblUserPoints.Text = "Points :";
            // 
            // txtPriceTitle
            // 
            this.txtPriceTitle.Location = new System.Drawing.Point(127, 101);
            this.txtPriceTitle.Name = "txtPriceTitle";
            this.txtPriceTitle.ReadOnly = true;
            this.txtPriceTitle.Size = new System.Drawing.Size(100, 20);
            this.txtPriceTitle.TabIndex = 2;
            this.txtPriceTitle.Text = "PRICES";
            this.txtPriceTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiscountsTitle
            // 
            this.txtDiscountsTitle.Location = new System.Drawing.Point(489, 100);
            this.txtDiscountsTitle.Name = "txtDiscountsTitle";
            this.txtDiscountsTitle.ReadOnly = true;
            this.txtDiscountsTitle.Size = new System.Drawing.Size(132, 20);
            this.txtDiscountsTitle.TabIndex = 3;
            this.txtDiscountsTitle.Text = "AVAILABLE DISCOUNTS";
            this.txtDiscountsTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discountsTable
            // 
            this.discountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discountsTable.Location = new System.Drawing.Point(434, 126);
            this.discountsTable.Name = "discountsTable";
            this.discountsTable.Size = new System.Drawing.Size(240, 239);
            this.discountsTable.TabIndex = 4;
            // 
            // pricesTable
            // 
            this.pricesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricesTable.Location = new System.Drawing.Point(65, 126);
            this.pricesTable.Name = "pricesTable";
            this.pricesTable.Size = new System.Drawing.Size(240, 238);
            this.pricesTable.TabIndex = 5;
            // 
            // txtDiscountTitle
            // 
            this.txtDiscountTitle.Location = new System.Drawing.Point(434, 373);
            this.txtDiscountTitle.Name = "txtDiscountTitle";
            this.txtDiscountTitle.Size = new System.Drawing.Size(152, 20);
            this.txtDiscountTitle.TabIndex = 6;
            this.txtDiscountTitle.Text = "Discount\'s name";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(589, 373);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(85, 20);
            this.btnAddDiscount.TabIndex = 7;
            this.btnAddDiscount.Text = "Get Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            // 
            // txtUserPoints
            // 
            this.txtUserPoints.Location = new System.Drawing.Point(50, 36);
            this.txtUserPoints.Name = "txtUserPoints";
            this.txtUserPoints.ReadOnly = true;
            this.txtUserPoints.Size = new System.Drawing.Size(100, 20);
            this.txtUserPoints.TabIndex = 8;
            this.txtUserPoints.Text = "User\'s points";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.Location = new System.Drawing.Point(127, 370);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(108, 23);
            this.btnMakeAppointment.TabIndex = 10;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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