using hospital_management_system.BL;
using hospital_management_system.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital_management_system.UI.AdminUI
{
    public partial class Doctors : UserControl
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void Contact_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void changeColorTextbox()
        {
            Name_tbx.Text = "FirstName";
            Name_tbx.ForeColor = Color.Silver;
            Email_textBox.Text = "LastName";
            Email_textBox.ForeColor = Color.Silver;
            Contact_textBox.Text = "Contact";
            Contact_textBox.ForeColor = Color.Silver;
            Specialization_tbx.Text = "LastName";
            Specialization_tbx.ForeColor = Color.Silver;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (Name_tbx.Text == "Name")
            {
                Name_tbx.Text = "";
                Name_tbx.ForeColor = Color.Black;
            }
        }

        private void Contact_textBox_Enter(object sender, EventArgs e)
        {
            if (Contact_textBox.Text == "Contact")
            {
                Contact_textBox.Text = "";
                Contact_textBox.ForeColor = Color.Black;
            }
        }

        private void Email_textBox_Enter(object sender, EventArgs e)
        {
            if (Email_textBox.Text == "Email")
            {
                Email_textBox.Text = "";
                Email_textBox.ForeColor = Color.Black;
            }
        }

        private void Specialization_tbx_Enter(object sender, EventArgs e)
        {
            if (Specialization_tbx.Text == "Specialization")
            {
                Specialization_tbx.Text = "";
                Specialization_tbx.ForeColor = Color.Black;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name, spec, cont, email;
            name = Name_tbx.Text.ToString();
            spec = Specialization_tbx.Text.ToString();
            cont = Contact_textBox.Text.ToString();
            email = Email_textBox.Text.ToString();
            if (name != "" && spec != "" && cont != "" && email != "")
            {
               if(DoctorsData.addDoctor(name,spec, cont, email))
                {
                    MessageBox.Show("successfully added!");
                    binddata();
                    changeColorTextbox();
                }
                else
                {
                    MessageBox.Show("there was an error");
                    changeColorTextbox();
                }
            }
            else
            {
                MessageBox.Show("A field is empty!");
                changeColorTextbox();
            }
        }

        private void Dcotors_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)Dcotors_dgv.CurrentCell.OwningRow.Cells[2].Value;
            if (Dcotors_dgv.Columns["Delete"].Index == e.ColumnIndex)
            {
                if(DoctorsData.deleteDoctor(id))
                {
                    MessageBox.Show("the doctor was deleted.");
                    binddata();
                    changeColorTextbox();
                    
                }
                MessageBox.Show("the user could not be deleted.");
                changeColorTextbox();
            }
            if (Dcotors_dgv.Columns["Update"].Index == e.ColumnIndex)
            {
                string name, spec, cont, email;
                name = Name_tbx.Text;
                spec = Specialization_tbx.Text;
                cont = Contact_textBox.Text;
                email = Email_textBox.Text;

                if (name != "" && spec != "" && cont != "" && email != "")
                {
                    Form f = new Doctors_Update_form(id,name,spec,cont,email);
                    f.ShowDialog();
                    binddata();
                    changeColorTextbox();
                }
                else
                {
                    MessageBox.Show("A field is empty!");
                    changeColorTextbox();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void binddata()
        {
            BindingSource doctorBindingSource = new BindingSource();
            doctorBindingSource.DataSource = DoctorsData.LoadDoctorsData();
            Dcotors_dgv.DataSource = doctorBindingSource;
            Dcotors_dgv.AutoGenerateColumns = true;
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            binddata();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
