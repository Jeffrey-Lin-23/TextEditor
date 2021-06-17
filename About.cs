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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.ControlBox = false;
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            //close the form
            this.Hide();
        }
    }
}
