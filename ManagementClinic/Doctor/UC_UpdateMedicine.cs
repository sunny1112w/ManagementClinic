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
    public partial class UC_UpdateMedicine : UserControl
    {

        Function fn = new Function();
        String query;
        public UC_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtAddQuantity.Clear();
            txtAvailableQuantity.Clear();
            txtPricePerUnit.Clear();
            if (txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }
        Int64 totalQuantity;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMedicineName.Text;
            String mnumber = txtMedicineNumber.Text;
            String mdate = txtMDate.Text;
            String edate = txtEDate.Text;
            Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);

            totalQuantity = quantity + addQuantity;

            query = "update medic set mname = '" + mname + "', mnumber = '" + mnumber + "', mDate = '" + mdate + "', eDate = '" + edate + "', quantity = " + totalQuantity + ", perUnit = " + unitPrice + "where mid = '" + txtMedicineId.Text + "'";

            fn.SetData(query, "Đã cập nhật chi tiết thuốc.");


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "")
            {
                query = "select * from medic where mid = '" + txtMedicineId.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("Không có thuốc giống ID này!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearAll();
        }

    }
}
