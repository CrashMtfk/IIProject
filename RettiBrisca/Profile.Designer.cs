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
            this.txtUserPoints = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMakeAppointment = new System.Windows.Forms.Button();
            this.btnPrices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Location = new System.Drawing.Point(124, 69);
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
            this.lblUserPoints.Location = new System.Drawing.Point(109, 105);
            this.lblUserPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPoints.Name = "lblUserPoints";
            this.lblUserPoints.Size = new System.Drawing.Size(55, 17);
            this.lblUserPoints.TabIndex = 1;
            this.lblUserPoints.Text = "Points :";
            // 
            // txtUserPoints
            // 
            this.txtUserPoints.Location = new System.Drawing.Point(173, 101);
            this.txtUserPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserPoints.Name = "txtUserPoints";
            this.txtUserPoints.ReadOnly = true;
            this.txtUserPoints.Size = new System.Drawing.Size(132, 22);
            this.txtUserPoints.TabIndex = 8;
            this.txtUserPoints.Text = "User\'s points";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(124, 322);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.Location = new System.Drawing.Point(124, 198);
            this.btnMakeAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(143, 28);
            this.btnMakeAppointment.TabIndex = 10;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = true;
            this.btnMakeAppointment.Click += new System.EventHandler(this.btnMakeAppointment_Click);
            // 
            // btnPrices
            // 
            this.btnPrices.Location = new System.Drawing.Point(124, 235);
            this.btnPrices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrices.Name = "btnPrices";
            this.btnPrices.Size = new System.Drawing.Size(143, 28);
            this.btnPrices.TabIndex = 11;
            this.btnPrices.Text = "Prices";
            this.btnPrices.UseVisualStyleBackColor = true;
            this.btnPrices.Click += new System.EventHandler(this.btnPrices_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 412);
            this.Controls.Add(this.btnPrices);
            this.Controls.Add(this.btnMakeAppointment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtUserPoints);
            this.Controls.Add(this.lblUserPoints);
            this.Controls.Add(this.txtUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserPoints;
        private System.Windows.Forms.TextBox txtUserPoints;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMakeAppointment;
        private System.Windows.Forms.Button btnPrices;
    }
}