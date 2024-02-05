namespace PasswordManagerSystem.Forms
{
    partial class frmRegister
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
            this.tblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tblUsername
            // 
            this.tblUsername.AutoSize = true;
            this.tblUsername.Location = new System.Drawing.Point(140, 74);
            this.tblUsername.Name = "tblUsername";
            this.tblUsername.Size = new System.Drawing.Size(76, 16);
            this.tblUsername.TabIndex = 0;
            this.tblUsername.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(140, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblConfPassword
            // 
            this.lblConfPassword.AutoSize = true;
            this.lblConfPassword.Location = new System.Drawing.Point(140, 175);
            this.lblConfPassword.Name = "lblConfPassword";
            this.lblConfPassword.Size = new System.Drawing.Size(115, 16);
            this.lblConfPassword.TabIndex = 2;
            this.lblConfPassword.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(143, 233);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(279, 51);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(261, 74);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(161, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(261, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // txtConfPassword
            // 
            this.txtConfPassword.Location = new System.Drawing.Point(261, 175);
            this.txtConfPassword.Name = "txtConfPassword";
            this.txtConfPassword.Size = new System.Drawing.Size(161, 22);
            this.txtConfPassword.TabIndex = 6;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 418);
            this.ControlBox = false;
            this.Controls.Add(this.txtConfPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblConfPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfPassword;
    }
}