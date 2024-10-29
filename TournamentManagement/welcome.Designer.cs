namespace TournamentManagement
{
    partial class welcome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LoginButtonsPanel = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Button();
            this.Managment = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.LOGOUT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LiveShow = new System.Windows.Forms.Button();
            this.AccountSettings = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FixedPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PointTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AdPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            this.LoginButtonsPanel.SuspendLayout();
            this.FixedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.AdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.LoginButtonsPanel);
            this.LeftPanel.Controls.Add(this.LOGOUT);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Controls.Add(this.LiveShow);
            this.LeftPanel.Controls.Add(this.AccountSettings);
            this.LeftPanel.Controls.Add(this.Login);
            this.LeftPanel.Controls.Add(this.panel1);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(172, 454);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginButtonsPanel_MouseDown);
            // 
            // LoginButtonsPanel
            // 
            this.LoginButtonsPanel.BackColor = System.Drawing.Color.Black;
            this.LoginButtonsPanel.Controls.Add(this.User);
            this.LoginButtonsPanel.Controls.Add(this.Managment);
            this.LoginButtonsPanel.Controls.Add(this.Admin);
            this.LoginButtonsPanel.Location = new System.Drawing.Point(3, 195);
            this.LoginButtonsPanel.Name = "LoginButtonsPanel";
            this.LoginButtonsPanel.Size = new System.Drawing.Size(255, 201);
            this.LoginButtonsPanel.TabIndex = 5;
            this.LoginButtonsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginButtonsPanel_Paint);
            this.LoginButtonsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginButtonsPanel_MouseDown);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Gray;
            this.User.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.User.Location = new System.Drawing.Point(11, 17);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(139, 38);
            this.User.TabIndex = 0;
            this.User.Text = "USER";
            this.User.UseVisualStyleBackColor = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Managment
            // 
            this.Managment.BackColor = System.Drawing.Color.Gray;
            this.Managment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Managment.Location = new System.Drawing.Point(12, 119);
            this.Managment.Name = "Managment";
            this.Managment.Size = new System.Drawing.Size(139, 38);
            this.Managment.TabIndex = 2;
            this.Managment.Text = "Team Managment ";
            this.Managment.UseVisualStyleBackColor = false;
            this.Managment.Click += new System.EventHandler(this.Managment_Click);
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Gray;
            this.Admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Admin.Location = new System.Drawing.Point(11, 68);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(139, 38);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // LOGOUT
            // 
            this.LOGOUT.BackColor = System.Drawing.Color.Black;
            this.LOGOUT.ForeColor = System.Drawing.Color.Red;
            this.LOGOUT.Location = new System.Drawing.Point(3, 134);
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(169, 35);
            this.LOGOUT.TabIndex = 4;
            this.LOGOUT.Text = "LOGOUT";
            this.LOGOUT.UseVisualStyleBackColor = false;
            this.LOGOUT.Click += new System.EventHandler(this.LOGOUT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "© 2024 YOUKNOWBETTER \r\nPrivacy Policy\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LiveShow
            // 
            this.LiveShow.BackColor = System.Drawing.Color.Black;
            this.LiveShow.Location = new System.Drawing.Point(0, 82);
            this.LiveShow.Name = "LiveShow";
            this.LiveShow.Size = new System.Drawing.Size(172, 46);
            this.LiveShow.TabIndex = 2;
            this.LiveShow.Text = "Live";
            this.LiveShow.UseVisualStyleBackColor = false;
            this.LiveShow.Click += new System.EventHandler(this.LiveShow_Click);
            // 
            // AccountSettings
            // 
            this.AccountSettings.BackColor = System.Drawing.Color.Black;
            this.AccountSettings.Location = new System.Drawing.Point(0, 39);
            this.AccountSettings.Name = "AccountSettings";
            this.AccountSettings.Size = new System.Drawing.Size(172, 46);
            this.AccountSettings.TabIndex = 1;
            this.AccountSettings.Text = "Account";
            this.AccountSettings.UseVisualStyleBackColor = false;
            this.AccountSettings.Click += new System.EventHandler(this.AccountSettings_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Black;
            this.Login.ForeColor = System.Drawing.Color.IndianRed;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(172, 45);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(172, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FixedPanel
            // 
            this.FixedPanel.BackColor = System.Drawing.Color.Tomato;
            this.FixedPanel.Controls.Add(this.pictureBox2);
            this.FixedPanel.Location = new System.Drawing.Point(712, 195);
            this.FixedPanel.Name = "FixedPanel";
            this.FixedPanel.Size = new System.Drawing.Size(522, 259);
            this.FixedPanel.TabIndex = 3;
            this.FixedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FixedPanel_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(524, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PointTable
            // 
            this.PointTable.AllowUserToAddRows = false;
            this.PointTable.AllowUserToDeleteRows = false;
            this.PointTable.AllowUserToResizeColumns = false;
            this.PointTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.PointTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PointTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PointTable.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.PointTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PointTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PointTable.ColumnHeadersHeight = 29;
            this.PointTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PointTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.PointTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointTable.Location = new System.Drawing.Point(0, 0);
            this.PointTable.MaximumSize = new System.Drawing.Size(540, 257);
            this.PointTable.MinimumSize = new System.Drawing.Size(540, 257);
            this.PointTable.Name = "PointTable";
            this.PointTable.ReadOnly = true;
            this.PointTable.RowHeadersVisible = false;
            this.PointTable.RowHeadersWidth = 40;
            this.PointTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PointTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PointTable.Size = new System.Drawing.Size(540, 257);
            this.PointTable.TabIndex = 10;
            this.PointTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PointTable_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.PointTable);
            this.panel2.Location = new System.Drawing.Point(172, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 257);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "PIC4.jpg");
            this.imageList1.Images.SetKeyName(1, "PIC2.jpg");
            this.imageList1.Images.SetKeyName(2, "PIC1.jpg");
            this.imageList1.Images.SetKeyName(3, "PI3.jpg");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdPanel
            // 
            this.AdPanel.BackColor = System.Drawing.Color.SandyBrown;
            this.AdPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdPanel.Controls.Add(this.pictureBox1);
            this.AdPanel.Location = new System.Drawing.Point(172, 1);
            this.AdPanel.Name = "AdPanel";
            this.AdPanel.Size = new System.Drawing.Size(1062, 194);
            this.AdPanel.TabIndex = 1;
            this.AdPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1061, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1233, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FixedPanel);
            this.Controls.Add(this.AdPanel);
            this.Controls.Add(this.LeftPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.LoginButtonsPanel.ResumeLayout(false);
            this.FixedPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.AdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel FixedPanel;
        private System.Windows.Forms.DataGridView PointTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel AdPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LiveShow;
        private System.Windows.Forms.Button AccountSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LOGOUT;
        private System.Windows.Forms.Button Managment;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Panel LoginButtonsPanel;
    }
}