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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //cancel button
            Login lg = new Login();
            //use new form
            lg.Show();
            //hide current
            this.Hide();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //submit button
            bool existed = false;
            //check the username
            string[] lines = System.IO.File.ReadAllLines("login.txt");
            foreach (string line in lines)
            {
                string[] splits = line.Split(',');
                if (splits[0] == TextUser.Text)
                {
                    existed = true;
                    break;
                }
            }
            if (TextUser.Text == "" || TextPassword.Text == "" || TextRePassword.Text == "" || TextFirstName.Text == "" || TextLastName.Text == "" || ComboBoxUserType.Text == "")
            {
                //check empty textbox
                MessageBox.Show("You should provide all information before submit!", "Waring");
            }
            else if (TextRePassword.Text != TextPassword.Text)
            {
                //password cannot match
                TextPassword.Text = "";
                TextRePassword.Text = "";
                MessageBox.Show("The second time password is not same as first time, Please Input the password again!", "Waring");
            }
            else if (TextPassword.Text.Contains(",") || TextRePassword.Text.Contains(",") || TextUser.Text.Contains(",") || TextFirstName.Text.Contains(",") || TextLastName.Text.Contains(","))
            {
                // contains the , to make formate error
                MessageBox.Show("Invalid Input ! \",\" is not allowed!", "Waring");
            }
            else if (existed)
            {
                //check username exist
                MessageBox.Show("User has already existed! Try another UserName Please!", "Waring");
            }
            else
            {
                // submit successful!
                string writeInFile = TextUser.Text + "," + TextPassword.Text + "," + ComboBoxUserType.Text + "," + TextFirstName.Text + "," + TextLastName.Text + "," + BirthdatePicker.Value.ToString("dd-MM-yyyy");
                System.IO.File.AppendAllText("login.txt", Environment.NewLine + writeInFile);
                MessageBox.Show("New User Created success!", "Information");
                //new window
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }
    }
}
