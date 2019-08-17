using ProjectWForm.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWForm
{
    public partial class AdminDashboard : Form
    {
        private Form _login;
        private User _user;
        private LibraryEntities db;
        public AdminDashboard(Form login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            db = new LibraryEntities();
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            _login.Hide();
            dgvUser.DataSource = db.Users.Where(u=>u.Deleted==false).Select(u => new
            {
                u.Id,
                Fullname = u.Name + " " + u.Surname,
                u.Level,
                u.Status
            }).OrderByDescending(u => u.Id).ToList();
            NewUserButtonText();
        }

        private void btnNewUser_Click_1(object sender, EventArgs e)
        {
            dgvUser.DataSource = null;
            dgvUser.DataSource = db.Users.Where(u => u.Deleted == false).Where(u => u.Status == false).Select(u => new
            {
                u.Id,
                Fullname = u.Name + " " + u.Surname,
                u.Level,
                u.Status
            }).OrderByDescending(u => u.Id).ToList();
        }

        private async void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = (int)dgvUser.Rows[e.RowIndex].Cells[0].Value;
            User usr = db.Users.Find(Id);
            DialogResult responce = MessageBox.Show("Are you sure confirm ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (responce == DialogResult.Yes)
            {
                usr.Status = true;
            }
            else
            {
                usr.Deleted = true;
            }
            
            await db.SaveChangesAsync();
            int count = db.Users.Where(u => u.Deleted == false).Where(u => u.Status == false).Count();
            btnNewUser.Text = "New User:" + " " + count;
            btnNewUser.BackColor = System.Drawing.Color.Gray;
            dgvUser.DataSource = null;
            dgvUser.DataSource = db.Users.Where(u => u.Deleted == false).Where(u => u.Status == false).Select(u => new
            {
                u.Id,
                Fullname = u.Name + " " + u.Surname,
                u.Level,
                u.Status
            }).OrderByDescending(u => u.Id).ToList();
        }
        private void NewUserButtonText()
        {

            int count = db.Users.Where(u => u.Deleted == false).Where(u => u.Status == false).Count();
            btnNewUser.Text = "New User:" + " " + count;
            if (count>0)
            {
                btnNewUser.BackColor = System.Drawing.Color.LimeGreen;
                return;
            }
            else
            {
                btnNewUser.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void btnAdminGoUserPage_Click(object sender, EventArgs e)
        {
            UserDashboard user_page = new UserDashboard(_login, _user);
            user_page.ShowDialog();
        }
    }
}
