using ProjectWForm.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWForm
{
    public partial class Books : Form
    {
        private LibraryEntities db;
        private Book bk;
        private Book update_delete;
        private UserDashboard _userdashboard;
        public Books(UserDashboard userDashboard)
        {
            InitializeComponent();
            _userdashboard = userDashboard;
            db = new LibraryEntities();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            Fill();
            cmbGenres.Items.AddRange(db.Genres.Select(g => new CB_class { Id = g.Id, Name = g.Name }).ToArray());
          
        }

        private void Fill()
        {
            dgvBookList.DataSource = db.Books.Where(bk => bk.Deleted == false).Select(bk => new
            {
                bk.Id,
                bk.Name,
                bk.Price,
                bk.Count,
                Genre=bk.Genre.Name
            }).OrderByDescending(bk=>bk.Id).ToList();
        }
        
        private async void btnCreateBook_Click(object sender, EventArgs e)
        {
            string name = txtBookName.Text.Trim();
            string price = txtPrice.Text.Trim();
            string count = txtCount.Text.Trim();
            string genre = cmbGenres.Text.Trim();

            if (!this.CheckInput() || genre=="")
            {
                MessageBox.Show("Fill all input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.cmbGenres.DropDownStyle = ComboBoxStyle.DropDownList;
            if (!txtPrice.Text.IsNumber() || !txtCount.Text.IsNumber())
            {
                MessageBox.Show("Please enter the number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (cmbGenres.SelectedItem as CB_class).Id;
            bk = new Book { Name = name, Price = decimal.Parse(price), Count = int.Parse(count),GenresId=id};
            db.Books.Add(bk);
            await db.SaveChangesAsync();
            MessageBox.Show("Success added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            dgvBookList.DataSource = null;
            Fill();
            txtBookName.Text = null;
            txtPrice.Text = null;
            txtCount.Text = null;
            cmbGenres.Text = null;
        }

        private void dgvBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookName.BackColor= System.Drawing.Color.White;
            txtPrice.BackColor = System.Drawing.Color.White;
            txtCount.BackColor = System.Drawing.Color.White;
            int Id = (int)dgvBookList.Rows[e.RowIndex].Cells[0].Value;

            update_delete = db.Books.Find(Id);
            txtBookName.Text = update_delete.Name;
            txtPrice.Text = update_delete.Price.ToString();
            txtCount.Text = update_delete.Count.ToString();
            cmbGenres.Text = update_delete.Genre.Name.ToString();
            btnVisible(true);
        }
        private void btnVisible(bool b)
        {
            if (b)
            {
                btnCreateBook.Visible = false;
                btnUpdateBook.Visible = true;
                btnDeleteBook.Visible = true;
            }
            else
            {
                btnCreateBook.Visible = true;
                btnUpdateBook.Visible = false;
                btnDeleteBook.Visible = false;
            }
        }

        private void createBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnVisible(false);
            txtBookName.Text = null;
            txtPrice.Text = null;
            txtCount.Text = null;
            cmbGenres.Text = null;
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            string name = txtBookName.Text.Trim();
            string price = txtPrice.Text.Trim();
            string count = txtCount.Text.Trim();
            string genres = cmbGenres.Text.Trim();

            if (name == "" || price == "" || count == "" || genres == "")
            {
                MessageBox.Show("Fill all input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!txtPrice.Text.IsNumber() && !txtCount.Text.IsNumber())
            {
                MessageBox.Show("Please enter the number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = (cmbGenres.SelectedItem as CB_class).Id;
            bk = new Book { Name = name, Price = decimal.Parse(price), Count = int.Parse(count), GenresId = id };
            
            update_delete.Name = bk.Name;
            update_delete.Price = bk.Price;
            update_delete.Count = bk.Count;
            update_delete.GenresId = bk.GenresId.Value;
            await db.SaveChangesAsync();
            UpdateDataGridView();
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult responce = MessageBox.Show($"Are yo sure delete {update_delete.Name}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (responce == DialogResult.Yes)
            {
                update_delete.Deleted = true;
                await db.SaveChangesAsync();
                Fill();
                txtBookName.Text = null;
                txtPrice.Text = null;
                txtCount.Text = null;
                cmbGenres.Text = null;
            }
        }

        private void Books_FormClosing(object sender, FormClosingEventArgs e)
        {
            _userdashboard.cmbOrderBookName.Items.Clear();
            _userdashboard.cmbOrderBookName.Items.AddRange(db.Books.Where(bk => bk.Deleted == false).Select(bk => new CB_class
            {
                Id = bk.Id,
                Name = bk.Name
            }).ToArray());
        }
    }
}
