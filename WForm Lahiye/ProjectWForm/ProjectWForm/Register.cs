using ProjectWForm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWForm
{
    public partial class Register : Form
    {
        private Form _login;
        private LibraryEntities db;
        public Register(Form login)
        {
            InitializeComponent();
            _login = login;
            db = new LibraryEntities();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            _login.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
        }

        private async void btnRgsRegister_Click_1(object sender, EventArgs e)
        {
            string name = txtRgsName.Text.Trim();
            string surname = txtRgsSurname.Text.Trim();
            string email = txtRgsEmail.Text.Trim();
            string password = txtRgsPassword.Text.Trim();
            string repeat_password = txtRgsRepeatPassword.Text.Trim();
            if (CheckRegistration(name, surname, email, password, repeat_password))
            {
                string hashPassword = Extension.HashPassword(password);
                User user = new User()
                {
                    Name = name,
                    Surname = surname,
                    Password = hashPassword,
                    Email = email
                };
                db.Users.Add(user);
                await db.SaveChangesAsync();
                MessageBox.Show("Registration is successfully,please wait confirmation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private bool CheckRegistration(string name, string surname, string email, string password, string repeat_password)
        {
            if (!this.CheckInput())
            {
                MessageBox.Show("Please fill all input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (!txtRgsEmail.Text.IsEmail())
            {
                MessageBox.Show("Please email correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (password != repeat_password)
            {
                MessageBox.Show("Please repeat password correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (db.Users.Any(u => u.Email == email))
            {
                MessageBox.Show("This email already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
