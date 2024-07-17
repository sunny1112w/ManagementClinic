using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementClinic.Admin
{
    public partial class UC_ViewUser : UserControl
    {
        Function fn = new Function();
        String query;
        String currentUser = "";


        public UC_ViewUser()
        {
            InitializeComponent();
        }
        public String ID
        {
            set { currentUser = value; }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users  where username like '" + txtSearch.Text + "%'";

            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = " select * from  users ";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String userName;


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi chọn người dùng: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn ?", "Xóa thông tin !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != userName)
                {
                    string query = "DELETE FROM users WHERE username = '" + userName + "'";

                    try
                    {
                        fn.SetData(query, "Đã xóa ");
                        MessageBox.Show("Đã xóa người dùng.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa người dùng: " + ex.Message);
                    }

                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn thử xóa lại \n Hồ sơ của bạn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnSyn_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }
    }
}
