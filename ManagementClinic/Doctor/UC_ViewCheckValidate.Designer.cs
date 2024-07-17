namespace ManagementClinic.Doctor
{
    partial class UC_ViewCheckValidate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label7 = new Label();
            txtCheck = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            lblSet = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 50);
            label1.Name = "label1";
            label1.Size = new Size(441, 40);
            label1.TabIndex = 5;
            label1.Text = "Check Medicine Validate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(994, 144);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 21;
            label7.Text = "Check Medicine";
            // 
            // txtCheck
            // 
            txtCheck.BackColor = Color.Transparent;
            txtCheck.CustomizableEdges = customizableEdges1;
            txtCheck.DrawMode = DrawMode.OwnerDrawFixed;
            txtCheck.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCheck.FocusedColor = Color.FromArgb(94, 148, 255);
            txtCheck.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCheck.Font = new Font("Segoe UI", 10F);
            txtCheck.ForeColor = Color.FromArgb(68, 88, 112);
            txtCheck.ItemHeight = 30;
            txtCheck.Items.AddRange(new object[] { "Valid Medicine", "Expried Medicine", "View All Medicine" });
            txtCheck.Location = new Point(994, 178);
            txtCheck.Name = "txtCheck";
            txtCheck.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCheck.Size = new Size(270, 36);
            txtCheck.TabIndex = 23;
            txtCheck.SelectedIndexChanged += txtCheck_SelectedIndexChanged;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(45, 247);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(1369, 537);
            guna2DataGridView1.TabIndex = 24;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblSet
            // 
            lblSet.AutoSize = true;
            lblSet.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSet.Location = new Point(89, 193);
            lblSet.Name = "lblSet";
            lblSet.Size = new Size(47, 21);
            lblSet.TabIndex = 25;
            lblSet.Text = "SET";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_ViewCheckValidate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSet);
            Controls.Add(guna2DataGridView1);
            Controls.Add(txtCheck);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "UC_ViewCheckValidate";
            Size = new Size(1667, 1102);
            Load += UC_ViewCheckValidate_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox txtCheck;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Label lblSet;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
