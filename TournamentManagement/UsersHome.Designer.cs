namespace TournamentManagement
{
    partial class UsersHome
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
            System.Windows.Forms.Button BuyTicket;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersHome));
            this.Logout = new System.Windows.Forms.Button();
            this.AboutUS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TeamsINFO = new System.Windows.Forms.Button();
            this.Recharge = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Welcome = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            BuyTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyTicket
            // 
            BuyTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BuyTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            BuyTicket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            BuyTicket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            BuyTicket.Location = new System.Drawing.Point(478, 253);
            BuyTicket.Name = "BuyTicket";
            BuyTicket.Size = new System.Drawing.Size(82, 83);
            BuyTicket.TabIndex = 9;
            BuyTicket.Text = "BUY TICKET";
            BuyTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            BuyTicket.UseVisualStyleBackColor = false;
            BuyTicket.Click += new System.EventHandler(this.BuyTicket_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.Info;
            this.Logout.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Logout.Location = new System.Drawing.Point(93, 404);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 34);
            this.Logout.TabIndex = 15;
            this.Logout.Text = "LOGOUT";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AboutUS
            // 
            this.AboutUS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutUS.Location = new System.Drawing.Point(566, 355);
            this.AboutUS.Name = "AboutUS";
            this.AboutUS.Size = new System.Drawing.Size(82, 83);
            this.AboutUS.TabIndex = 14;
            this.AboutUS.Text = "ABOUT US";
            this.AboutUS.UseVisualStyleBackColor = false;
            this.AboutUS.Click += new System.EventHandler(this.AboutUS_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(478, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 83);
            this.button1.TabIndex = 13;
            this.button1.Text = "SETTINGS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeamsINFO
            // 
            this.TeamsINFO.AccessibleName = "TeamsINFO";
            this.TeamsINFO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamsINFO.Location = new System.Drawing.Point(654, 254);
            this.TeamsINFO.Name = "TeamsINFO";
            this.TeamsINFO.Size = new System.Drawing.Size(82, 83);
            this.TeamsINFO.TabIndex = 11;
            this.TeamsINFO.Text = "TEAMS INFO";
            this.TeamsINFO.UseVisualStyleBackColor = false;
            this.TeamsINFO.Click += new System.EventHandler(this.TeamsINFO_Click);
            // 
            // Recharge
            // 
            this.Recharge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Recharge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Recharge.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Recharge.Location = new System.Drawing.Point(566, 254);
            this.Recharge.Name = "Recharge";
            this.Recharge.Size = new System.Drawing.Size(82, 83);
            this.Recharge.TabIndex = 10;
            this.Recharge.Text = "RECHARGE";
            this.Recharge.UseVisualStyleBackColor = false;
            this.Recharge.Click += new System.EventHandler(this.Recharge_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "APLImage";
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(43, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 222);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.SystemColors.Info;
            this.Welcome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Welcome.Location = new System.Drawing.Point(12, 404);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(75, 34);
            this.Welcome.TabIndex = 16;
            this.Welcome.Text = "Welcome";
            this.Welcome.UseVisualStyleBackColor = false;
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.ForeColor = System.Drawing.Color.Red;
            this.BalanceLabel.Location = new System.Drawing.Point(90, 288);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(94, 13);
            this.BalanceLabel.TabIndex = 19;
            this.BalanceLabel.Text = "upcoming balance";
            this.BalanceLabel.Click += new System.EventHandler(this.BalanceLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.Red;
            this.NameLabel.Location = new System.Drawing.Point(90, 264);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(82, 13);
            this.NameLabel.TabIndex = 20;
            this.NameLabel.Text = "upcoming name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // UsersHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.AboutUS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TeamsINFO);
            this.Controls.Add(this.Recharge);
            this.Controls.Add(BuyTicket);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UsersHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersHome";
            this.Load += new System.EventHandler(this.UsersHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button AboutUS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TeamsINFO;
        private System.Windows.Forms.Button Recharge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Welcome;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}