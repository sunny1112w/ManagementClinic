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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            uC_DashBoarch1.Visible = false;
            uC_AddMedicine1.Visible = false;
            uC_ViewMedicine1.Visible = false;
            uC_UpdateMedicine1.Visible = false;
            uC_ViewCheckValidate1.Visible = false;
            uC_SellMedicine1.Visible=false;
            btnDashBoarch.PerformClick();
        }

        private void btnDashBoarch_Click(object sender, EventArgs e)
        {
            uC_DashBoarch1.Visible = true;
            uC_DashBoarch1.BringToFront();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_AddMedicine1.Visible = true;
            uC_AddMedicine1.BringToFront();
        }

        private void uC_AddMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void uC_ViewMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_ViewMedicine1.Visible = true;
            uC_ViewMedicine1.BringToFront();
        }

        private void btnUpdateMedicine_Click(object sender, EventArgs e)
        {
            uC_UpdateMedicine1.Visible = true;
            uC_UpdateMedicine1.BringToFront();
        }

        private void uC_UpdateMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void btnMedicineValidiry_Click(object sender, EventArgs e)
        {
            uC_ViewCheckValidate1.Visible = true;
            uC_ViewCheckValidate1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uC_SellMedicine1.Visible = true;
            uC_SellMedicine1.BringToFront();
        }
    }
}
