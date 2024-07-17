using System.Data;

namespace ManagementClinic
{
    public partial class Form1 : Form
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
        
            query = "select * from users";
            ds = fn .GetData(query);
            if (ds.Tables[0].Rows.Count == 0 )
            {
                if (txtUserName.Text == "root" && txtPassword.Text == "root")
                {
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.ShowDialog();
                    this.Hide();
                }

            }
            else
            {
                query = "select * from users  where username = '"+ txtUserName.Text+"' and pass = '"+txtPassword.Text+"'";
                ds = fn .GetData(query);
                if (ds.Tables[0].Rows.Count != 0 )
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Admin ")
                    {
                        frmAdmin frmAdmin = new frmAdmin(txtUserName.Text);
                        frmAdmin.ShowDialog();
                        this.Hide();
                    }
                    else if (role =="Doctor")
                    {
                        frmDoctor frmDoctor = new frmDoctor();
                        frmDoctor.ShowDialog();
                        this.Hide();
                    }else
                    {
                        frmUser frmUser = new frmUser();
                        frmUser.ShowDialog();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi  UserName hay Password", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
