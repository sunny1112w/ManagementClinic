using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace ManagementClinic.Doctor
{
    public partial class UC_SellMedicine : UserControl
    {
        Function fn = new Function();
        String query = "";
        DataSet ds;
        public UC_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "SELECT mname FROM medic WHERE eDate >= GETDATE() AND quantity > 0";
            ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "SELECT mname FROM medic WHERE mname LIKE '" + txtSearch.Text + "%' AND eDate >= GETDATE() AND quantity > 0";
            ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnit.Clear();
            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMedicineName.Text = name;
            query = "SELECT mid, eDate, perUnit FROM medic WHERE mname = '" + name + "'";
            ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtMedicineId.Text = ds.Tables[0].Rows[0][0].ToString();
                txtExprideDate.Text = ds.Tables[0].Rows[0][1].ToString();
                txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
            }
        }

        private void txtNoOfUnit_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOfUnit.Text != "")
            {
                Int64 unitPrice;
                Int64 noOfUnit;

                if (Int64.TryParse(txtPricePerUnit.Text, out unitPrice) && Int64.TryParse(txtNoOfUnit.Text, out noOfUnit))
                {
                    Int64 totalAmount = unitPrice * noOfUnit;
                    txtTotalPrice.Text = totalAmount.ToString();
                }
                else
                {
                    txtTotalPrice.Clear();
                }
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "")
            {
                query = "SELECT quantity FROM medic WHERE mid = '" + txtMedicineId.Text + "'";
                ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = Int64.Parse(txtNoOfUnit.Text);

                    if (newQuantity <= quantity)
                    {
                        n = guna2DataGridView1.Rows.Add();
                        guna2DataGridView1.Rows[n].Cells[0].Value = txtMedicineId.Text;
                        guna2DataGridView1.Rows[n].Cells[1].Value = txtMedicineName.Text;
                        guna2DataGridView1.Rows[n].Cells[2].Value = txtExprideDate.Text;
                        guna2DataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                        guna2DataGridView1.Rows[n].Cells[4].Value = txtNoOfUnit.Text;
                        guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;
                        totalAmount += int.Parse(txtTotalPrice.Text);
                        lblTotal.Text = "Rs." + totalAmount.ToString();

                        query = "UPDATE medic SET quantity = " + (quantity - newQuantity) + " WHERE mid = '" + txtMedicineId.Text + "'";
                        fn.SetData(query, "Thuốc đã được thêm vào giỏ hàng");
                    }
                    else
                    {
                        MessageBox.Show("Thuốc hết hàng.\nChỉ còn " + quantity + " đơn vị", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    clearAll();
                    UC_SellMedicine_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("Chọn thuốc trước tiên", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtExprideDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnit.Clear();
            txtTotalPrice.Clear();
        }

        int valueAmount;
        String valueId;
        protected Int64 noOfUnit;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                noOfUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi chọn hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    query = "SELECT quantity FROM medic WHERE mid = '" + valueId + "'";
                    ds = fn.GetData(query);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                        newQuantity = quantity + noOfUnit;

                        query = "UPDATE medic SET quantity = " + newQuantity + " WHERE mid = '" + valueId + "'";
                        fn.SetData(query, "Thuốc đã loại bỏ khỏi giỏ hàng");

                        totalAmount -= valueAmount;
                        lblTotal.Text = "Rs." + totalAmount.ToString();

                        // Loại bỏ hàng khỏi DataGridView
                        guna2DataGridView1.Rows.RemoveAt(guna2DataGridView1.CurrentCell.RowIndex);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khi loại bỏ thuốc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UC_SellMedicine_Load(this, null);
            }
        }


        private void btnPurchase_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Hoá Đơn Thuốc";
            print.SubTitle = String.Format("Ngày: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Center;
            print.Footer = "Tổng số tiền phải trả: " + lblTotal.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            lblTotal.Text = "Rs.00";
            guna2DataGridView1.Rows.Clear();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_SellMedicine_Load(this, null);
        }
    }
}
