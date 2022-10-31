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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibrarySystem
{
    public partial class ViewStudentInformation : Form
    {

        //#region 跟資料庫有關係
        //private SqlConnection con;
        //private SqlCommand cmd;
        //private SqlDataAdapter da;
        //private DataSet ds;
        //#endregion

        //#region 跟連線有關係
        //private void accessSql(string conString, string sqlCmd)
        //{

        //}
        //#endregion

        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void txtSearchEnrollement_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollement.Text != "")
            {
                label1.Visible = false;
                Image image = Image.FromFile("C:\\Users\\Mark\\Desktop\\Liberay Management System\\search1.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll like '" + txtSearchEnrollement.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("C:\\Users\\Mark\\Desktop\\Liberay Management System\\search.gif");
                pictureBox1.Image = image;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where stuid =" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnrollment.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSemister.Text = ds.Tables[0].Rows[0][4].ToString();
            txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sname = txtSName.Text;
            string enroll = txtEnrollment.Text;
            string dep = txtDepartment.Text;
            string sem = txtSemister.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            string email = txtEmail.Text;


            if (MessageBox.Show("確定要更新學員資料", "更新資料", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set sname = '" + sname + "', enroll = '" + enroll + "', dep = '" + dep + "',  sem = '" + sem + "',  contact =  '" + contact + "',  email = '" + email + "'  where stuid = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewStudentInformation_Load(this, null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewStudentInformation_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除學員資料", "刪除資料", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent where stuid = "+rowid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewStudentInformation_Load(this, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("資料未儲存,確定要關閉?", "關閉前確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
