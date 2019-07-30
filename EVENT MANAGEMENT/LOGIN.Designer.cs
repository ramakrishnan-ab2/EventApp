namespace EVENT_MANAGEMENT
{
    partial class Login
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
            this.BtnLoginLogin = new System.Windows.Forms.Button();
            this.BtnLoginCancel = new System.Windows.Forms.Button();
            this.TxtLoginPassword = new System.Windows.Forms.TextBox();
            this.TxtLoginLogin = new System.Windows.Forms.TextBox();
            this.LblLoginPassword = new System.Windows.Forms.Label();
            this.LblLoginLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLoginLogin
            // 
            this.BtnLoginLogin.Enabled = false;
            this.BtnLoginLogin.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginLogin.Location = new System.Drawing.Point(211, 106);
            this.BtnLoginLogin.Name = "BtnLoginLogin";
            this.BtnLoginLogin.Size = new System.Drawing.Size(75, 26);
            this.BtnLoginLogin.TabIndex = 11;
            this.BtnLoginLogin.Text = "Login";
            this.BtnLoginLogin.UseVisualStyleBackColor = true;
            this.BtnLoginLogin.Click += new System.EventHandler(this.BtnLoginLogin_Click);
            // 
            // BtnLoginCancel
            // 
            this.BtnLoginCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnLoginCancel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginCancel.Location = new System.Drawing.Point(120, 106);
            this.BtnLoginCancel.Name = "BtnLoginCancel";
            this.BtnLoginCancel.Size = new System.Drawing.Size(75, 26);
            this.BtnLoginCancel.TabIndex = 10;
            this.BtnLoginCancel.Text = "Cancel";
            this.BtnLoginCancel.UseVisualStyleBackColor = true;
            this.BtnLoginCancel.Click += new System.EventHandler(this.BtnLoginCancel_Click);
            // 
            // TxtLoginPassword
            // 
            this.TxtLoginPassword.Location = new System.Drawing.Point(26, 74);
            this.TxtLoginPassword.MaxLength = 100;
            this.TxtLoginPassword.Name = "TxtLoginPassword";
            this.TxtLoginPassword.PasswordChar = '*';
            this.TxtLoginPassword.Size = new System.Drawing.Size(260, 20);
            this.TxtLoginPassword.TabIndex = 9;
            this.TxtLoginPassword.TextChanged += new System.EventHandler(this.TxtLoginPassword_TextChanged);
            // 
            // TxtLoginLogin
            // 
            this.TxtLoginLogin.Location = new System.Drawing.Point(26, 32);
            this.TxtLoginLogin.MaxLength = 30;
            this.TxtLoginLogin.Name = "TxtLoginLogin";
            this.TxtLoginLogin.Size = new System.Drawing.Size(260, 20);
            this.TxtLoginLogin.TabIndex = 8;
            this.TxtLoginLogin.TextChanged += new System.EventHandler(this.TxtLoginLogin_TextChanged);
            // 
            // LblLoginPassword
            // 
            this.LblLoginPassword.AutoSize = true;
            this.LblLoginPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoginPassword.Location = new System.Drawing.Point(23, 57);
            this.LblLoginPassword.Name = "LblLoginPassword";
            this.LblLoginPassword.Size = new System.Drawing.Size(71, 16);
            this.LblLoginPassword.TabIndex = 7;
            this.LblLoginPassword.Text = "Password";
            // 
            // LblLoginLogin
            // 
            this.LblLoginLogin.AutoSize = true;
            this.LblLoginLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoginLogin.Location = new System.Drawing.Point(23, 16);
            this.LblLoginLogin.Name = "LblLoginLogin";
            this.LblLoginLogin.Size = new System.Drawing.Size(42, 16);
            this.LblLoginLogin.TabIndex = 6;
            this.LblLoginLogin.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 145);
            this.Controls.Add(this.BtnLoginLogin);
            this.Controls.Add(this.BtnLoginCancel);
            this.Controls.Add(this.TxtLoginPassword);
            this.Controls.Add(this.TxtLoginLogin);
            this.Controls.Add(this.LblLoginPassword);
            this.Controls.Add(this.LblLoginLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoginLogin;
        private System.Windows.Forms.Button BtnLoginCancel;
        private System.Windows.Forms.TextBox TxtLoginPassword;
        private System.Windows.Forms.TextBox TxtLoginLogin;
        private System.Windows.Forms.Label LblLoginPassword;
        private System.Windows.Forms.Label LblLoginLogin;
    }
}

