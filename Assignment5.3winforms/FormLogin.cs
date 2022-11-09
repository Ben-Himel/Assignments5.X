using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._3winforms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text == "Teacher" && textBoxPassword.Text == "Admin")
            {
                FormLrnMgmnt mgmnt = new FormLrnMgmnt();
                mgmnt.Show();
                //this.Hide();
                //this.Close();

            }
            else
            {
                MessageBox.Show("User Name or Password incorrect", "Error");
            }
        }
    }
}
