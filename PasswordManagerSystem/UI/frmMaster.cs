using PasswordManagerSystem.Forms;
using PasswordManagerSystem.Helpers;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PasswordManagerSystem.UI
{
    public partial class frmMaster : Form
    {
        private readonly ProfileModel _profile;
        private readonly UserService _userService;
        private readonly UserDetailService _userDetailService;
        private readonly PasswordService _passwordService;
        private readonly PasswordHistoryService _passwordHistoryService;

        public frmMaster(ProfileModel profile, UserService userService, UserDetailService userDetailService, PasswordService passwordService, PasswordHistoryService passwordHistoryService)
        {
            InitializeComponent();
            _profile = profile;
            _userService = userService;
            _userDetailService = userDetailService;
            _passwordService = passwordService;
            _passwordHistoryService = passwordHistoryService;
        }

        private void frmMaster_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(
                     Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                     "Content\\Images\\" + _profile.user.Id + ".jpg"));
            }
            catch (Exception)
            {
            }
            
            lblUsername.Text = "Wellcome - " + Properties.Settings.Default.Username;
        }

        private void btmMinimize_Click(object sender, EventArgs e)
        {
            FormHelper.MinimizeForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormHelper.CloseForm(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormHelper.CloseForm(this);
            frmLogin loginForm = new frmLogin(_userService, _userDetailService, _passwordService, _passwordHistoryService);
            loginForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileControl profileControl = new ProfileControl(_profile, _userDetailService);
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(profileControl);
        }

        private void btnPasswords_Click(object sender, EventArgs e)
        {
            PasswordGrid passwords = new PasswordGrid(_profile, _passwordService);
            passwords.ButtonClicked += btnPassword_Click;
            passwords.ButtonClicked += btnPassword_Click;
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(passwords);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
           
            PasswordControl password = new PasswordControl(_profile, _passwordService);

            if (sender is PasswordGrid passwordGrid)
            {
                pnlBody.Controls.Clear();
                pnlBody.Controls.Add(password);
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryGrid history = new HistoryGrid(_profile, _passwordHistoryService);
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(history);
        }

    }
}
