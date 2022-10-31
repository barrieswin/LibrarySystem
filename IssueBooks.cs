using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from NewBook", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();



        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollment.Text != "")
            {
                string eid = txtEnrollment.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll = '" + eid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                //-----------------
                //Count how many book has been issued on this enrollement number
                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll = '" + eid + "' and book_return_date is null ";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                //-----------------



                //if there is student info, display.
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDep.Clear();
                    txtSem.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("沒有此學號","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {

            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                //bug!! count only when click search
                if(comboBoxBooks.SelectedIndex !=-1 && count <= 2)
                {
                    string enroll = txtEnrollment.Text;
                    string sname = txtName.Text;
                    string sdep = txtDep.Text;
                    string sem = txtSem.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    string email = txtEmail.Text;
                    string bookname = comboBoxBooks.Text;
                    string bookIssueDate = dateTimePicker.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    // for string write '"++"'    for int write "++"
                    cmd.CommandText = "insert into IRBook (std_enroll, std_name, std_dep, std_sem, std_contact, std_email, book_name, book_issue_date) values('"+enroll+"', '"+sname+"', '"+sdep+"', '"+sem+"', "+contact+", '"+email+"', '"+bookname+"', '"+bookIssueDate+"' );";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("書籍借出", "借出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("請選擇書籍 或 借出超過數量", "未借出", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("輸入正確學號", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if(txtEnrollment.Text == "")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtContact.Clear();
                txtEmail.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("確定要離開","確認",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
