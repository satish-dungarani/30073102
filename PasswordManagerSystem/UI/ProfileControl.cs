using PasswordManagerSystem.Models;
using PasswordManagerSystem.Services;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PasswordManagerSystem.UI
{
    public partial class ProfileControl : UserControl
    {
        private readonly ProfileModel _profileModel;
        private readonly UserDetailService _userDetailService;
        public ProfileControl(ProfileModel profileModel, UserDetailService userDetailService)
        {
            InitializeComponent();
            _profileModel = profileModel;
            _userDetailService = userDetailService;
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            txtFirstname.Text = _profileModel.userDetail?.Firstname;
            txtLastname.Text = _profileModel?.userDetail?.Lastname;
            txtEmail.Text = _profileModel.userDetail?.Email;
            txtMobile.Text = _profileModel.userDetail?.Mobile;
            txtUserDetailId.Text = _profileModel.userDetail?.Id.ToString();
            txtUserId.Text = _profileModel.user?.Id.ToString();
            try
            {
                picProf.Image = Image.FromFile(
                     Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                     "Content\\Images\\" + _profileModel.user.Id + ".jpg"));
            }
            catch (Exception)
            {
                picProf.Image = Image.FromFile(
                    Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                    "Content\\Images\\profile.png"));
            }

        }

        private void bnUpdate_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail()
            {
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                Email = txtEmail.Text,
                Mobile = txtMobile.Text,
                UserId = Convert.ToInt32(txtUserId.Text)
            };

            if (string.IsNullOrEmpty(txtUserDetailId.Text))
            {
                _userDetailService.CreateUserDetail(userDetail);
                picProf.Image?.Save(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                        "Content\\Images\\" + userDetail.UserId + ".jpg"), ImageFormat.Jpeg);
                MessageBox.Show("User Profile created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                userDetail.Id = Convert.ToInt32(txtUserDetailId.Text);
                _userDetailService.UpdateUserDetail(userDetail);
                picProf.Image?.Save(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                   "Content\\Images\\" + userDetail.UserId + ".jpg"), ImageFormat.Jpeg);
                    

                MessageBox.Show("User Profile created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (sender is frmMaster master)
            {
                master.Show();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imgLoc = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG Files (*.jpg, *.jpeg)|*.jpg;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgLoc = openFileDialog.FileName;
                picProf.ImageLocation = imgLoc;
            }
        }
    }
}
