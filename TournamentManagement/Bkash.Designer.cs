namespace TournamentManagement
{
    partial class Bkash
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
            this.UserNoBox = new System.Windows.Forms.TextBox();
            this.Userno = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.ammount = new System.Windows.Forms.Label();
            this.ammountText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nogodMobileNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNoBox
            // 
            this.UserNoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNoBox.Location = new System.Drawing.Point(188, 117);
            this.UserNoBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNoBox.Name = "UserNoBox";
            this.UserNoBox.Size = new System.Drawing.Size(188, 20);
            this.UserNoBox.TabIndex = 28;
            this.UserNoBox.TextChanged += new System.EventHandler(this.UserNoBox_TextChanged);
            // 
            // Userno
            // 
            this.Userno.AutoSize = true;
            this.Userno.Location = new System.Drawing.Point(67, 124);
            this.Userno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Userno.Name = "Userno";
            this.Userno.Size = new System.Drawing.Size(69, 13);
            this.Userno.TabIndex = 27;
            this.Userno.Text = "User Number";
            this.Userno.Click += new System.EventHandler(this.Userno_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Info;
            this.Back.Location = new System.Drawing.Point(29, 400);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(56, 27);
            this.Back.TabIndex = 26;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.Location = new System.Drawing.Point(188, 277);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(93, 24);
            this.Confirm.TabIndex = 25;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // ammount
            // 
            this.ammount.AutoSize = true;
            this.ammount.Location = new System.Drawing.Point(67, 217);
            this.ammount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ammount.Name = "ammount";
            this.ammount.Size = new System.Drawing.Size(43, 13);
            this.ammount.TabIndex = 24;
            this.ammount.Text = "Amount";
            this.ammount.Click += new System.EventHandler(this.ammount_Click);
            // 
            // ammountText
            // 
            this.ammountText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ammountText.Location = new System.Drawing.Point(188, 212);
            this.ammountText.Margin = new System.Windows.Forms.Padding(2);
            this.ammountText.Name = "ammountText";
            this.ammountText.Size = new System.Drawing.Size(188, 20);
            this.ammountText.TabIndex = 23;
            this.ammountText.TextChanged += new System.EventHandler(this.ammountText_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(188, 169);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nogodMobileNum
            // 
            this.nogodMobileNum.AutoSize = true;
            this.nogodMobileNum.Location = new System.Drawing.Point(67, 172);
            this.nogodMobileNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nogodMobileNum.Name = "nogodMobileNum";
            this.nogodMobileNum.Size = new System.Drawing.Size(113, 13);
            this.nogodMobileNum.TabIndex = 21;
            this.nogodMobileNum.Text = "Nogod Mobile Number";
            this.nogodMobileNum.Click += new System.EventHandler(this.nogodMobileNum_Click);
            // 
            // Bkash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.UserNoBox);
            this.Controls.Add(this.Userno);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.ammount);
            this.Controls.Add(this.ammountText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nogodMobileNum);
            this.Name = "Bkash";
            this.Text = "Bkash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNoBox;
        private System.Windows.Forms.Label Userno;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label ammount;
        private System.Windows.Forms.TextBox ammountText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nogodMobileNum;
    }
}