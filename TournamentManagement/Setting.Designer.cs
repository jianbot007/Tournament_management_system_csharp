namespace TournamentManagement
{
    partial class Setting
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
            this.InformationDataGridView = new System.Windows.Forms.DataGridView();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DelectButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InformationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InformationDataGridView
            // 
            this.InformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InformationDataGridView.Location = new System.Drawing.Point(74, 46);
            this.InformationDataGridView.Name = "InformationDataGridView";
            this.InformationDataGridView.Size = new System.Drawing.Size(537, 56);
            this.InformationDataGridView.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(148, 156);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(204, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MobileTextBox.Location = new System.Drawing.Point(148, 203);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(204, 20);
            this.MobileTextBox.TabIndex = 2;
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWordTextBox.Location = new System.Drawing.Point(148, 249);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.Size = new System.Drawing.Size(204, 20);
            this.PassWordTextBox.TabIndex = 3;
            this.PassWordTextBox.Text = "Password";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(148, 295);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(204, 20);
            this.ConfirmPasswordTextBox.TabIndex = 4;
            this.ConfirmPasswordTextBox.Text = "Confrim Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mobile No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(144, 358);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(118, 42);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DelectButton
            // 
            this.DelectButton.Location = new System.Drawing.Point(289, 358);
            this.DelectButton.Name = "DelectButton";
            this.DelectButton.Size = new System.Drawing.Size(118, 42);
            this.DelectButton.TabIndex = 10;
            this.DelectButton.Text = "Delect";
            this.DelectButton.UseVisualStyleBackColor = true;
            this.DelectButton.Click += new System.EventHandler(this.DelectButton_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(2, 396);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 42);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DelectButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.InformationDataGridView);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InformationDataGridView;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DelectButton;
        private System.Windows.Forms.Button Back;
    }
}