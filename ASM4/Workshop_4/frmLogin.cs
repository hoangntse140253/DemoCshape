using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_4.DTO;

namespace Workshop_4
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        bool Login(string empID, string empPassword)
        {
            string sql = "SELECT empID, empPassword " +
                         "FROM Employee " +
                         "WHERE empID = N'" + empID + "' AND empPassword = N'" + empPassword + "' ";
            DataTable result = DataAccess.Instance.ExecuteQuery(sql);
            return result.Rows.Count > 0;
        }
        bool checkRole(string empID)
        {
            string sql = "SELECT empRole " +
                         "FROM Employee " +
                         "WHERE empID = N'" + empID + "'";
            DataTable result = DataAccess.Instance.ExecuteQuery(sql);
            ArrayList list = new ArrayList();
            foreach (DataRow item in result.Rows)
            {
                string isRole = item["empRole"].ToString();
                list.Add(isRole);
            }
            return list[0].ToString().Equals("True") ? true : false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string empID = txtEmpID.Text;
            string empPassword = txtEmpPassword.Text;
            if (Login(empID, empPassword))
            {
                if (checkRole(empID))
                {
                    frmMaintainBooks f = new frmMaintainBooks();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (!checkRole(empID))
                {
                    EmployeeDTO dto = new EmployeeDTO(txtEmpID.Text,txtEmpPassword.Text, checkRole(empID));
                    frmChangeAccount f = new frmChangeAccount(dto);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("User or Password Error!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
