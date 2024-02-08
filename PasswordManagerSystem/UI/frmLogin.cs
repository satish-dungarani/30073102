using PasswordManagerSystem.Helpers;
using PasswordManagerSystem.Services;
using PasswordManagerSystem.UI;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Unity;

namespace PasswordManagerSystem.Forms
{
    public partial class frmLogin : Form
    {
        private readonly UserService _userService;
        private readonly UserDetailService _userDetailService;
        private readonly PasswordService _passwordService;
        private readonly PasswordHistoryService _passwordHistoryService;

        public frmLogin(UserService userService, UserDetailService userDetailService, PasswordService passwordService, PasswordHistoryService passwordHistoryService)
        {
            InitializeComponent();
            _userService = userService;
            _userDetailService = userDetailService;
            _passwordService = passwordService;
            _passwordHistoryService = passwordHistoryService;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registrationForm = new frmRegister(_userService, _userDetailService, _passwordService, _passwordHistoryService);
            registrationForm.Show();
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var profile = _userService.GetUserByUsernameAndPassword(username,password);
            if (profile != null)
            {
                Properties.Settings.Default.UserId = profile.user.Id;
                Properties.Settings.Default.Username = profile.user.Username;
                Properties.Settings.Default.IsAdmin = profile.user.IsAdmin;
                Properties.Settings.Default.Save();
                frmMaster masterForm = new frmMaster(profile, _userService, _userDetailService, _passwordService, _passwordHistoryService);
                masterForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormHelper.ClearForm(this);
            }
        } 
        private void btmMinimize_Click(object sender, EventArgs e)
        {
            FormHelper.MinimizeForm(this);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            FormHelper.CloseForm(this);
        }

    }
}
