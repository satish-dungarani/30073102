using PasswordManagerSystem.Forms;
using PasswordManagerSystem.Helpers;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Services;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace PasswordManagerSystem.UI
{
    public partial class frmMaster : Form
    {
        private readonly ProfileModel _profile;
        private readonly UserService _userService;
        private readonly UserDetailService _userDetailService;
        private readonly PasswordService _passwordService;
        private readonly PasswordHistoryService _passwordHistoryService;

        private Timer blinkTimer;
        private bool isVisible = true;

        public frmMaster(ProfileModel profile, UserService userService, UserDetailService userDetailService, PasswordService passwordService, PasswordHistoryService passwordHistoryService)
        {
            InitializeComponent();
            InitializeBlinkTimer();
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

            if (Properties.Settings.Default.IsAdmin)
                btnUsers.Visible = true; else btnUsers.Visible = false;

            lblUsername.Text = "Wellcome - " + Properties.Settings.Default.Username + ((Properties.Settings.Default.IsAdmin) ? " (Admin)" : string.Empty);
            HomeControl home = new HomeControl();
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(home);
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
            this.Close();
            frmLogin loginForm = new frmLogin(_userService, _userDetailService, _passwordService, _passwordHistoryService);
            loginForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileControl profileControl = new ProfileControl(_profile, _userDetailService);
            pnlBody.Controls.Clear();
            profileControl.ProfileSaved += profileControl_ProfileSaved;
            pnlBody.Controls.Add(profileControl);
        }
        
        private void profileControl_ProfileSaved(object sender, EventArgs e)
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
        }

        private void btnPasswords_Click(object sender, EventArgs e)
        {
            PasswordGrid passwords = new PasswordGrid(_profile, _passwordService);
            passwords.ButtonClicked += btnPassword_Click;
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(passwords);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            
           
            if (sender is PasswordGrid passwordGrid)
            {
                if (passwordGrid.passId > 0)
                {
                    PasswordControl password = new PasswordControl(_profile, _passwordService);
                    password.passId = passwordGrid.passId;
                    pnlBody.Controls.Clear();
                    pnlBody.Controls.Add(password);
                }
                else
                {
                    PasswordControl password = new PasswordControl(_profile, _passwordService);
                    pnlBody.Controls.Clear();
                    pnlBody.Controls.Add(password);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeControl home = new HomeControl();
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(home);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryGrid history = new HistoryGrid(_profile, _passwordHistoryService);
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(history);
        }

        private void InitializeBlinkTimer()
        {
            blinkTimer = new Timer();
            blinkTimer.Interval = 500; 
            blinkTimer.Tick += BlinkTimer_Tick;
            blinkTimer.Start();
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            isVisible = !isVisible;
            lblUsername.Visible = isVisible;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersControl users = new UsersControl(_userService);
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(users);
        }
    }
}
