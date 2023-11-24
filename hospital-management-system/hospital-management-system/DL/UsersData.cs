using hospital_management_system.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace hospital_management_system.DL
{
    public class UsersData
    {
        private static List<User> users = new List<User>();
        
        public static bool addUser(string username, string password, string role)
        {
            if (username != null && password != null && role != null && !FindUser(username,password,role)) 
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)", con);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                LoadUsersFromDB();
                return true;
            }
            MessageBox.Show("Check all the fields. \n If the fields are full user already exists!");
            return false;
        }

        public static bool DeleteUser(string username, string password, string role)
        {
            User userToDelete = users.Find(u => u.UserName == username && u.Password == password && u.Role == role);

            if (userToDelete != null)
            {
                
            }
            return false;
        }

        public static bool UpdateUser(string username, string newPassword, string newRole)
        {
            User userToUpdate = users.Find(u => u.UserName == username);

            if (userToUpdate != null)
            {
                userToUpdate.Password = newPassword;
                userToUpdate.Role = newRole;
                return true;
            }
            return false;
        }

        public static bool FindUser(string username,string password,string role)
        {
            return (users.Find(u => u.UserName == username && u.Password == password && u.Role == role) != null);
        }

        public static void LoadUsersFromDB()
        {
            int id;
            string username, password, role;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select ID,Username,Password,Role from Users where ActiveStatus = 1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows) 
            {
                id = Convert.ToInt32(row["ID"]);
                username = row["Username"].ToString();
                password = row["Password"].ToString();
                role = row["Role"].ToString();
                User u = new User(username,password, role);
                u.Id = id;
                users.Add(u);
            }
        }


    }
}
