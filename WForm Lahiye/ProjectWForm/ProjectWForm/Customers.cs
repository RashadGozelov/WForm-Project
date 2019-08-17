using ProjectWForm.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWForm
{
    public partial class Customers : Form
    {
        private LibraryEntities db;
        private Customer ct;
        private Customer update_delete;
        private UserDashboard _userdashboard;
        public Customers(UserDashboard userDashboard)
        {
            InitializeComponent();
            _userdashboard = userDashboard;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            db = new LibraryEntities();
            Fill();
        }

        private void Fill()
        {
            var custom = db.Customers.Where(ct => ct.Deleted == false).Select(ct => new
            {
                ct.Id,
                ct.Name,
                ct.Surname,
                ct.IdCard
            }).OrderByDescending(st => st.Id).ToList();
            dgvCustomerList.DataSource = custom;
        }
        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnVisible(false);
            txtCustomerName.Text = null;
            txtCustomerSurname.Text = null;
            txtCustomerIdCard.Text = null;
        }
        
        private async void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            string surname = txtCustomerSurname.Text.Trim();
            string idcard = txtCustomerIdCard.Text.Trim();
            if (!this.CheckInput())
            {
                MessageBox.Show("Fill all input", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!idcard.IsNumber())
            {
                MessageBox.Show("Please enter the number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (db.Customers.Any(c=>idcard==c.IdCard))
            {
                MessageBox.Show("This IDCard already used","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            ct = new Customer { Name = name, Surname = surname, IdCard = idcard };
            db.Customers.Add(ct);
            await db.SaveChangesAsync();
            MessageBox.Show("Success added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            dgvCustomerList.DataSource = null;
            Fill();
            txtCustomerName.Text = null;
            txtCustomerSurname.Text = null;
            txtCustomerIdCard.Text = null;
        }

        private void dgvCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.BackColor = System.Drawing.Color.White;
            txtCustomerSurname.BackColor = System.Drawing.Color.White;
            txtCustomerIdCard.BackColor = System.Drawing.Color.White;

            int Id = (int)dgvCustomerList.Rows[e.RowIndex].Cells[0].Value;

            update_delete = db.Customers.Find(Id);
            txtCustomerName.Text = update_delete.Name;
            txtCustomerSurname.Text = update_delete.Surname;
            txtCustomerIdCard.Text = update_delete.IdCard;
            btnVisible(true);
        }

        private void btnVisible(bool b)
        {
            if (b)
            {
                btnCreateCustomer.Visible = false;
                btnUpdateCustomer.Visible = true;
                btnDeleteCustomer.Visible = true;
            }
            else
            {
                btnCreateCustomer.Visible = true;
                btnUpdateCustomer.Visible = false;
                btnDeleteCustomer.Visible = false;
            }
        }

        private async void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            string surname = txtCustomerSurname.Text.Trim();
            string idcard = txtCustomerIdCard.Text.Trim();
            if (!this.CheckInput())
            {
                MessageBox.Show("Fill all input", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!idcard.IsNumber())
            {
                MessageBox.Show("Please enter the number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ct = new Customer { Name = name, Surname = surname, IdCard = idcard };
            MessageBox.Show("Success added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
            update_delete.Name = ct.Name;
            update_delete.Surname = ct.Surname;
            update_delete.IdCard = ct.IdCard;
            await db.SaveChangesAsync();
            UpdateDataGridView();
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult responce = MessageBox.Show($"Are yo sure delete {update_delete.Name}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (responce == DialogResult.Yes)
            {
                update_delete.Deleted = true;
                await db.SaveChangesAsync();
                UpdateDataGridView();
            }
        }

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
           _userdashboard.cmbOrderCustomerIDCard.Items.AddRange(db.Customers.Where(c => c.Deleted == false).Select(c => new CB_CustomerID_class
            {
                Id = c.Id,
                IDCard = c.IdCard
            }).ToArray());
        }
    }
}
