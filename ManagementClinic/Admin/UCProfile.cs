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
    public partial class UCProfile : UserControl
    {
        Function fn = new Function();
        String query;

        public UCProfile()
        {
            InitializeComponent();
        }
        public string ID { set { userName.Text = value; } }
        private void UCProfile_Load(object sender, EventArgs e)
        {

        }



        private void UCProfile_Enter(object sender, EventArgs e)
        {

            query = "SELECT * FROM users WHERE username = '" + userName.Text + "'";
            DataSet ds = fn.GetData(query);


            if (ds.Tables[0].Rows.Count > 0)
            {
                txtRole.Text = ds.Tables[0].Rows[0]["userRole"].ToString();
                txtName.Text = ds.Tables[0].Rows[0]["name"].ToString();

                string gender = ds.Tables[0].Rows[0]["gender"].ToString();
                if (gender == "Female")
                {
                    rdFemale.Checked = true;
                }
                else
                {
                    rdMale.Checked = true;
                }

                txtAddress.Text = ds.Tables[0].Rows[0]["address"].ToString();
                txtDob.Text = ds.Tables[0].Rows[0]["dob"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[0]["mobile"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtPassword.Text = ds.Tables[0].Rows[0]["pass"].ToString();
            }
            else
            {

                MessageBox.Show("User not found.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            UCProfile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String role = txtRole.Text;
                String name = txtName.Text;
                String dob = txtDob.Text;
                String email = txtEmail.Text;
                String password = txtPassword.Text;
                String address = txtAddress.Text;
                Int64 mobile = Int64.Parse(txtPhone.Text);
              
                String gender = rdMale.Checked ? "Male" : "Female";

                // Tạo câu truy vấn cập nhật dữ liệu vào bảng users
                query = "UPDATE users SET userRole = '" + role + "', name = '" + name + "', gender = '" + gender + "', dob = '" + dob + "', address = '" + address + "', mobile = '" + mobile + "', email = '" + email + "', pass = '" + password + "' WHERE username = '" + userName.Text + "'";

                // In câu truy vấn để kiểm tra
                Console.WriteLine(query);

                // Thực thi câu truy vấn
                fn.SetData(query, "Cập nhật thành công");

                // Thông báo cập nhật thành công
                MessageBox.Show("User profile updated successfully.");
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Error updating user profile: " + ex.Message);
            }
        }

    }
}
