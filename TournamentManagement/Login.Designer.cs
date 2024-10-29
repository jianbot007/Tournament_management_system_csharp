namespace TournamentManagement
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.PassWordBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.Passoword = new System.Windows.Forms.Label();
            this.LogicButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AboutUs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // PassWordBox
            // 
            this.PassWordBox.BackColor = System.Drawing.SystemColors.Info;
            this.PassWordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWordBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PassWordBox.Location = new System.Drawing.Point(122, 209);
            this.PassWordBox.Name = "PassWordBox";
            this.PassWordBox.Size = new System.Drawing.Size(203, 20);
            this.PassWordBox.TabIndex = 14;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Bauhaus 93", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationButton.Location = new System.Drawing.Point(284, 315);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(80, 23);
            this.RegistrationButton.TabIndex = 18;
            this.RegistrationButton.Text = "Registration ";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click_1);
            // 
            // Passoword
            // 
            this.Passoword.AutoSize = true;
            this.Passoword.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passoword.Location = new System.Drawing.Point(52, 216);
            this.Passoword.Name = "Passoword";
            this.Passoword.Size = new System.Drawing.Size(61, 15);
            this.Passoword.TabIndex = 17;
            this.Passoword.Text = "Password";
            // 
            // LogicButton
            // 
            this.LogicButton.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogicButton.Location = new System.Drawing.Point(158, 272);
            this.LogicButton.Name = "LogicButton";
            this.LogicButton.Size = new System.Drawing.Size(145, 37);
            this.LogicButton.TabIndex = 15;
            this.LogicButton.Text = "Login";
            this.LogicButton.UseVisualStyleBackColor = true;
            this.LogicButton.Click += new System.EventHandler(this.LogicButton_Click_1);
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(122, 160);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(203, 20);
            this.NameBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "LOG IN";
            // 
            // AboutUs
            // 
            this.AboutUs.Location = new System.Drawing.Point(12, 414);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(100, 29);
            this.AboutUs.TabIndex = 20;
            this.AboutUs.Text = "About Us";
            this.AboutUs.UseVisualStyleBackColor = true;
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.AboutUs);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassWordBox);
            this.Controls.Add(this.Passoword);
            this.Controls.Add(this.LogicButton);
            this.Controls.Add(this.NameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassWordBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label Passoword;
        private System.Windows.Forms.Button LogicButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AboutUs;
    }
}