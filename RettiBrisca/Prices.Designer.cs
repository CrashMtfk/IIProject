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
            this.lblFrizer.Location = new System.Drawing.Point(67, 16);
            this.lblFrizer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrizer.Name = "lblFrizer";
            this.lblFrizer.Size = new System.Drawing.Size(61, 25);
            this.lblFrizer.TabIndex = 0;
            this.lblFrizer.Text = "Frizer";
            // 
            // boxFrizeri
            // 
            this.boxFrizeri.FormattingEnabled = true;
            this.boxFrizeri.Location = new System.Drawing.Point(140, 15);
            this.boxFrizeri.Margin = new System.Windows.Forms.Padding(4);
            this.boxFrizeri.Name = "boxFrizeri";
            this.boxFrizeri.Size = new System.Drawing.Size(160, 24);
            this.boxFrizeri.TabIndex = 1;
            this.boxFrizeri.SelectedIndexChanged += new System.EventHandler(this.boxFrizeri_SelectedIndexChanged);
            // 
            // dataPreturi
            // 
            this.dataPreturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPreturi.Location = new System.Drawing.Point(16, 48);
            this.dataPreturi.Margin = new System.Windows.Forms.Padding(4);
            this.dataPreturi.Name = "dataPreturi";
            this.dataPreturi.Size = new System.Drawing.Size(343, 228);
            this.dataPreturi.TabIndex = 2;
            // 
            // btnGoProfile
            // 
            this.btnGoProfile.Location = new System.Drawing.Point(140, 455);
            this.btnGoProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoProfile.Name = "btnGoProfile";
            this.btnGoProfile.Size = new System.Drawing.Size(100, 28);
            this.btnGoProfile.TabIndex = 3;
            this.btnGoProfile.Text = "Profile";
            this.btnGoProfile.UseVisualStyleBackColor = true;
            this.btnGoProfile.Click += new System.EventHandler(this.btnGoProfile_Click);
            // 
            // couponList
            // 
            this.couponList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.couponList.Location = new System.Drawing.Point(16, 283);
            this.couponList.Name = "couponList";
            this.couponList.RowTemplate.Height = 24;
            this.couponList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.couponList.Size = new System.Drawing.Size(343, 165);
            this.couponList.TabIndex = 4;
            // 
            // Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 513);
            this.Controls.Add(this.couponList);
            this.Controls.Add(this.btnGoProfile);
            this.Controls.Add(this.dataPreturi);
            this.Controls.Add(this.boxFrizeri);
            this.Controls.Add(this.lblFrizer);
            this.Margin = new System.Windows.Forms.Padding(4);
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