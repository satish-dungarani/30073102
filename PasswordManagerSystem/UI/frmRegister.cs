using PasswordManagerSystem.Models;
using PasswordManagerSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerSystem.Forms
{
    public partial class frmRegister : Form
    {
        private readonly UserService _userService;

        public frmRegister(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfPassword.Text;

            // Perform basic validation
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

            // Create a new user
            User newUser = new User
            {
                Username = username,
                Password = password
                // You can set other properties as needed
            };

            try
            {
                // Call the service to create the user
                _userService.CreateUser(newUser);
                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                frmLogin loginfrm = new frmLogin(_userService);
                loginfrm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            // Clear text boxes
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfPassword.Text = string.Empty;
        }
    }
}
