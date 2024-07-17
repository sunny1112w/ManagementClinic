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
    public partial class UC_AddUser : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtRole.Text;
            String name = txtName.Text;
            String address = txtAddress.Text;
            String gender = "";
            if (rdMale.Checked)
            {
                gender = "Male";
            }
            else if (rdFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dob;
            if (!DateTime.TryParse(txtDob.Text, out dob))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập ngày sinh hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Int64 mobile = Int64.Parse(txtPhone.Text);
            String email = txtEmail.Text;
            String username = txtUserName.Text;
            String password = txtPassword.Text;
            try
            {
                query = "insert into users (userRole,name, gender ,address,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','"+gender+"','"+address+"','" + dob + "','" + mobile + "', '" + email + "','" + username + "','" + password + "')  ";
                fn.SetData(query, "Sign up successfully");
            }
            catch (Exception)
            {

                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDob.ResetText();
            txtEmail.Clear();
            txtPhone.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtRole.SelectedIndex = -1;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users  where  username = '" + txtUserName.Text + "'";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictrAddUser.ImageLocation = @"C:\Users\ADMIN\Pictures\Saved Pictures\image_pharmacy\yes.png";
            }
            else
            {
                pictrAddUser.ImageLocation = @"C:\Users\ADMIN\Pictures\Saved Pictures\image_pharmacy\no.png";

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
