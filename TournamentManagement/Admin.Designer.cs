namespace TournamentManagement
{
    partial class Admin
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
            System.Windows.Forms.Button ManagerRegButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Logout = new System.Windows.Forms.Button();
            this.AboutUS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TeamInformationButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsersButton = new System.Windows.Forms.Button();
            ManagerRegButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.Info;
            this.Logout.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Logout.Location = new System.Drawing.Point(12, 389);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 34);
            this.Logout.TabIndex = 24;
            this.Logout.Text = "LOGOUT";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AboutUS
            // 
            this.AboutUS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutUS.Location = new System.Drawing.Point(470, 340);
            this.AboutUS.Name = "AboutUS";
            this.AboutUS.Size = new System.Drawing.Size(82, 83);
            this.AboutUS.TabIndex = 23;
            this.AboutUS.Text = "ABOUT US";
            this.AboutUS.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(383, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 83);
            this.button1.TabIndex = 22;
            this.button1.Text = "SETTINGS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TeamInformationButton
            // 
            this.TeamInformationButton.AccessibleName = "TeamsINFO";
            this.TeamInformationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamInformationButton.Location = new System.Drawing.Point(559, 239);
            this.TeamInformationButton.Name = "TeamInformationButton";
            this.TeamInformationButton.Size = new System.Drawing.Size(82, 83);
            this.TeamInformationButton.TabIndex = 20;
            this.TeamInformationButton.Text = "Teams Information";
            this.TeamInformationButton.UseVisualStyleBackColor = false;
            this.TeamInformationButton.Click += new System.EventHandler(this.TeamInformationButton_Click);
            // 
            // ManagerRegButton
            // 
            ManagerRegButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ManagerRegButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            ManagerRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ManagerRegButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            ManagerRegButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            ManagerRegButton.Location = new System.Drawing.Point(383, 240);
            ManagerRegButton.Name = "ManagerRegButton";
            ManagerRegButton.Size = new System.Drawing.Size(82, 83);
            ManagerRegButton.TabIndex = 18;
            ManagerRegButton.Text = "Managers";
            ManagerRegButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            ManagerRegButton.UseVisualStyleBackColor = false;
            ManagerRegButton.Click += new System.EventHandler(this.ManagerRegButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "APLImage";
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(635, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UsersButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.UsersButton.Location = new System.Drawing.Point(472, 240);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(82, 83);
            this.UsersButton.TabIndex = 26;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 435);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.AboutUS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TeamInformationButton);
            this.Controls.Add(ManagerRegButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button AboutUS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TeamInformationButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UsersButton;
    }
}