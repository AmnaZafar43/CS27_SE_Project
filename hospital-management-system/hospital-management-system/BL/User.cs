using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    internal class User
    {
        private string Username { get; set; }
        private int Id { get; set; }
        private string Password { get; set; }
        private string Role { get; set; }

        public User() {
            this.Id = 0;
            this.Username = "username";
            this.Password = "password";
            this.Role = "role";
        }
        public User(string username,string password,string role)
        {
            this.Username=username;
            this.Password=password;
            this.Role = role;
        }
    }
}
