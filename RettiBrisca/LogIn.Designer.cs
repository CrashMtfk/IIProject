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
            this.txtLoginTitle.Location = new System.Drawing.Point(471, 68);
            this.txtLoginTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginTitle.Name = "txtLoginTitle";
            this.txtLoginTitle.ReadOnly = true;
            this.txtLoginTitle.Size = new System.Drawing.Size(132, 22);
            this.txtLoginTitle.TabIndex = 0;
            this.txtLoginTitle.Text = "Log In";
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Location = new System.Drawing.Point(471, 148);
            this.lblUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(73, 17);
            this.lblUsernameLogin.TabIndex = 1;
            this.lblUsernameLogin.Text = "Username";
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLogin.Location = new System.Drawing.Point(475, 167);
            this.txtUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(199, 30);
            this.txtUsernameLogin.TabIndex = 2;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Location = new System.Drawing.Point(471, 225);
            this.lblPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(69, 17);
            this.lblPasswordLogin.TabIndex = 3;
            this.lblPasswordLogin.Text = "Password";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(475, 245);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(199, 30);
            this.txtPasswordLogin.TabIndex = 4;
            // 
            // btnLogUser
            // 
            this.btnLogUser.Location = new System.Drawing.Point(521, 284);
            this.btnLogUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogUser.Name = "btnLogUser";
            this.btnLogUser.Size = new System.Drawing.Size(100, 28);
            this.btnLogUser.TabIndex = 5;
            this.btnLogUser.Text = "button1";
            this.btnLogUser.UseVisualStyleBackColor = true;
            this.btnLogUser.Click += new System.EventHandler(this.btnLogUser_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(17, 511);
            this.btnGoHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(100, 28);
            this.btnGoHome.TabIndex = 6;
            this.btnGoHome.Text = "Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(951, 511);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Location = new System.Drawing.Point(471, 335);
            this.lblNoAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(88, 17);
            this.lblNoAccount.TabIndex = 8;
            this.lblNoAccount.Text = "No account?";
            // 
            // btnGoRegister
            // 
            this.btnGoRegister.Location = new System.Drawing.Point(571, 329);
            this.btnGoRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoRegister.Name = "btnGoRegister";
            this.btnGoRegister.Size = new System.Drawing.Size(100, 28);
            this.btnGoRegister.TabIndex = 9;
            this.btnGoRegister.Text = "Register";
            this.btnGoRegister.UseVisualStyleBackColor = true;
            this.btnGoRegister.Click += new System.EventHandler(this.btnGoRegister_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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