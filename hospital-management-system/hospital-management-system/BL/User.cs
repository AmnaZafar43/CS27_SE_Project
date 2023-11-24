using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class User
    {
        private string username;
        private int id;
        private string password;
        private string role;

        public User() {
            this.id = 0;
            this.username = "username";
            this.password = "password";
            this.role = "role";
        }
        public User(string username,string password,string role)
        {
            this.username=username;
            this.password=password;
            this.role = role;
        }

        public string UserName { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Role { get { return role; } set { role = value; } }
        public int Id { get { return id; } set { id = value; } }
    }
}
