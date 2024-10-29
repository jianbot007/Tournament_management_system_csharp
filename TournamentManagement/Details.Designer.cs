namespace TournamentManagement
{
    partial class Details
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
            this.TeamAPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PointTabledataGridView = new System.Windows.Forms.DataGridView();
            this.CoachdataGridView = new System.Windows.Forms.DataGridView();
            this.PlayerdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Panel();
            this.AdminBackButton = new System.Windows.Forms.Button();
            this.TeamAPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointTabledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerdataGridView)).BeginInit();
            this.Admin.SuspendLayout();
            this.User.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamAPanel
            // 
            this.TeamAPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamAPanel.Controls.Add(this.label4);
            this.TeamAPanel.Controls.Add(this.label3);
            this.TeamAPanel.Controls.Add(this.label2);
            this.TeamAPanel.Controls.Add(this.label1);
            this.TeamAPanel.Controls.Add(this.PointTabledataGridView);
            this.TeamAPanel.Controls.Add(this.CoachdataGridView);
            this.TeamAPanel.Controls.Add(this.PlayerdataGridView);
            this.TeamAPanel.Location = new System.Drawing.Point(7, 88);
            this.TeamAPanel.Name = "TeamAPanel";
            this.TeamAPanel.Size = new System.Drawing.Size(1106, 500);
            this.TeamAPanel.TabIndex = 0;
            this.TeamAPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TeamAPanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(120, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player Details ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 8.25F);
            this.label2.Location = new System.Drawing.Point(464, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Staffs Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 8.25F);
            this.label1.Location = new System.Drawing.Point(865, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Point Table";
            // 
            // PointTabledataGridView
            // 
            this.PointTabledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointTabledataGridView.Location = new System.Drawing.Point(740, 32);
            this.PointTabledataGridView.Name = "PointTabledataGridView";
            this.PointTabledataGridView.ReadOnly = true;
            this.PointTabledataGridView.Size = new System.Drawing.Size(356, 455);
            this.PointTabledataGridView.TabIndex = 2;
            // 
            // CoachdataGridView
            // 
            this.CoachdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoachdataGridView.Location = new System.Drawing.Point(374, 32);
            this.CoachdataGridView.Name = "CoachdataGridView";
            this.CoachdataGridView.ReadOnly = true;
            this.CoachdataGridView.Size = new System.Drawing.Size(350, 455);
            this.CoachdataGridView.TabIndex = 1;
            this.CoachdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoachdataGridView_CellContentClick);
            // 
            // PlayerdataGridView
            // 
            this.PlayerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerdataGridView.Location = new System.Drawing.Point(11, 32);
            this.PlayerdataGridView.Name = "PlayerdataGridView";
            this.PlayerdataGridView.ReadOnly = true;
            this.PlayerdataGridView.Size = new System.Drawing.Size(357, 455);
            this.PlayerdataGridView.TabIndex = 0;
            this.PlayerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerdataGridView_CellContentClick);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Location = new System.Drawing.Point(308, 28);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(413, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(459, 54);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(91, 28);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(15, 8);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(98, 31);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Welcome
            // 
            this.Welcome.Location = new System.Drawing.Point(128, 7);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(98, 31);
            this.Welcome.TabIndex = 4;
            this.Welcome.Text = "Welcome";
            this.Welcome.UseVisualStyleBackColor = true;
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Admin.Controls.Add(this.AdminBackButton);
            this.Admin.Location = new System.Drawing.Point(7, 12);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(122, 48);
            this.Admin.TabIndex = 5;
            this.Admin.Paint += new System.Windows.Forms.PaintEventHandler(this.Admin_Paint);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Controls.Add(this.Welcome);
            this.User.Controls.Add(this.Back);
            this.User.Location = new System.Drawing.Point(7, 594);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(265, 48);
            this.User.TabIndex = 6;
            // 
            // AdminBackButton
            // 
            this.AdminBackButton.Location = new System.Drawing.Point(15, 9);
            this.AdminBackButton.Name = "AdminBackButton";
            this.AdminBackButton.Size = new System.Drawing.Size(98, 31);
            this.AdminBackButton.TabIndex = 7;
            this.AdminBackButton.Text = "Back";
            this.AdminBackButton.UseVisualStyleBackColor = true;
            this.AdminBackButton.Click += new System.EventHandler(this.AdminBackButton_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 663);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.TeamAPanel);
            this.Name = "Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.TeamAPanel.ResumeLayout(false);
            this.TeamAPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointTabledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerdataGridView)).EndInit();
            this.Admin.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TeamAPanel;
        private System.Windows.Forms.DataGridView PointTabledataGridView;
        private System.Windows.Forms.DataGridView CoachdataGridView;
        private System.Windows.Forms.DataGridView PlayerdataGridView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Welcome;
        private System.Windows.Forms.Panel Admin;
        private System.Windows.Forms.Panel User;
        private System.Windows.Forms.Button AdminBackButton;
    }
}