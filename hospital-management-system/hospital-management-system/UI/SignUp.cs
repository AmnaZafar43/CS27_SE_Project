using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospital_management_system.BL;
using hospital_management_system.DL;

namespace hospital_management_system.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();
            f.Show();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string name = Username_tbx.Text.ToString();
            string password = password_tbx.Text.ToString();
            string role = role_cbx.Text.ToString();
            if(UsersData.addUser(name, password, role))
            {
                MessageBox.Show("Now you can head towards the login page!");
            }


        }
    }
}
