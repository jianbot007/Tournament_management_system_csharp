namespace TournamentManagement
{
    partial class TeamE
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
            this.Staffs = new System.Windows.Forms.Button();
            this.Players = new System.Windows.Forms.Button();
            this.RemoveStaff = new System.Windows.Forms.Button();
            this.AddStaff = new System.Windows.Forms.Button();
            this.StaffPanel = new System.Windows.Forms.Panel();
            this.StaffdataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.RemovePlayer = new System.Windows.Forms.Button();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.PlayerdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.Welcomee = new System.Windows.Forms.Button();
            this.StaffPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffdataGridView)).BeginInit();
            this.PlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Staffs
            // 
            this.Staffs.Location = new System.Drawing.Point(622, 24);
            this.Staffs.Name = "Staffs";
            this.Staffs.Size = new System.Drawing.Size(104, 49);
            this.Staffs.TabIndex = 48;
            this.Staffs.Text = "Staffs";
            this.Staffs.UseVisualStyleBackColor = true;
            this.Staffs.Click += new System.EventHandler(this.Staffs_Click);
            // 
            // Players
            // 
            this.Players.Location = new System.Drawing.Point(484, 24);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(132, 49);
            this.Players.TabIndex = 47;
            this.Players.Text = "Players ";
            this.Players.UseVisualStyleBackColor = true;
            this.Players.Click += new System.EventHandler(this.Players_Click);
            // 
            // RemoveStaff
            // 
            this.RemoveStaff.Location = new System.Drawing.Point(150, 491);
            this.RemoveStaff.Name = "RemoveStaff";
            this.RemoveStaff.Size = new System.Drawing.Size(132, 49);
            this.RemoveStaff.TabIndex = 10;
            this.RemoveStaff.Text = "Remove";
            this.RemoveStaff.UseVisualStyleBackColor = true;
            this.RemoveStaff.Click += new System.EventHandler(this.RemoveStaff_Click);
            // 
            // AddStaff
            // 
            this.AddStaff.Location = new System.Drawing.Point(12, 491);
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.Size = new System.Drawing.Size(132, 49);
            this.AddStaff.TabIndex = 10;
            this.AddStaff.Text = "Add";
            this.AddStaff.UseVisualStyleBackColor = true;
            this.AddStaff.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // StaffPanel
            // 
            this.StaffPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.StaffPanel.Controls.Add(this.StaffdataGridView);
            this.StaffPanel.Controls.Add(this.label2);
            this.StaffPanel.Controls.Add(this.RemoveStaff);
            this.StaffPanel.Controls.Add(this.AddStaff);
            this.StaffPanel.Location = new System.Drawing.Point(469, 91);
            this.StaffPanel.Name = "StaffPanel";
            this.StaffPanel.Size = new System.Drawing.Size(454, 552);
            this.StaffPanel.TabIndex = 49;
            this.StaffPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StaffPanel_Paint);
            // 
            // StaffdataGridView
            // 
            this.StaffdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffdataGridView.Location = new System.Drawing.Point(3, 3);
            this.StaffdataGridView.Name = "StaffdataGridView";
            this.StaffdataGridView.Size = new System.Drawing.Size(448, 468);
            this.StaffdataGridView.TabIndex = 14;
            this.StaffdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffdataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "staff";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RemovePlayer
            // 
            this.RemovePlayer.Location = new System.Drawing.Point(150, 503);
            this.RemovePlayer.Name = "RemovePlayer";
            this.RemovePlayer.Size = new System.Drawing.Size(132, 35);
            this.RemovePlayer.TabIndex = 10;
            this.RemovePlayer.Text = "Remove";
            this.RemovePlayer.UseVisualStyleBackColor = true;
            this.RemovePlayer.Click += new System.EventHandler(this.RemovePlayer_Click);
            // 
            // AddPlayer
            // 
            this.AddPlayer.Location = new System.Drawing.Point(12, 503);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(132, 36);
            this.AddPlayer.TabIndex = 10;
            this.AddPlayer.Text = "Add";
            this.AddPlayer.UseVisualStyleBackColor = true;
            this.AddPlayer.Click += new System.EventHandler(this.AddPlayer_Click);
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.PlayerPanel.Controls.Add(this.PlayerdataGridView);
            this.PlayerPanel.Controls.Add(this.label1);
            this.PlayerPanel.Controls.Add(this.RemovePlayer);
            this.PlayerPanel.Controls.Add(this.AddPlayer);
            this.PlayerPanel.Location = new System.Drawing.Point(469, 92);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(454, 552);
            this.PlayerPanel.TabIndex = 50;
            this.PlayerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayerPanel_Paint);
            // 
            // PlayerdataGridView
            // 
            this.PlayerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerdataGridView.Location = new System.Drawing.Point(3, 3);
            this.PlayerdataGridView.Name = "PlayerdataGridView";
            this.PlayerdataGridView.Size = new System.Drawing.Size(448, 468);
            this.PlayerdataGridView.TabIndex = 12;
            this.PlayerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerdataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(128, 613);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(102, 31);
            this.Logout.TabIndex = 52;
            this.Logout.Text = "Logout ";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Welcomee
            // 
            this.Welcomee.Location = new System.Drawing.Point(20, 613);
            this.Welcomee.Name = "Welcomee";
            this.Welcomee.Size = new System.Drawing.Size(102, 31);
            this.Welcomee.TabIndex = 51;
            this.Welcomee.Text = "Welcome";
            this.Welcomee.UseVisualStyleBackColor = true;
            this.Welcomee.Click += new System.EventHandler(this.Welcomee_Click);
            // 
            // TeamE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 668);
            this.Controls.Add(this.Staffs);
            this.Controls.Add(this.Players);
            this.Controls.Add(this.StaffPanel);
            this.Controls.Add(this.PlayerPanel);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Welcomee);
            this.Name = "TeamE";
            this.Text = "TeamE";
            this.StaffPanel.ResumeLayout(false);
            this.StaffPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffdataGridView)).EndInit();
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Staffs;
        private System.Windows.Forms.Button Players;
        private System.Windows.Forms.Button RemoveStaff;
        private System.Windows.Forms.Button AddStaff;
        private System.Windows.Forms.Panel StaffPanel;
        private System.Windows.Forms.DataGridView StaffdataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemovePlayer;
        private System.Windows.Forms.Button AddPlayer;
        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.DataGridView PlayerdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Welcomee;
    }
}