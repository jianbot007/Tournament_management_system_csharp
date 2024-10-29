namespace TournamentManagement
{
    partial class TeamManagmentLogin
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TeamManagmentName = new System.Windows.Forms.Label();
            this.TeamManagmentPassWordBox = new System.Windows.Forms.TextBox();
            this.TeamManagmentPassoword = new System.Windows.Forms.Label();
            this.TeamManagmentLogicButton = new System.Windows.Forms.Button();
            this.TeamManagmentNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "LOG IN";
            // 
            // TeamManagmentName
            // 
            this.TeamManagmentName.AutoSize = true;
            this.TeamManagmentName.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamManagmentName.Location = new System.Drawing.Point(68, 191);
            this.TeamManagmentName.Name = "TeamManagmentName";
            this.TeamManagmentName.Size = new System.Drawing.Size(40, 15);
            this.TeamManagmentName.TabIndex = 24;
            this.TeamManagmentName.Text = "Name";
            // 
            // TeamManagmentPassWordBox
            // 
            this.TeamManagmentPassWordBox.BackColor = System.Drawing.SystemColors.Info;
            this.TeamManagmentPassWordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamManagmentPassWordBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TeamManagmentPassWordBox.Location = new System.Drawing.Point(138, 233);
            this.TeamManagmentPassWordBox.Name = "TeamManagmentPassWordBox";
            this.TeamManagmentPassWordBox.Size = new System.Drawing.Size(203, 20);
            this.TeamManagmentPassWordBox.TabIndex = 22;
            this.TeamManagmentPassWordBox.TextChanged += new System.EventHandler(this.TeamManagmentPassWordBox_TextChanged);
            // 
            // TeamManagmentPassoword
            // 
            this.TeamManagmentPassoword.AutoSize = true;
            this.TeamManagmentPassoword.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamManagmentPassoword.Location = new System.Drawing.Point(68, 240);
            this.TeamManagmentPassoword.Name = "TeamManagmentPassoword";
            this.TeamManagmentPassoword.Size = new System.Drawing.Size(61, 15);
            this.TeamManagmentPassoword.TabIndex = 25;
            this.TeamManagmentPassoword.Text = "Password";
            // 
            // TeamManagmentLogicButton
            // 
            this.TeamManagmentLogicButton.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamManagmentLogicButton.Location = new System.Drawing.Point(174, 296);
            this.TeamManagmentLogicButton.Name = "TeamManagmentLogicButton";
            this.TeamManagmentLogicButton.Size = new System.Drawing.Size(145, 37);
            this.TeamManagmentLogicButton.TabIndex = 23;
            this.TeamManagmentLogicButton.Text = "Login";
            this.TeamManagmentLogicButton.UseVisualStyleBackColor = true;
            this.TeamManagmentLogicButton.Click += new System.EventHandler(this.TeamManagmentLogicButton_Click);
            // 
            // TeamManagmentNameBox
            // 
            this.TeamManagmentNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamManagmentNameBox.Location = new System.Drawing.Point(138, 184);
            this.TeamManagmentNameBox.Name = "TeamManagmentNameBox";
            this.TeamManagmentNameBox.Size = new System.Drawing.Size(203, 20);
            this.TeamManagmentNameBox.TabIndex = 21;
            // 
            // TeamManagmentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamManagmentName);
            this.Controls.Add(this.TeamManagmentPassWordBox);
            this.Controls.Add(this.TeamManagmentPassoword);
            this.Controls.Add(this.TeamManagmentLogicButton);
            this.Controls.Add(this.TeamManagmentNameBox);
            this.Name = "TeamManagmentLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamManagmentLogin";
            this.Load += new System.EventHandler(this.TeamManagmentLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TeamManagmentName;
        private System.Windows.Forms.TextBox TeamManagmentPassWordBox;
        private System.Windows.Forms.Label TeamManagmentPassoword;
        private System.Windows.Forms.Button TeamManagmentLogicButton;
        private System.Windows.Forms.TextBox TeamManagmentNameBox;
    }
}