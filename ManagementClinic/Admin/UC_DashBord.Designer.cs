namespace ManagementClinic.Admin
{
    partial class UC_DashBord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DashBord));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            lbnAdmin = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label5 = new Label();
            lbnDoctor = new Label();
            lbnUser = new Label();
            btnSyn = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 39);
            label1.Name = "label1";
            label1.Size = new Size(195, 40);
            label1.TabIndex = 0;
            label1.Text = "DashBoard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 57);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = " Admin ";
            label2.Click += label2_Click;
            // 
            // lbnAdmin
            // 
            lbnAdmin.AutoSize = true;
            lbnAdmin.Location = new Point(21, 158);
            lbnAdmin.Name = "lbnAdmin";
            lbnAdmin.Size = new Size(50, 20);
            lbnAdmin.TabIndex = 0;
            lbnAdmin.Text = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSalmon;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbnAdmin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lbnDoctor);
            panel2.Controls.Add(lbnUser);
            panel2.Location = new Point(960, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 227);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 57);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Patient";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 57);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Doctor ";
            // 
            // lbnDoctor
            // 
            lbnDoctor.AutoSize = true;
            lbnDoctor.Location = new Point(348, 158);
            lbnDoctor.Name = "lbnDoctor";
            lbnDoctor.Size = new Size(50, 20);
            lbnDoctor.TabIndex = 3;
            lbnDoctor.Text = "label4";
            // 
            // lbnUser
            // 
            lbnUser.AutoSize = true;
            lbnUser.Location = new Point(200, 158);
            lbnUser.Name = "lbnUser";
            lbnUser.Size = new Size(50, 20);
            lbnUser.TabIndex = 1;
            lbnUser.Text = "label3";
            // 
            // btnSyn
            // 
            btnSyn.BackColor = SystemColors.ControlLight;
            btnSyn.CustomizableEdges = customizableEdges1;
            btnSyn.DisabledState.BorderColor = Color.DarkGray;
            btnSyn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSyn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSyn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSyn.FillColor = Color.Snow;
            btnSyn.Font = new Font("Segoe UI", 9F);
            btnSyn.ForeColor = Color.White;
            btnSyn.Image = (Image)resources.GetObject("btnSyn.Image");
            btnSyn.ImageSize = new Size(60, 60);
            btnSyn.Location = new Point(304, 25);
            btnSyn.Name = "btnSyn";
            btnSyn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSyn.Size = new Size(86, 80);
            btnSyn.TabIndex = 3;
            btnSyn.Click += btnSyn_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(60, 252);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(864, 652);
            guna2PictureBox1.TabIndex = 4;
            guna2PictureBox1.TabStop = false;
            // 
            // UC_DashBord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2PictureBox1);
            Controls.Add(btnSyn);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "UC_DashBord";
            Size = new Size(1666, 1172);
            Load += UC_DashBord_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbnAdmin;
        private Panel panel2;
        private Label lbnUser;
        private Guna.UI2.WinForms.Guna2Button btnSyn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label2;
        private Label label5;
        private Label lbnDoctor;
        private Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
