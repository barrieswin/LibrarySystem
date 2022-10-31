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

namespace LibrarySystem
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPubl.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                string bname = txtBookName.Text;
                string bauthor = txtAuthor.Text;
                string publ = txtPubl.Text;
                string pdate = dateTimePicker1.Text;

                //注意error when input is not int
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\sqlexpress; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName, bAuthor, bPubl, bPDate, bPrice, bQuan) values ('" + bname + "', '" + bauthor + "', '" + publ + "', '" + pdate + "', '" + price + "', '" + quan + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("書本儲存成功.", "儲存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBookName.Clear();
                txtAuthor.Clear();
                txtPubl.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("所有項目都必須填寫", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("未儲存資料會被刪除, 確定要關閉?", "關閉前確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
