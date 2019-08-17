using ProjectWForm.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWForm
{
    public partial class UserDashboard : Form
    {
        private Form _login;
        private User _user;
        private LibraryEntities db;
        private ListClass list;
        public UserDashboard(Form login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            db = new LibraryEntities();
        }

        private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            _login.Hide();
            cmbOrderCustomerIDCard.Items.AddRange(db.Customers.Where(c => c.Deleted == false).Select(c => new CB_CustomerID_class
            {
                Id = c.Id,
                IDCard = c.IdCard
            }).ToArray());
            cmbOrderBookGenres.Items.AddRange(db.Genres.Select(b => new CB_class
            {
                Id = b.Id,
                Name = b.Name,
            }).ToArray());
            cmbOrderBookName.Items.AddRange(db.Books.Where(bk => bk.Deleted == false).Select(bk => new CB_class
            {
                Id = bk.Id,
                Name = bk.Name,
                Count=bk.Count
            }).ToArray());
       
            DGV_Refresh();
        }

        private void DGV_Refresh()
        {
            dgvOrderList.DataSource = db.OrderBooks.Where(or => or.Order.Customer.Deleted == false).
               Select(or => new
               {
                   or.Order.Id,
                   or.Order.Customer.IdCard,
                   or.Order.Customer.Name,
                   or.Order.Customer.Surname,
                   Book = or.Book.Name,
                   Counts = 1,
                   or.Order.GiveDate,
                   or.Order.ReturnDate
               }).ToList();
        }

        private void createNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers(this);
            customer.ShowDialog();
        }

        private void orderBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = new Books(this);
            book.ShowDialog();
        }

        private void cmbOrderCustomerIDCard_SelectedValueChanged(object sender, EventArgs e)
        {
            int IDCard = (cmbOrderCustomerIDCard.SelectedItem as CB_CustomerID_class).Id;
            txtOrderCustomerName.Text = db.Customers.SingleOrDefault(c => c.Id == IDCard).Name.ToString();
            txtOrderCustomerSurname.Text = db.Customers.SingleOrDefault(c => c.Id == IDCard).Surname.ToString();
        }

        private void cmbOrderBookGenres_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbOrderBookName.Items.Clear();
            cmbOrderBookName.Text = null;
            txtOrderBookBalances.Text = null;
            int BookGenre = (cmbOrderBookGenres.SelectedItem as CB_class).Id;
            cmbOrderBookName.Items.AddRange(db.Books.Where(b => b.Deleted == false).Where(b => b.GenresId == BookGenre).Select(b => new CB_class
            {
                Id = b.Id,
                Name = b.Name,
                Count=b.Count
            }).ToArray());
        }

        private void cmbOrderBookName_SelectedValueChanged(object sender, EventArgs e)
        {

            int BookName = (cmbOrderBookName.SelectedItem as CB_class).Id;
            txtOrderBookBalances.Text = db.Books.SingleOrDefault(c => c.Id == BookName).Count.ToString();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            CB_class book = cmbOrderBookName.SelectedItem as CB_class;
            string txtSurname = txtOrderCustomerSurname.Text.Trim();
            string txtName = txtOrderCustomerName.Text.Trim();
            string txtBookCount = txtOrderBookCount.Text.Trim();
            string cmbBook = cmbOrderBookName.Text.Trim();

            if (!this.CheckInput())
            {
                MessageBox.Show("Fill all input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtOrderBookCount.Text.IsNumber())
            {
                MessageBox.Show("Please enter the number","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(txtOrderBookCount.Text) > 1)
            {
                MessageBox.Show("This is not correct","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (int.Parse(txtOrderBookBalances.Text) <= 0)
            {
                MessageBox.Show("This book not enough", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (ListClass item in listGiveBook.Items)
            {
                if (book.Id==item.Id)
                {
                    MessageBox.Show("Dont allow","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
            }
            
            CB_class selectGenre = (cmbOrderBookGenres.SelectedItem as CB_class);
            CB_class selectBook = (cmbOrderBookName.SelectedItem as CB_class);
            
            ListClass list = new ListClass()
            {
                Id=selectBook.Id,
                Name=selectBook.Name,
                Price = selectBook.Price,
                Count = selectBook.Count

            };
            listGiveBook.Items.Add(list);

            int total = int.Parse(lblBookCount.Text.Trim());
            lblBookCount.Text = (total + 1).ToString();
            selectBook.Count -= int.Parse(txtOrderBookCount.Text);
            txtOrderBookBalances.Text= selectBook.Count.ToString();
            //txtOrderCustomerName.Text = "";
            //txtOrderCustomerSurname.Text = "";
            //txtOrderBookCount.Text = "";
            //txtOrderBookBalances.Text = "";
        }

        private async void btnGive_Click(object sender, EventArgs e)
        {
            if (!this.CheckInput())
            {
                MessageBox.Show("Fill all input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            DateTime date1 = dateTimeReturn.Value;
            int count = cmbOrderBookName.Items.Count;
            int customerId = (cmbOrderCustomerIDCard.SelectedItem as CB_CustomerID_class).Id;

            Order order = new Order()
            {
                GiveDate = date,
                ReturnDate = date1,
                CustomersId = customerId,
                UsersId = _user.Id,
            };
            db.Orders.Add(order);
            await db.SaveChangesAsync();

            foreach (ListClass item in listGiveBook.Items)
            {
                order.OrderBooks.Add(new OrderBook
                {
                    BooksId = item.Id,
                    OrdersId = order.Id
                });
            }
            foreach (ListClass item in listGiveBook.Items)
            {
                DecrementBook(item);
            }
            MessageBox.Show("Order successfully completed");
            listGiveBook.Items.Clear();
            lblBookCount.Text = "0";
            DGV_Refresh();
        }

        private void DecrementBook(ListClass book)
        {
            Book decrementbook = db.Books.Where(b => b.Id == book.Id).First();
            decrementbook.Count = decrementbook.Count - book.Count;
            db.SaveChangesAsync();
        }


        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            ListClass removeFromList = listGiveBook.SelectedItem as ListClass;
            listGiveBook.Items.Remove(removeFromList);
            foreach (CB_class CmbBook in cmbOrderBookName.Items)
            {
                try
                {
                    if (CmbBook.Id == removeFromList.Id)
                    {
                    CmbBook.Count += 1;
                    txtOrderBookBalances.Text = CmbBook.Count.ToString();
                    int total = int.Parse(lblBookCount.Text.Trim());
                    lblBookCount.Text = (total - 1).ToString();
                    }
                }
                catch 
                {
                    MessageBox.Show("Dont correct", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap b = new Bitmap(this.dgvOrderList.Width, this.dgvOrderList.Height);
            dgvOrderList.DrawToBitmap(b, new Rectangle(0, 0, this.dgvOrderList.Width, this.dgvOrderList.Height));

            e.Graphics.DrawImage(b, 150, 150);

            e.Graphics.DrawString("First Print", new Font("First", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));


        }
    }
}
