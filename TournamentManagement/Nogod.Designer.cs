namespace TournamentManagement
{
    partial class Nogod
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
            this.Back = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.ammount = new System.Windows.Forms.Label();
            this.ammountText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nogodMobileNum = new System.Windows.Forms.Label();
            this.Userno = new System.Windows.Forms.Label();
            this.UserNoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Info;
            this.Back.Location = new System.Drawing.Point(11, 412);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(56, 27);
            this.Back.TabIndex = 17;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.Location = new System.Drawing.Point(167, 281);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(93, 24);
            this.Confirm.TabIndex = 16;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // ammount
            // 
            this.ammount.AutoSize = true;
            this.ammount.Location = new System.Drawing.Point(46, 221);
            this.ammount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ammount.Name = "ammount";
            this.ammount.Size = new System.Drawing.Size(43, 13);
            this.ammount.TabIndex = 15;
            this.ammount.Text = "Amount";
            // 
            // ammountText
            // 
            this.ammountText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ammountText.Location = new System.Drawing.Point(167, 216);
            this.ammountText.Margin = new System.Windows.Forms.Padding(2);
            this.ammountText.Name = "ammountText";
            this.ammountText.Size = new System.Drawing.Size(188, 20);
            this.ammountText.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(167, 173);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 13;
            // 
            // nogodMobileNum
            // 
            this.nogodMobileNum.AutoSize = true;
            this.nogodMobileNum.Location = new System.Drawing.Point(46, 176);
            this.nogodMobileNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nogodMobileNum.Name = "nogodMobileNum";
            this.nogodMobileNum.Size = new System.Drawing.Size(113, 13);
            this.nogodMobileNum.TabIndex = 12;
            this.nogodMobileNum.Text = "Nogod Mobile Number";
            // 
            // Userno
            // 
            this.Userno.AutoSize = true;
            this.Userno.Location = new System.Drawing.Point(46, 128);
            this.Userno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Userno.Name = "Userno";
            this.Userno.Size = new System.Drawing.Size(69, 13);
            this.Userno.TabIndex = 18;
            this.Userno.Text = "User Number";
            // 
            // UserNoBox
            // 
            this.UserNoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNoBox.Location = new System.Drawing.Point(167, 121);
            this.UserNoBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNoBox.Name = "UserNoBox";
            this.UserNoBox.Size = new System.Drawing.Size(188, 20);
            this.UserNoBox.TabIndex = 20;
            this.UserNoBox.TextChanged += new System.EventHandler(this.UserNoBox_TextChanged_1);
            // 
            // Nogod
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
            this.Name = "Nogod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nogod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label ammount;
        private System.Windows.Forms.TextBox ammountText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nogodMobileNum;
        private System.Windows.Forms.Label Userno;
        private System.Windows.Forms.TextBox UserNoBox;
    }
}