using hospital_management_system.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Signupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new SignUp();
            f.Show();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string name = Usernmetbx.Text.ToString();
            string password = passwordtbx.Text.ToString();
            string role = role_cbx.Text.ToString();
            MessageBox.Show(name + password + role);
            if (UsersData.FindUser(name, password, role))
            {
                MessageBox.Show("user found!");
            }
            else
            {
                MessageBox.Show("user not found");
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // This code will load data of users when the form is loaded

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usernmetbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            UsersData.LoadUsersFromDB();
        }
    }
}
