using ManagementClinic.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementClinic
{
    public partial class frmAdmin : Form
    {
        String user = "";

        public frmAdmin()
        {
            InitializeComponent();
        }
        public string ID { get { return user.ToString(); } }
        public frmAdmin(string userName)
        {
            InitializeComponent();
            lbnUserName.Text = userName;
            user = userName;
            uC_ViewUser1.ID = ID;
            ucProfile1.ID = ID;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void lbnUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            uC_DashBord2.Visible = true;
            uC_DashBord2.BringToFront();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            uC_DashBord2.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            ucProfile1.Visible = false;
            btnDashbord.PerformClick();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_DashBord2_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucProfile1.Visible = true;
            ucProfile1.BringToFront();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void uC_ViewUser1_Load(object sender, EventArgs e)
        {

        }

        private void ucProfile1_Load(object sender, EventArgs e)
        {

        }
    }
}
