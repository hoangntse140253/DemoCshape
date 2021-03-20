using System;
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
    public partial class frmChangeAccount : Form
    {
        
        public EmployeeDTO emp { get; set; }
        public frmChangeAccount()
        {
            InitializeComponent();
        }
        public frmChangeAccount(EmployeeDTO dto) : this()
        {
            emp = dto;
            initData();
        }
        private void initData()
        {
            txtEmpID.Text = emp.EmpID.ToString();
            txtEmpPassword.Text = emp.EmpPassword.ToString();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string empID = txtEmpID.Text;
            string newPass = txtNewPass.Text;
            string reNewPass = txtReNewPass.Text;

            if (newPass.Equals(reNewPass))
            {
                string sql = "UPDATE Employee " +
                             "SET empPassword = '"+newPass+"' " +
                             "WHERE empID = '"+empID+"'" ;
                int result = DataAccess.Instance.ExecuteNonQuery(sql);
                if (result>0)
                {
                    MessageBox.Show("Password Update Success");
                }
                else
                {
                    MessageBox.Show("Password Update Failed");
                }
            }
            else
            {
                MessageBox.Show("Password don't correct!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
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
