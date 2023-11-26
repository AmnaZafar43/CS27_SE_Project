using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hospital_management_system.BL;
using System.Runtime.CompilerServices;
using System.Web;

namespace hospital_management_system.DL
{
    public class DoctorsData
    {
        private static List<Doctor> doctors = new List<Doctor>();

        public DoctorsData() { }

        public void LoadDoctors()
        {
            int id;
            string name, spec, email, contact;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select ID,Name,Specialization,Email,Contact from Doctors where ActiveStatus = 1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                id = Convert.ToInt32(row["ID"]);
                name = row["Name"].ToString();
                spec = row["Specialization"].ToString();
                email = row["Email"].ToString();
                contact = row["Conact"].ToString();
                Doctor d = new Doctor(name, spec, email, contact);
                d.Id = id;
                doctors.Add(d);
            }
        }

        public static bool addDoctor(string name, string spec, string contact, string email)
        {
            if(name != null && spec != null && contact != null && email != null )
            {
                Doctor d = new Doctor(name,spec,contact,email);
                if (!Check_email(d.Email))
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Doctors (Name, Specialization, Contact, Email) VALUES (@Name, @Specialization, @Contact, @Email)", con);
                    cmd.Parameters.AddWithValue("@Name", d.Name);
                    cmd.Parameters.AddWithValue("@Specialization", d.Specialization);
                    cmd.Parameters.AddWithValue("@Email", d.Email);
                    cmd.Parameters.AddWithValue("@Contact", d.PhoneNumber);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                MessageBox.Show("the user already exists");
                return false;
            }
            else
            {
                MessageBox.Show("One of the value is null");
                return false;
            }
        }

        private static bool Check_email(string email)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id from Doctors where Email=@Email", con);
            cmd.Parameters.AddWithValue("@Email", email);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count > 0;
        }

        public static bool updateDoctor(int id, string name, string spec, string contact, string email)
        {
            if (name != null && spec != null && contact != null && email != null)
            {
                              
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("update Doctors set Name=@Name,Specialization=@Specialization,Email=@Email,Contact=@Contact where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Specialization",spec);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public static bool deleteDoctor(int id)
        {
            if (id != 0)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update Doctors set ActiveStatus=0 WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID",id);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public static List<Doctor> LoadDoctorsData()
        {
            int id;
            string name, spec, cont, email;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select ID,Name,Specialization,Email,Contact from Doctors where ActiveStatus = 1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                id = Convert.ToInt32(row["ID"]);
                name = row["Name"].ToString();
                spec = row["Specialization"].ToString();
                cont = row["Contact"].ToString();
                email = row["Email"].ToString();
                Doctor u = new Doctor(name, spec, cont, email);
                u.Id = id;
                doctors.Clear();
                doctors.Add(u);
            }
            return doctors;
        }
    }
}
