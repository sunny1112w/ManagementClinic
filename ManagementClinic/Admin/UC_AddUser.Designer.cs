namespace ManagementClinic.Admin
{
    partial class UC_AddUser
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddUser));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtRole = new Guna.UI2.WinForms.Guna2ComboBox();
            txtName = new TextBox();
            txtDob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            btnReload = new Guna.UI2.WinForms.Guna2Button();
            pictrAddUser = new PictureBox();
            label9 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label10 = new Label();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            lbnAddress = new Label();
            txtAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictrAddUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 21);
            label1.Name = "label1";
            label1.Size = new Size(180, 44);
            label1.TabIndex = 0;
            label1.Text = "Add User";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(174, 170);
            label2.Name = "label2";
            label2.Size = new Size(162, 19);
            label2.TabIndex = 1;
            label2.Text = "Vai trò người dùng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(174, 605);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 478);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(174, 276);
            label5.Name = "label5";
            label5.Size = new Size(37, 19);
            label5.TabIndex = 4;
            label5.Text = "Tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(842, 399);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 5;
            label6.Text = "UserName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(842, 170);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(842, 521);
            label8.Name = "label8";
            label8.Size = new Size(86, 19);
            label8.TabIndex = 7;
            label8.Text = "Mật khẩu ";
            // 
            // txtRole
            // 
            txtRole.AutoCompleteCustomSource.AddRange(new string[] { "Admin ", "Customer", "Doctor" });
            txtRole.BackColor = Color.Transparent;
            txtRole.CustomizableEdges = customizableEdges9;
            txtRole.DrawMode = DrawMode.OwnerDrawFixed;
            txtRole.DropDownStyle = ComboBoxStyle.DropDownList;
            txtRole.FocusedColor = Color.FromArgb(94, 148, 255);
            txtRole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRole.Font = new Font("Segoe UI", 10F);
            txtRole.ForeColor = Color.FromArgb(68, 88, 112);
            txtRole.ItemHeight = 30;
            txtRole.Items.AddRange(new object[] { "Admin ", "Customer", "Doctor" });
            txtRole.Location = new Point(174, 216);
            txtRole.Name = "txtRole";
            txtRole.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtRole.Size = new Size(400, 36);
            txtRole.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 321);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(400, 49);
            txtName.TabIndex = 9;
            // 
            // txtDob
            // 
            txtDob.Checked = true;
            txtDob.CustomizableEdges = customizableEdges11;
            txtDob.Font = new Font("Segoe UI", 9F);
            txtDob.Format = DateTimePickerFormat.Long;
            txtDob.Location = new Point(174, 660);
            txtDob.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            txtDob.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            txtDob.Name = "txtDob";
            txtDob.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtDob.Size = new Size(400, 45);
            txtDob.TabIndex = 14;
            txtDob.Value = new DateTime(2024, 7, 8, 18, 47, 9, 810);
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(842, 575);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 49);
            txtPassword.TabIndex = 15;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(842, 448);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(400, 49);
            txtUserName.TabIndex = 16;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(842, 203);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 49);
            txtEmail.TabIndex = 17;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(174, 518);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(400, 49);
            txtPhone.TabIndex = 18;
            // 
            // btnSignUp
            // 
            btnSignUp.BorderRadius = 19;
            btnSignUp.BorderThickness = 1;
            btnSignUp.CustomizableEdges = customizableEdges13;
            btnSignUp.DisabledState.BorderColor = Color.DarkGray;
            btnSignUp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignUp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignUp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignUp.FillColor = Color.FromArgb(0, 118, 255);
            btnSignUp.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Image = (Image)resources.GetObject("btnSignUp.Image");
            btnSignUp.ImageSize = new Size(40, 40);
            btnSignUp.Location = new Point(842, 660);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSignUp.Size = new Size(187, 56);
            btnSignUp.TabIndex = 19;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.Click += btnSignUp_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Location = new Point(693, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(11, 597);
            panel1.TabIndex = 21;
            // 
            // btnReload
            // 
            btnReload.BorderRadius = 19;
            btnReload.BorderThickness = 1;
            btnReload.CustomizableEdges = customizableEdges15;
            btnReload.DisabledState.BorderColor = Color.DarkGray;
            btnReload.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReload.FillColor = Color.FromArgb(0, 118, 255);
            btnReload.Font = new Font("Century", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReload.ForeColor = Color.White;
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.ImageSize = new Size(40, 40);
            btnReload.Location = new Point(1055, 660);
            btnReload.Name = "btnReload";
            btnReload.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnReload.Size = new Size(187, 56);
            btnReload.TabIndex = 22;
            btnReload.Text = "Tải Lại";
            btnReload.Click += btnReload_Click;
            // 
            // pictrAddUser
            // 
            pictrAddUser.Location = new Point(1273, 448);
            pictrAddUser.Name = "pictrAddUser";
            pictrAddUser.Size = new Size(66, 49);
            pictrAddUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictrAddUser.TabIndex = 23;
            pictrAddUser.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(936, 777);
            label9.Name = "label9";
            label9.Size = new Size(206, 20);
            label9.TabIndex = 24;
            label9.Text = " *Kiểm tra vai trò người dùng ";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(174, 399);
            label10.Name = "label10";
            label10.Size = new Size(79, 19);
            label10.TabIndex = 25;
            label10.Text = "Giới tính ";
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(176, 434);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(66, 24);
            rdMale.TabIndex = 26;
            rdMale.TabStop = true;
            rdMale.Text = "Nam ";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(331, 434);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(50, 24);
            rdFemale.TabIndex = 27;
            rdFemale.TabStop = true;
            rdFemale.Text = "Nữ";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // lbnAddress
            // 
            lbnAddress.AutoSize = true;
            lbnAddress.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnAddress.Location = new Point(842, 276);
            lbnAddress.Name = "lbnAddress";
            lbnAddress.Size = new Size(72, 19);
            lbnAddress.TabIndex = 28;
            lbnAddress.Text = "Địa chỉ ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(842, 321);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(400, 49);
            txtAddress.TabIndex = 29;
            // 
            // UC_AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(txtAddress);
            Controls.Add(lbnAddress);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictrAddUser);
            Controls.Add(btnReload);
            Controls.Add(panel1);
            Controls.Add(btnSignUp);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtDob);
            Controls.Add(txtName);
            Controls.Add(txtRole);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddUser";
            Size = new Size(1813, 1167);
            Load += UC_AddUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictrAddUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox txtRole;
        private TextBox txtName;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDob;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private PictureBox pictureBox1;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PictureBox pictrAddUser;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label label10;
        private TextBox txtAddress;
        private Label lbnAddress;
    }
}
