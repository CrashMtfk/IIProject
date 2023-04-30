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
            ((System.ComponentModel.ISupportInitialize)(this.dataPreturi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrizer
            // 
            this.lblFrizer.AutoSize = true;
            this.lblFrizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrizer.Location = new System.Drawing.Point(50, 13);
            this.lblFrizer.Name = "lblFrizer";
            this.lblFrizer.Size = new System.Drawing.Size(49, 20);
            this.lblFrizer.TabIndex = 0;
            this.lblFrizer.Text = "Frizer";
            // 
            // boxFrizeri
            // 
            this.boxFrizeri.FormattingEnabled = true;
            this.boxFrizeri.Location = new System.Drawing.Point(105, 12);
            this.boxFrizeri.Name = "boxFrizeri";
            this.boxFrizeri.Size = new System.Drawing.Size(121, 21);
            this.boxFrizeri.TabIndex = 1;
            // 
            // dataPreturi
            // 
            this.dataPreturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPreturi.Location = new System.Drawing.Point(12, 39);
            this.dataPreturi.Name = "dataPreturi";
            this.dataPreturi.Size = new System.Drawing.Size(257, 325);
            this.dataPreturi.TabIndex = 2;
            // 
            // btnGoProfile
            // 
            this.btnGoProfile.Location = new System.Drawing.Point(105, 370);
            this.btnGoProfile.Name = "btnGoProfile";
            this.btnGoProfile.Size = new System.Drawing.Size(75, 23);
            this.btnGoProfile.TabIndex = 3;
            this.btnGoProfile.Text = "Profile";
            this.btnGoProfile.UseVisualStyleBackColor = true;
            // 
            // Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 417);
            this.Controls.Add(this.btnGoProfile);
            this.Controls.Add(this.dataPreturi);
            this.Controls.Add(this.boxFrizeri);
            this.Controls.Add(this.lblFrizer);
            this.Name = "Prices";
            this.Text = "Prices";
            ((System.ComponentModel.ISupportInitialize)(this.dataPreturi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrizer;
        private System.Windows.Forms.ComboBox boxFrizeri;
        private System.Windows.Forms.DataGridView dataPreturi;
        private System.Windows.Forms.Button btnGoProfile;
    }
}