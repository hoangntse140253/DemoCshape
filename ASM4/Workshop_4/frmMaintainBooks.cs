using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_4.DTO;

namespace Workshop_4
{
    public partial class frmMaintainBooks : Form
    {
        DataTable listBook = new DataTable();
        int pos = 0;

        public frmMaintainBooks()
        {
            InitializeComponent();
            loadBook();
        }
        private DataTable getListBook()
        {
            string sql = "SELECT bookID AS [Mã Sách], bookName AS [Tên Sách], bookPrice AS [Đơn Giá] " +
                         "FROM Books";
            return DataAccess.Instance.ExecuteQuery(sql);
        }
        private void showBook(int index)
        {
            txtID.Text = listBook.Rows[index][0].ToString();
            txtName.Text = listBook.Rows[index][1].ToString();
            txtPrice.Text = listBook.Rows[index][2].ToString();
        }
        private void loadBook()
        {
            listBook = getListBook();
            /*dtgvBooks.DataSource = listBook;
            dtgvBooks.RowHeadersVisible = false;*/
        }
        #region record
        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showBook(pos);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = listBook.Rows.Count - 1;
            showBook(pos);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos >= 0)
            {
                showBook(pos);
            }
            else
            {
                MessageBox.Show("FIRST");
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pos++;
            if(pos < listBook.Rows.Count)
            {
                showBook(pos);
            }
            else
            {
                MessageBox.Show("Cuối danh sách");
                pos = listBook.Rows.Count - 1;
            }
        }
        #endregion
        #region CRUD method
        private void addBook(int bookID, string bookName, float bookPrice)
        {
            string sql = "INSERT INTO Books " +
                         "VALUES ("+bookID+",'"+bookName+"',"+bookPrice+")";
            bool result = DataAccess.Instance.ExecuteNonQuery(sql) > 0;
            if (result)
            {
                MessageBox.Show("ADD Success");
            }
            else
            {
                MessageBox.Show("ADD Failed");
            }

            loadBook();
        }
        private void updateBook(int bookID, string bookName, float bookPrice)
        {
            string sql = "UPDATE Books " +
                         "SET bookName = '"+bookName+"', bookPrice = "+bookPrice+" " +
                         "WHERE bookID = "+bookID+"";
            bool result = DataAccess.Instance.ExecuteNonQuery(sql) > 0;
            if (result)
            {
                MessageBox.Show("Update Success");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }

            loadBook();
        }
        private void deleteBook(int bookID)
        {
            string sql = "DELETE FROM Books " +
                         "WHERE bookID = "+bookID+"";
            bool result = DataAccess.Instance.ExecuteNonQuery(sql) > 0;
            if (result)
            {
                MessageBox.Show("Delete Success");
            }
            else
            {
                MessageBox.Show("Delelet Failded");
            }

            loadBook();
        }
        #endregion
        #region CRUD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.ReadOnly == true)
            {
                txtID.ReadOnly = false;
                txtID.Clear();
                txtName.Clear();
                txtPrice.Clear();
            }
            else
            {
                int bookID =Convert.ToInt32(txtID.Text);
                string bookName = txtName.Text;
                float bookPrice = Convert.ToInt64(txtPrice.Text);
                addBook(bookID, bookName, bookPrice);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(txtID.Text);
            string bookName = txtName.Text;
            float bookPrice = Convert.ToInt64(txtPrice.Text);
            updateBook(bookID, bookName, bookPrice);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(txtID.Text);
            deleteBook(bookID);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            frmBookReport f = new frmBookReport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to Exit?",
                            "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
               
        }
    }
}
