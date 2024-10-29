namespace TournamentManagement
{
    partial class BuyTicket
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
            this.Cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mobilenoBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cancel.Location = new System.Drawing.Point(386, 268);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(56, 36);
            this.Cancel.TabIndex = 29;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 356);
            this.panel1.TabIndex = 21;
            // 
            // mobilenoBox
            // 
            this.mobilenoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobilenoBox.Location = new System.Drawing.Point(350, 178);
            this.mobilenoBox.Margin = new System.Windows.Forms.Padding(2);
            this.mobilenoBox.Name = "mobilenoBox";
            this.mobilenoBox.Size = new System.Drawing.Size(194, 20);
            this.mobilenoBox.TabIndex = 20;
            this.mobilenoBox.TextChanged += new System.EventHandler(this.mobilenoBox_TextChanged);
            // 
            // usernameBox
            // 
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Location = new System.Drawing.Point(350, 147);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(194, 20);
            this.usernameBox.TabIndex = 19;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mobile Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            // 
            // Payment
            // 
            this.Payment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Payment.Location = new System.Drawing.Point(456, 268);
            this.Payment.Margin = new System.Windows.Forms.Padding(2);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(56, 36);
            this.Payment.TabIndex = 15;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = false;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // Quantity
            // 
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity.Location = new System.Drawing.Point(350, 220);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(194, 20);
            this.Quantity.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ticket Price 120 TK";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Gainsboro;
            this.Back.Location = new System.Drawing.Point(22, 403);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(56, 36);
            this.Back.TabIndex = 33;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mobilenoBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Payment);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox mobilenoBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Back;
    }
}