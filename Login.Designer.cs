namespace Ass02
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LgBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(13, 84);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 17);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "User Name";
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(99, 79);
            this.TextUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(383, 22);
            this.TextUser.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            // 
            // LgBtn
            // 
            this.LgBtn.Location = new System.Drawing.Point(99, 233);
            this.LgBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LgBtn.Name = "LgBtn";
            this.LgBtn.Size = new System.Drawing.Size(128, 52);
            this.LgBtn.TabIndex = 6;
            this.LgBtn.Text = "Login";
            this.LgBtn.UseVisualStyleBackColor = true;
            this.LgBtn.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(208, 315);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(157, 47);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.Location = new System.Drawing.Point(353, 231);
            this.BtnNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(129, 52);
            this.BtnNewUser.TabIndex = 8;
            this.BtnNewUser.Text = "New User";
            this.BtnNewUser.UseVisualStyleBackColor = true;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(99, 153);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(383, 22);
            this.TextPassword.TabIndex = 4;
            this.TextPassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 434);
            this.Controls.Add(this.BtnNewUser);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LgBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LgBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button BtnNewUser;
        private System.Windows.Forms.TextBox TextPassword;
    }
}

