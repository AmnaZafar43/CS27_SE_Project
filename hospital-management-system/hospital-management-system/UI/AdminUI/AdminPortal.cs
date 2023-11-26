using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system.UI.AdminUI
{
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            doctors1.Show();
        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {
            doctors1.Hide();
        }

        private void doctors1_Load(object sender, EventArgs e)
        {
            doctors1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
