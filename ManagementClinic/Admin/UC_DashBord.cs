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
    public partial class UC_DashBord : UserControl
    {
        Function fn = new Function();
        DataSet ds;
        String query;
        public UC_DashBord()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_DashBord_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users  where  userRole  = 'Admin '";
            ds = fn.GetData(query);
            setLabel(ds, lbnAdmin);
            query = "select count(userRole) from users  where  userRole  = 'Customer '";
            ds = fn.GetData(query);
            setLabel(ds, lbnUser);
            query = "select count(userRole) from users  where  userRole  = 'Doctor'";
            ds = fn.GetData(query);
            setLabel(ds, lbnDoctor);

        }
        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void btnSyn_Click(object sender, EventArgs e)
        {
            UC_DashBord_Load(this, null);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
