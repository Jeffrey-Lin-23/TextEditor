using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass02
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ControlBox = false;
        }



        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            // Create new user button
            NewUser nuForm = new NewUser();
            nuForm.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Login button
            bool authorized = false;
            string userName = "";
            string userType = "";
            //search username
            try
            {
                string[] lines = System.IO.File.ReadAllLines("login.txt");
                foreach (string line in lines)
                {
                    string[] splits = line.Split(',');
                    if (splits[0] == TextUser.Text && splits[1] == TextPassword.Text)
                    {
                        authorized = true;
                        userName = splits[0];
                        userType = splits[2];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Waring");
            }

            //check the username    
            if (authorized)
            {
                TextEditor td = new TextEditor();
                td.GetUsername(userName, userType);
                td.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Waring");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Exit button click to exit
            Application.Exit();
        }
    }
}
