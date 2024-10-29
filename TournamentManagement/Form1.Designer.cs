namespace TournamentManagement
{
    partial class Form1
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PassWordBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Passoword = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(92, 136);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(239, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.Text = "a";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // PassWordBox
            // 
            this.PassWordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWordBox.Location = new System.Drawing.Point(92, 248);
            this.PassWordBox.Name = "PassWordBox";
            this.PassWordBox.Size = new System.Drawing.Size(239, 20);
            this.PassWordBox.TabIndex = 2;
            this.PassWordBox.Text = "a";
            this.PassWordBox.TextChanged += new System.EventHandler(this.PassWordBox_TextChanged);
            // 
            // NextButton
            // 
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextButton.Location = new System.Drawing.Point(137, 353);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(139, 30);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "DONE";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passoword
            // 
            this.Passoword.AutoSize = true;
            this.Passoword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passoword.Location = new System.Drawing.Point(89, 232);
            this.Passoword.Name = "Passoword";
            this.Passoword.Size = new System.Drawing.Size(61, 13);
            this.Passoword.TabIndex = 5;
            this.Passoword.Text = "Password";
            this.Passoword.Click += new System.EventHandler(this.Passoword_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(259, 409);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(33, 13);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirm Password";
            // 
            // ConfirmBox
            // 
            this.ConfirmBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmBox.Location = new System.Drawing.Point(92, 309);
            this.ConfirmBox.Name = "ConfirmBox";
            this.ConfirmBox.Size = new System.Drawing.Size(239, 20);
            this.ConfirmBox.TabIndex = 7;
            this.ConfirmBox.Text = "a";
            this.ConfirmBox.TextChanged += new System.EventHandler(this.ConfirmBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone No";
            // 
            // NumberBox
            // 
            this.NumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberBox.Location = new System.Drawing.Point(92, 194);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(239, 20);
            this.NumberBox.TabIndex = 9;
            this.NumberBox.Text = "a";
            this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(446, 545);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.Passoword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PassWordBox);
            this.Controls.Add(this.NameBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PassWordBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Passoword;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConfirmBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberBox;
    }
}

