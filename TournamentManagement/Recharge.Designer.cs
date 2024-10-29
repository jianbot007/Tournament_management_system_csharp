namespace TournamentManagement
{
    partial class Recharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recharge));
            this.Back = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.Upay = new System.Windows.Forms.Button();
            this.Nogod = new System.Windows.Forms.Button();
            this.Bkash = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Info;
            this.Back.Location = new System.Drawing.Point(28, 405);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 33);
            this.Back.TabIndex = 11;
            this.Back.Text = "BACK ";
            this.Back.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.SystemColors.Highlight;
            this.l.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.l.Location = new System.Drawing.Point(86, 203);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(204, 13);
            this.l.TabIndex = 10;
            this.l.Text = "SELECT YOUR MOBILE BANK SYSTEM";
            // 
            // Upay
            // 
            this.Upay.BackColor = System.Drawing.SystemColors.Highlight;
            this.Upay.ForeColor = System.Drawing.SystemColors.Window;
            this.Upay.Location = new System.Drawing.Point(568, 243);
            this.Upay.Name = "Upay";
            this.Upay.Size = new System.Drawing.Size(161, 130);
            this.Upay.TabIndex = 9;
            this.Upay.Text = "UPAY";
            this.Upay.UseVisualStyleBackColor = false;
            this.Upay.Click += new System.EventHandler(this.Upay_Click);
            // 
            // Nogod
            // 
            this.Nogod.BackColor = System.Drawing.SystemColors.Highlight;
            this.Nogod.ForeColor = System.Drawing.SystemColors.Window;
            this.Nogod.Location = new System.Drawing.Point(331, 243);
            this.Nogod.Name = "Nogod";
            this.Nogod.Size = new System.Drawing.Size(161, 130);
            this.Nogod.TabIndex = 8;
            this.Nogod.Text = "NOGOD";
            this.Nogod.UseVisualStyleBackColor = false;
            this.Nogod.Click += new System.EventHandler(this.Nogod_Click);
            // 
            // Bkash
            // 
            this.Bkash.BackColor = System.Drawing.SystemColors.Highlight;
            this.Bkash.ForeColor = System.Drawing.SystemColors.Window;
            this.Bkash.Location = new System.Drawing.Point(89, 243);
            this.Bkash.Name = "Bkash";
            this.Bkash.Size = new System.Drawing.Size(161, 130);
            this.Bkash.TabIndex = 7;
            this.Bkash.Text = "BKASH";
            this.Bkash.UseVisualStyleBackColor = false;
            this.Bkash.Click += new System.EventHandler(this.Bkash_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.l);
            this.Controls.Add(this.Upay);
            this.Controls.Add(this.Nogod);
            this.Controls.Add(this.Bkash);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Recharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recharge";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button Upay;
        private System.Windows.Forms.Button Nogod;
        private System.Windows.Forms.Button Bkash;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}