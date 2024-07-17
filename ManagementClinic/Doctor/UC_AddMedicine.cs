using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementClinic.Doctor
{
    public partial class UC_AddMedicine : UserControl
    {
        Function fn = new Function();
        String query = "";

        public UC_AddMedicine()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            if (txtId.Text != null && txtName.Text != null && txtNumber.Text != null && txtPrice.Text != null && txtQuantity.Text != null)
            {
                String mid = txtId.Text;
                String mname = txtName.Text;
                String mnumber = txtNumber.Text;
                DateTime mDate = DateTime.Parse(txtStartDate.Text);
                DateTime eDate = DateTime.Parse(txtEndDate.Text);

                Int64 perUnit = Int64.Parse(txtPrice.Text);
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                query = " insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mDate + "','" + eDate + "','" + perUnit + "','" + quantity + "')";
                fn.SetData(query, "Thêm thuốc thành công ");

            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin ", "Thông tin ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtEndDate.Text = "";
            txtNumber.Text = "";
            txtStartDate.Text = "";
        }
    }
}
