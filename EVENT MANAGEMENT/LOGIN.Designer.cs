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
            this.TextBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.TextBoxLoginLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // TextBoxLoginPassword
            // 
            this.TextBoxLoginPassword.Location = new System.Drawing.Point(26, 74);
            this.TextBoxLoginPassword.MaxLength = 100;
            this.TextBoxLoginPassword.Name = "TextBoxLoginPassword";
            this.TextBoxLoginPassword.PasswordChar = '*';
            this.TextBoxLoginPassword.Size = new System.Drawing.Size(260, 20);
            this.TextBoxLoginPassword.TabIndex = 9;
            // 
            // TextBoxLoginLogin
            // 
            this.TextBoxLoginLogin.Location = new System.Drawing.Point(26, 32);
            this.TextBoxLoginLogin.MaxLength = 30;
            this.TextBoxLoginLogin.Name = "TextBoxLoginLogin";
            this.TextBoxLoginLogin.Size = new System.Drawing.Size(260, 20);
            this.TextBoxLoginLogin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 145);
            this.Controls.Add(this.BtnLoginLogin);
            this.Controls.Add(this.BtnLoginCancel);
            this.Controls.Add(this.TextBoxLoginPassword);
            this.Controls.Add(this.TextBoxLoginLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoginLogin;
        private System.Windows.Forms.Button BtnLoginCancel;
        private System.Windows.Forms.TextBox TextBoxLoginPassword;
        private System.Windows.Forms.TextBox TextBoxLoginLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

