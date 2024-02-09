namespace PasswordManagerSystem.UI
{
    partial class ProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.bnUpdate = new System.Windows.Forms.Button();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserDetailId = new System.Windows.Forms.TextBox();
            this.picProf = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(302, 220);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(72, 16);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "First Name";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(417, 214);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(216, 22);
            this.txtFirstname.TabIndex = 1;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(302, 266);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(72, 16);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(302, 319);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(302, 362);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(48, 16);
            this.lblMobile.TabIndex = 4;
            this.lblMobile.Text = "Mobile";
            // 
            // bnUpdate
            // 
            this.bnUpdate.Location = new System.Drawing.Point(558, 406);
            this.bnUpdate.Name = "bnUpdate";
            this.bnUpdate.Size = new System.Drawing.Size(75, 31);
            this.bnUpdate.TabIndex = 5;
            this.bnUpdate.Text = "Save";
            this.bnUpdate.UseVisualStyleBackColor = true;
            this.bnUpdate.Click += new System.EventHandler(this.bnUpdate_Click);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(417, 260);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(216, 22);
            this.txtLastname.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(417, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(417, 356);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(216, 22);
            this.txtMobile.TabIndex = 4;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(417, 128);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 16);
            this.lblUserId.TabIndex = 9;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(588, 63);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(45, 22);
            this.txtUserId.TabIndex = 10;
            this.txtUserId.Visible = false;
            // 
            // txtUserDetailId
            // 
            this.txtUserDetailId.Location = new System.Drawing.Point(588, 91);
            this.txtUserDetailId.Name = "txtUserDetailId";
            this.txtUserDetailId.Size = new System.Drawing.Size(45, 22);
            this.txtUserDetailId.TabIndex = 11;
            this.txtUserDetailId.Visible = false;
            // 
            // picProf
            // 
            this.picProf.Image = global::PasswordManagerSystem.Properties.Resources.profile;
            this.picProf.Location = new System.Drawing.Point(305, 63);
            this.picProf.Name = "picProf";
            this.picProf.Size = new System.Drawing.Size(115, 108);
            this.picProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProf.TabIndex = 13;
            this.picProf.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(436, 150);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picProf);
            this.Controls.Add(this.txtUserDetailId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.bnUpdate);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(1007, 542);
            this.Load += new System.EventHandler(this.ProfileControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Button bnUpdate;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserDetailId;
        private System.Windows.Forms.PictureBox picProf;
        private System.Windows.Forms.Button btnUpload;
    }
}
