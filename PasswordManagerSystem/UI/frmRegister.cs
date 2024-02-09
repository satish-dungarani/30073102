using PasswordManagerSystem.Data;
using PasswordManagerSystem.Helpers;
using PasswordManagerSystem.Services;
using System;
using System.Windows.Forms;

namespace PasswordManagerSystem.Forms
{
    public partial class frmRegister : Form
    {
        private readonly UserService _userService;
        private readonly UserDetailService _userDetailService;
        private readonly PasswordService _passwordService;
        private readonly PasswordHistoryService _passwordHistoryService;
        public frmRegister(UserService userService, UserDetailService userDetailService, PasswordService passwordService, PasswordHistoryService passwordHistoryService)
        {
            InitializeComponent();
            _userService = userService;
            _userDetailService = userDetailService;
            _passwordService = passwordService;
            _passwordHistoryService = passwordHistoryService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {
                Username = username,
                Password = password,
                CreatedOn = DateTime.Now,
                IsActive = true,
                IsAdmin = false,
                CreatedBy = 1
            };

            try
            {
                _userService.CreateUser(newUser);
                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHelper.ClearForm(this);
                this.Hide();
                frmLogin loginfrm = new frmLogin(_userService, _userDetailService, _passwordService, _passwordHistoryService);
                loginfrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
