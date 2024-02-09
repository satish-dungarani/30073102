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
    public partial class UsersControl : UserControl
    {
        private readonly UserService _userService;
        private SortableBindingList<UserModel> _sortableUsers;
        public UsersControl(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            var users = _userService.GetAllUserDetails(textBox1.Text);
            _sortableUsers = new SortableBindingList<UserModel>(users);
            dgvUserGrid.DataSource = _sortableUsers;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var users = _userService.GetAllUserDetails(textBox1.Text);
            _sortableUsers = new SortableBindingList<UserModel>(users);
            dgvUserGrid.DataSource = _sortableUsers;
        }

        private void dgvUserGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dgvUserGrid.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dgvUserGrid.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    dgvUserGrid.SortOrder == SortOrder.Ascending)
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

            dgvUserGrid.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dgvUserGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvUserGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
                column.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
        }
    }
}
