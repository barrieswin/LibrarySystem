using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibrarySystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("確定要關閉?", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            {
                this.Close();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemister.Clear();
            txtContact.Clear();
            //txtEmail.Clear();
            txtEmail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text!="" && txtEnrollment.Text!="" && txtDepartment.Text!="" && txtSemister.Text!="" && txtContact.Text!="" && txtEmail.Text != "")
            {
                string name = txtName.Text;
                string enroll = txtEnrollment.Text;
                string dep = txtDepartment.Text;
                string sem = txtSemister.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                string email = txtEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent (sname, enroll, dep, sem, contact , email) values ('" + name + "', '" + enroll + "', '" + dep + "', '" + sem + "', " + mobile + ", '" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料已儲存", "儲存資料", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("請全部填寫", "建議", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }
    }
}
