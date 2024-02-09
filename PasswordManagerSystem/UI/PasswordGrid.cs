using PasswordManagerSystem.Data;
using PasswordManagerSystem.Helpers;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Services;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PasswordManagerSystem.UI
{
    public partial class PasswordGrid : UserControl
    {
        public event EventHandler ButtonClicked;
        private readonly ProfileModel _profileModel;
        private readonly PasswordService _passwordService;
        private SortableBindingList<PasswordModel> _sortablePasswords;
        public int passId = 0;

        public PasswordGrid(ProfileModel profileModel, PasswordService passwordService)
        {
            InitializeComponent();
            _profileModel = profileModel;
            _passwordService = passwordService;
        }

        private void PasswordGrid_Load(object sender, EventArgs e)
        {
            var passwords = _passwordService.GetAllPasswordsByUserId(_profileModel.user.Id, textBox1.Text).ToList();
            _sortablePasswords = new SortableBindingList<PasswordModel>(passwords);
            dgvPasswordGrid.DataSource = _sortablePasswords;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var passwords = _passwordService.GetAllPasswordsByUserId(_profileModel.user.Id, textBox1.Text).ToList();
            _sortablePasswords = new SortableBindingList<PasswordModel>(passwords);
            dgvPasswordGrid.DataSource = _sortablePasswords;
        }

        private void dgvPasswordGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPasswordGrid.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                passId = (int)dgvPasswordGrid.Rows[e.RowIndex].Cells["Id"].Value;
                ButtonClicked?.Invoke(this, EventArgs.Empty);

            }
            else if (dgvPasswordGrid.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                int idValue = (int)dgvPasswordGrid.Rows[e.RowIndex].Cells["Id"].Value;
                _passwordService.DeletePassword(idValue);
                var passwords = _passwordService.GetAllPasswordsByUserId(_profileModel.user.Id, textBox1.Text);
                dgvPasswordGrid.DataSource = passwords;
            }
            else if (dgvPasswordGrid.Columns[e.ColumnIndex].Name == "ViewPassword" && e.RowIndex >= 0)
            {
                string idValue = dgvPasswordGrid.Rows[e.RowIndex].Cells["AppPassword"].Value.ToString();
                MessageBox.Show(FormHelper.DecryptData(idValue), "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPasswordGrid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "AppPassword")
                e.Column.Visible = false;
        }

        private void dgvPasswordGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dgvPasswordGrid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dgvPasswordGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    dgvPasswordGrid.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            dgvPasswordGrid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dgvPasswordGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvPasswordGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
                column.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
        }
    }
}
