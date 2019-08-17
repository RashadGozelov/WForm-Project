using ProjectWForm.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWForm
{
    public partial class Login : Form
    {
        private LibraryEntities db;
        private User usr;
        public Login()
        {
            InitializeComponent();
            db = new LibraryEntities();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
        }
        private void checkPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPassword.Text.Trim();
            if (CheckLogin(email, password))
            {
                if (usr.Level)
                {
                    new AdminDashboard(this, usr).Show();
                }
                else
                {
                    new UserDashboard(this, usr).Show();
                }
            }
        }

        private bool CheckLogin(string email, string password)
        {
            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill all input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string hashPass = Extension.HashPassword(password);
            usr = db.Users.Where(u => u.Email == email).Where(u => u.Password == hashPass).Where(u => u.Deleted == false).FirstOrDefault();
            if (usr == null)
            {
                MessageBox.Show("This user not exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (usr.Status == false)
            {
                MessageBox.Show("Admin not confirm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

       
    }
}
