namespace RettiBrisca
{
    partial class MakeAppointment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.btnGoProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.lblTitle.Location = new System.Drawing.Point(63, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "APPOINTMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(22, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frizer:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(10, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data si Ora:";
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(48)))));
            this.btnCreateAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnCreateAppointment.Location = new System.Drawing.Point(98, 182);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAppointment.TabIndex = 5;
            this.btnCreateAppointment.Text = "Make Appointment";
            this.btnCreateAppointment.UseVisualStyleBackColor = false;
            this.btnCreateAppointment.Click += new System.EventHandler(this.btnCreateAppointment_Click);
            // 
            // btnGoProfile
            // 
            this.btnGoProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(48)))));
            this.btnGoProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnGoProfile.Location = new System.Drawing.Point(98, 211);
            this.btnGoProfile.Name = "btnGoProfile";
            this.btnGoProfile.Size = new System.Drawing.Size(75, 23);
            this.btnGoProfile.TabIndex = 6;
            this.btnGoProfile.Text = "Profile";
            this.btnGoProfile.UseVisualStyleBackColor = false;
            this.btnGoProfile.Click += new System.EventHandler(this.btnGoProfile_Click);
            // 
            // MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(269, 246);
            this.Controls.Add(this.btnGoProfile);
            this.Controls.Add(this.btnCreateAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "MakeAppointment";
            this.Text = "MakeAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.Button btnGoProfile;
    }
}