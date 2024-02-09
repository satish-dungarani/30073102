using PasswordManagerSystem.Data;
using PasswordManagerSystem.Helpers;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Services;
using System;
using System.Windows.Forms;

namespace PasswordManagerSystem.UI
{
    public partial class PasswordControl : UserControl
    {
        private readonly ProfileModel _profileModel;
        private readonly PasswordService _passwordService;
        public int passId = 0;
        public PasswordControl(ProfileModel profileModel, PasswordService passwordService)
        {
            InitializeComponent();
            _profileModel = profileModel;
            _passwordService = passwordService;
        }

        private void txtReminderDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PasswordControl_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            FormHelper.ApplicationType[] items = (FormHelper.ApplicationType[])Enum.GetValues(typeof(FormHelper.ApplicationType));
            foreach (FormHelper.ApplicationType item in items)
                comboBox1.Items.Add(item);

            if (passId > 0)
            {
                var pass = _passwordService.GetPasswordById(passId);
                txtPasswordId.Text = passId.ToString();
                comboBox1.SelectedIndex = pass.ApplicationType - 1;
                txtPassword.Text = FormHelper.DecryptData(pass.PasswordValue);
                txtApplicationName.Text = pass.ApplicationName;
                txtReminderDays.Text = pass.ReminderDays.ToString();
                chkDeleted.Checked = pass.IsDeleted;
                chkActive.Checked = pass.IsActive;
                chkRemindMe.Checked = pass.RemindMe;
                txtUserId.Text = pass.UserId.ToString();
                txtUsername.Text = pass.Username;
            }
            else
            {
                txtUserId.Text = _profileModel.user.Id.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var pass = new Password()
            {
                Id = string.IsNullOrEmpty(txtPasswordId.Text) ? 0 : Convert.ToInt32(txtPasswordId.Text),
                ApplicationName = txtApplicationName.Text,
                ApplicationType = comboBox1.SelectedIndex + 1,
                PasswordValue = txtPassword.Text,
                ReminderDays = Convert.ToInt32(txtReminderDays.Text),
                RemindMe = chkRemindMe.Checked,
                IsDeleted = chkDeleted.Checked,
                IsActive = chkActive.Checked,
                UserId = Convert.ToInt32(txtUserId.Text),
                Username = txtUsername.Text,
                CreatedBy = Convert.ToInt32(txtUserId.Text),
                CreatedOn = DateTime.Now,
                UpdatedBy = Convert.ToInt32(txtUserId.Text),
                UpdatedOn = DateTime.Now
            };
            if (pass.Id > 0)
                _passwordService.UpdatePassword(pass);
            else
                _passwordService.CreatePassword(pass);
            MessageBox.Show("Password saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string generatedPassword = GenerateRandomPassword();
            txtPassword.Text = generatedPassword;
        }

        private string GenerateRandomPassword()
        {
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_=+";

            int passwordLength = 12;
            Random random = new Random();

            char[] passwordChars = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                passwordChars[i] = validChars[random.Next(validChars.Length)];

            string generatedPassword = new string(passwordChars);
            return generatedPassword;
        }

        private void btnViewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnViewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
