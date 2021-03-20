using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_4
{
    public partial class frmBookReport : Form
    {
        DataTable listBook = new DataTable();
        private string columnName = "bookName";
        public frmBookReport()
        {
            InitializeComponent();
            loadBook(columnName);
        }
        private DataTable getListBook(string columnName)
        {
            string sql = "SELECT bookID AS [Mã Sách], bookName AS [Tên Sách], bookPrice AS [Đơn Giá] " +
                         "FROM Books " +
                         "ORDER BY "+columnName+" DESC";
            return DataAccess.Instance.ExecuteQuery(sql);
        }
        private void loadBook(string columnName)
        {
            listBook = getListBook(columnName);
            dtgvReport.DataSource = listBook;
            totalPrice();
        }
        private void totalPrice()
        {
            
        }
        private void btnOrderByName_Click(object sender, EventArgs e)
        {
            columnName = "bookName";
            loadBook(columnName);
        }

        private void btnOrderByPrice_Click(object sender, EventArgs e)
        {
            columnName = "bookPrice";
            loadBook(columnName);
        }
    }
}
