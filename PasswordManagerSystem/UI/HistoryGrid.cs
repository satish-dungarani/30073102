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

namespace PasswordManagerSystem.UI
{
    public partial class HistoryGrid : UserControl
    {

        private readonly ProfileModel _profileModel;
        private readonly PasswordHistoryService _passwordHistoryService;

        public HistoryGrid(ProfileModel profileModel, PasswordHistoryService passwordHistoryService)
        {
            InitializeComponent();
            _profileModel = profileModel;
            _passwordHistoryService = passwordHistoryService;
        }

        private void HistoryGrid_Load(object sender, EventArgs e)
        {
            dgvHistory.DataSource = _passwordHistoryService.GetPasswordHistoriesByUserId(_profileModel.user.Id, txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvHistory.DataSource = _passwordHistoryService.GetPasswordHistoriesByUserId(_profileModel.user.Id, txtSearch.Text);
        }
    }
}
