namespace Ass02
{
    partial class NewUser
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
            this.TextUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextRePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextLastName = new System.Windows.Forms.TextBox();
            this.BirthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxUserType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(102, 30);
            this.TextUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(176, 20);
            this.TextUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(102, 69);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(176, 20);
            this.TextPassword.TabIndex = 2;
            this.TextPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re-Password";
            // 
            // TextRePassword
            // 
            this.TextRePassword.Location = new System.Drawing.Point(102, 112);
            this.TextRePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextRePassword.Name = "TextRePassword";
            this.TextRePassword.Size = new System.Drawing.Size(176, 20);
            this.TextRePassword.TabIndex = 4;
            this.TextRePassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "First name";
            // 
            // TextFirstName
            // 
            this.TextFirstName.Location = new System.Drawing.Point(102, 154);
            this.TextFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextFirstName.Name = "TextFirstName";
            this.TextFirstName.Size = new System.Drawing.Size(176, 20);
            this.TextFirstName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last name";
            // 
            // TextLastName
            // 
            this.TextLastName.Location = new System.Drawing.Point(102, 199);
            this.TextLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextLastName.Name = "TextLastName";
            this.TextLastName.Size = new System.Drawing.Size(176, 20);
            this.TextLastName.TabIndex = 8;
            // 
            // BirthdatePicker
            // 
            this.BirthdatePicker.CustomFormat = "";
            this.BirthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdatePicker.Location = new System.Drawing.Point(102, 243);
            this.BirthdatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BirthdatePicker.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.BirthdatePicker.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.BirthdatePicker.Name = "BirthdatePicker";
            this.BirthdatePicker.Size = new System.Drawing.Size(176, 20);
            this.BirthdatePicker.TabIndex = 10;
            this.BirthdatePicker.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date of Birth";
            // 
            // ComboBoxUserType
            // 
            this.ComboBoxUserType.FormattingEnabled = true;
            this.ComboBoxUserType.Items.AddRange(new object[] {
            "Edit",
            "View"});
            this.ComboBoxUserType.Location = new System.Drawing.Point(102, 289);
            this.ComboBoxUserType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxUserType.Name = "ComboBoxUserType";
            this.ComboBoxUserType.Size = new System.Drawing.Size(176, 21);
            this.ComboBoxUserType.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "User Type";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(102, 337);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(63, 28);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(214, 337);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(63, 28);
            this.SubmitBtn.TabIndex = 15;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 392);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBoxUserType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BirthdatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextRePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewUser";
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextRePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextLastName;
        private System.Windows.Forms.DateTimePicker BirthdatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxUserType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button SubmitBtn;
    }
}