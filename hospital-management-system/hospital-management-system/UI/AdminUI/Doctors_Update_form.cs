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

namespace hospital_management_system.UI.AdminUI
{
    public partial class Doctors_Update_form : Form
    {
        int id;
        string name, spec, cont, email;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.name = textbox_name.Text;
            this.spec = textBox_Spec.Text;
            this.cont = textBox_contact.Text;
            this.email = textBox_Email.Text;
            if (DoctorsData.updateDoctor(id, name, spec, cont, email))
            {
                MessageBox.Show("successfully updated.");
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Doctors_Update_form(int id, string name, string spec, string contact, string email)
        {
            this.id = id;
            this.name = name;
            this.spec = spec;
            this.cont = contact;
            this.email = email;
            InitializeComponent();
        }

        private void Doctors_Update_form_Load(object sender, EventArgs e)
        {
            textbox_name.Text = name;
            textBox_Spec.Text = spec;
            textBox_Email.Text = email;
            textBox_contact.Text = cont;
        }
    }
}
