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
            this.label1 = new System.Windows.Forms.Label();
            this.boxAppointment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(93, 56);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(100, 19);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUserPoints
            // 
            this.lblUserPoints.AutoSize = true;
            this.lblUserPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.lblUserPoints.Location = new System.Drawing.Point(82, 85);
            this.lblUserPoints.Name = "lblUserPoints";
            this.lblUserPoints.Size = new System.Drawing.Size(42, 13);
            this.lblUserPoints.TabIndex = 1;
            this.lblUserPoints.Text = "Points :";
            // 
            // txtUserPoints
            // 
            this.txtUserPoints.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPoints.Location = new System.Drawing.Point(130, 82);
            this.txtUserPoints.Name = "txtUserPoints";
            this.txtUserPoints.ReadOnly = true;
            this.txtUserPoints.Size = new System.Drawing.Size(100, 19);
            this.txtUserPoints.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(48)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnExit.Location = new System.Drawing.Point(93, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(48)))));
            this.btnMakeAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnMakeAppointment.Location = new System.Drawing.Point(93, 171);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(107, 23);
            this.btnMakeAppointment.TabIndex = 10;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = false;
            this.btnMakeAppointment.Click += new System.EventHandler(this.btnMakeAppointment_Click);
            // 
            // btnPrices
            // 
            this.btnPrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(48)))));
            this.btnPrices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnPrices.Location = new System.Drawing.Point(93, 201);
            this.btnPrices.Name = "btnPrices";
            this.btnPrices.Size = new System.Drawing.Size(107, 23);
            this.btnPrices.TabIndex = 11;
            this.btnPrices.Text = "Prices";
            this.btnPrices.UseVisualStyleBackColor = false;
            this.btnPrices.Click += new System.EventHandler(this.btnPrices_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(28, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Closest appointment:";
            // 
            // boxAppointment
            // 
            this.boxAppointment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boxAppointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAppointment.Location = new System.Drawing.Point(130, 120);
            this.boxAppointment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxAppointment.Name = "boxAppointment";
            this.boxAppointment.ReadOnly = true;
            this.boxAppointment.Size = new System.Drawing.Size(128, 19);
            this.boxAppointment.TabIndex = 13;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(287, 335);
            this.Controls.Add(this.boxAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrices);
            this.Controls.Add(this.btnMakeAppointment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtUserPoints);
            this.Controls.Add(this.lblUserPoints);
            this.Controls.Add(this.txtUserName);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxAppointment;
    }
}