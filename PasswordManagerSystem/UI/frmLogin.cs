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
    public partial class frmLogin : Form
    {
        private readonly UserService _userService;

        public frmLogin(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registrationForm = new frmRegister(_userService);
            registrationForm.Show();
            this.Hide();
        }
    }
}
