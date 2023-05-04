namespace RettiBrisca
{
    partial class LogIn
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
            this.txtLoginTitle = new System.Windows.Forms.TextBox();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogUser = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.btnGoRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoginTitle
            // 
            this.txtLoginTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.txtLoginTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.txtLoginTitle.Location = new System.Drawing.Point(132, 89);
            this.txtLoginTitle.Name = "txtLoginTitle";
            this.txtLoginTitle.ReadOnly = true;
            this.txtLoginTitle.Size = new System.Drawing.Size(100, 25);
            this.txtLoginTitle.TabIndex = 0;
            this.txtLoginTitle.Text = "Log In";
            this.txtLoginTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.lblUsernameLogin.Location = new System.Drawing.Point(106, 161);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(55, 13);
            this.lblUsernameLogin.TabIndex = 1;
            this.lblUsernameLogin.Text = "Username";
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLogin.Location = new System.Drawing.Point(109, 177);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(150, 26);
            this.txtUsernameLogin.TabIndex = 2;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.lblPasswordLogin.Location = new System.Drawing.Point(106, 224);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordLogin.TabIndex = 3;
            this.lblPasswordLogin.Text = "Password";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(109, 240);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(150, 26);
            this.txtPasswordLogin.TabIndex = 4;
            // 
            // btnLogUser
            // 
            this.btnLogUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(48)))));
            this.btnLogUser.FlatAppearance.BorderSize = 0;
            this.btnLogUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnLogUser.Location = new System.Drawing.Point(144, 272);
            this.btnLogUser.Name = "btnLogUser";
            this.btnLogUser.Size = new System.Drawing.Size(75, 23);
            this.btnLogUser.TabIndex = 5;
            this.btnLogUser.Text = "Login";
            this.btnLogUser.UseVisualStyleBackColor = false;
            this.btnLogUser.Click += new System.EventHandler(this.btnLogUser_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnGoHome.Location = new System.Drawing.Point(13, 415);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(75, 23);
            this.btnGoHome.TabIndex = 6;
            this.btnGoHome.Text = "Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnExit.Location = new System.Drawing.Point(287, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.lblNoAccount.Location = new System.Drawing.Point(106, 313);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(69, 13);
            this.lblNoAccount.TabIndex = 8;
            this.lblNoAccount.Text = "No account?";
            // 
            // btnGoRegister
            // 
            this.btnGoRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(48)))));
            this.btnGoRegister.FlatAppearance.BorderSize = 0;
            this.btnGoRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.btnGoRegister.Location = new System.Drawing.Point(181, 308);
            this.btnGoRegister.Name = "btnGoRegister";
            this.btnGoRegister.Size = new System.Drawing.Size(75, 23);
            this.btnGoRegister.TabIndex = 9;
            this.btnGoRegister.Text = "Register";
            this.btnGoRegister.UseVisualStyleBackColor = false;
            this.btnGoRegister.Click += new System.EventHandler(this.btnGoRegister_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.btnGoRegister);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoHome);
            this.Controls.Add(this.btnLogUser);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.txtUsernameLogin);
            this.Controls.Add(this.lblUsernameLogin);
            this.Controls.Add(this.txtLoginTitle);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginTitle;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Button btnLogUser;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Button btnGoRegister;
    }
}