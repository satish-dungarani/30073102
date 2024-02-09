namespace PasswordManagerSystem.UI
{
    partial class PasswordControl
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
            this.txtPasswordId = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblAppType = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRemindMe = new System.Windows.Forms.Label();
            this.lblReminderDays = new System.Windows.Forms.Label();
            this.lblDeleted = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtReminderDays = new System.Windows.Forms.TextBox();
            this.chkRemindMe = new System.Windows.Forms.CheckBox();
            this.chkDeleted = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswordId
            // 
            this.txtPasswordId.Location = new System.Drawing.Point(660, 18);
            this.txtPasswordId.Name = "txtPasswordId";
            this.txtPasswordId.Size = new System.Drawing.Size(45, 22);
            this.txtPasswordId.TabIndex = 0;
            this.txtPasswordId.Visible = false;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(660, 46);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(45, 22);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Visible = false;
            // 
            // lblAppType
            // 
            this.lblAppType.AutoSize = true;
            this.lblAppType.Location = new System.Drawing.Point(293, 103);
            this.lblAppType.Name = "lblAppType";
            this.lblAppType.Size = new System.Drawing.Size(109, 16);
            this.lblAppType.TabIndex = 2;
            this.lblAppType.Text = "Application Type";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(293, 138);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(114, 16);
            this.lblAppName.TabIndex = 3;
            this.lblAppName.Text = "Application Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(293, 173);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 16);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(293, 207);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblRemindMe
            // 
            this.lblRemindMe.AutoSize = true;
            this.lblRemindMe.Location = new System.Drawing.Point(293, 285);
            this.lblRemindMe.Name = "lblRemindMe";
            this.lblRemindMe.Size = new System.Drawing.Size(76, 16);
            this.lblRemindMe.TabIndex = 6;
            this.lblRemindMe.Text = "Remind Me";
            // 
            // lblReminderDays
            // 
            this.lblReminderDays.AutoSize = true;
            this.lblReminderDays.Location = new System.Drawing.Point(293, 338);
            this.lblReminderDays.Name = "lblReminderDays";
            this.lblReminderDays.Size = new System.Drawing.Size(101, 16);
            this.lblReminderDays.TabIndex = 7;
            this.lblReminderDays.Text = "Reminder Days";
            // 
            // lblDeleted
            // 
            this.lblDeleted.AutoSize = true;
            this.lblDeleted.Location = new System.Drawing.Point(293, 374);
            this.lblDeleted.Name = "lblDeleted";
            this.lblDeleted.Size = new System.Drawing.Size(68, 16);
            this.lblDeleted.TabIndex = 8;
            this.lblDeleted.Text = "Is Deleted";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(293, 412);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(57, 16);
            this.lblActive.TabIndex = 10;
            this.lblActive.Text = "Is Active";
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Location = new System.Drawing.Point(481, 132);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(224, 22);
            this.txtApplicationName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(481, 201);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(224, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(481, 167);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(224, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtReminderDays
            // 
            this.txtReminderDays.Location = new System.Drawing.Point(481, 332);
            this.txtReminderDays.MaxLength = 100;
            this.txtReminderDays.Name = "txtReminderDays";
            this.txtReminderDays.Size = new System.Drawing.Size(224, 22);
            this.txtReminderDays.TabIndex = 6;
            this.txtReminderDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReminderDays_KeyPress);
            // 
            // chkRemindMe
            // 
            this.chkRemindMe.AutoSize = true;
            this.chkRemindMe.Location = new System.Drawing.Point(481, 284);
            this.chkRemindMe.Name = "chkRemindMe";
            this.chkRemindMe.Size = new System.Drawing.Size(18, 17);
            this.chkRemindMe.TabIndex = 5;
            this.chkRemindMe.UseVisualStyleBackColor = true;
            // 
            // chkDeleted
            // 
            this.chkDeleted.AutoSize = true;
            this.chkDeleted.Location = new System.Drawing.Point(481, 373);
            this.chkDeleted.Name = "chkDeleted";
            this.chkDeleted.Size = new System.Drawing.Size(18, 17);
            this.chkDeleted.TabIndex = 7;
            this.chkDeleted.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(481, 411);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(18, 17);
            this.chkActive.TabIndex = 8;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(617, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(481, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(574, 229);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(65, 30);
            this.btnGenerate.TabIndex = 25;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.Location = new System.Drawing.Point(645, 229);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(60, 30);
            this.btnViewPassword.TabIndex = 26;
            this.btnViewPassword.Text = "View";
            this.btnViewPassword.UseVisualStyleBackColor = true;
            this.btnViewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnViewPassword_MouseDown);
            this.btnViewPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnViewPassword_MouseUp);
            // 
            // PasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnViewPassword);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.chkDeleted);
            this.Controls.Add(this.chkRemindMe);
            this.Controls.Add(this.txtReminderDays);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtApplicationName);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblDeleted);
            this.Controls.Add(this.lblReminderDays);
            this.Controls.Add(this.lblRemindMe);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblAppType);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtPasswordId);
            this.Name = "PasswordControl";
            this.Size = new System.Drawing.Size(1013, 555);
            this.Load += new System.EventHandler(this.PasswordControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblAppType;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRemindMe;
        private System.Windows.Forms.Label lblReminderDays;
        private System.Windows.Forms.Label lblDeleted;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox txtApplicationName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtReminderDays;
        private System.Windows.Forms.CheckBox chkRemindMe;
        private System.Windows.Forms.CheckBox chkDeleted;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnViewPassword;
    }
}
