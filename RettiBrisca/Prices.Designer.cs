namespace RettiBrisca
{
    partial class Prices
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
            this.lblFrizer = new System.Windows.Forms.Label();
            this.boxFrizeri = new System.Windows.Forms.ComboBox();
            this.dataPreturi = new System.Windows.Forms.DataGridView();
            this.btnGoProfile = new System.Windows.Forms.Button();
            this.couponList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreturi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrizer
            // 
            this.lblFrizer.AutoSize = true;
            this.lblFrizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.lblFrizer.Location = new System.Drawing.Point(50, 13);
            this.lblFrizer.Name = "lblFrizer";
            this.lblFrizer.Size = new System.Drawing.Size(49, 20);
            this.lblFrizer.TabIndex = 0;
            this.lblFrizer.Text = "Frizer";
            // 
            // boxFrizeri
            // 
            this.boxFrizeri.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boxFrizeri.FormattingEnabled = true;
            this.boxFrizeri.Location = new System.Drawing.Point(105, 12);
            this.boxFrizeri.Name = "boxFrizeri";
            this.boxFrizeri.Size = new System.Drawing.Size(121, 21);
            this.boxFrizeri.TabIndex = 1;
            this.boxFrizeri.SelectedIndexChanged += new System.EventHandler(this.boxFrizeri_SelectedIndexChanged);
            // 
            // dataPreturi
            // 
            this.dataPreturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPreturi.Location = new System.Drawing.Point(12, 39);
            this.dataPreturi.Name = "dataPreturi";
            this.dataPreturi.RowTemplate.ReadOnly = true;
            this.dataPreturi.Size = new System.Drawing.Size(257, 185);
            this.dataPreturi.TabIndex = 2;
            // 
            // btnGoProfile
            // 
            this.btnGoProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(48)))));
            this.btnGoProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnGoProfile.Location = new System.Drawing.Point(105, 370);
            this.btnGoProfile.Name = "btnGoProfile";
            this.btnGoProfile.Size = new System.Drawing.Size(75, 23);
            this.btnGoProfile.TabIndex = 3;
            this.btnGoProfile.Text = "Profile";
            this.btnGoProfile.UseVisualStyleBackColor = false;
            this.btnGoProfile.Click += new System.EventHandler(this.btnGoProfile_Click);
            // 
            // couponList
            // 
            this.couponList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couponList.Location = new System.Drawing.Point(12, 230);
            this.couponList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.couponList.Name = "couponList";
            this.couponList.RowTemplate.Height = 24;
            this.couponList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.couponList.Size = new System.Drawing.Size(257, 134);
            this.couponList.TabIndex = 4;
            // 
            // Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(292, 417);
            this.Controls.Add(this.couponList);
            this.Controls.Add(this.btnGoProfile);
            this.Controls.Add(this.dataPreturi);
            this.Controls.Add(this.boxFrizeri);
            this.Controls.Add(this.lblFrizer);
            this.Name = "Prices";
            this.Text = "Prices";
            ((System.ComponentModel.ISupportInitialize)(this.dataPreturi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrizer;
        private System.Windows.Forms.ComboBox boxFrizeri;
        private System.Windows.Forms.DataGridView dataPreturi;
        private System.Windows.Forms.Button btnGoProfile;
        private System.Windows.Forms.DataGridView couponList;
    }
}