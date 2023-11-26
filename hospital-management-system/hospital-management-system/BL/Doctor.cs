using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class Doctor
    {
        private int id;
        private string name {  get; set; }
        private string specialization { get; set; }
        private string phoneNumber { get; set; }
        private string email { get; set; }
        private int userId { get; set; }

        public Doctor() 
        {
            Name = "";
            Specialization = "";
            PhoneNumber = "1234567890";
            Email = "abc@gmail.com";
        }

        public Doctor(string name, string specialization, string phoneNumber, string email, int userid)
        {
            Name = name;
            Specialization = specialization;
            PhoneNumber = phoneNumber;
            Email = email;
            UserId = userid;
        }

        public int Id { get { return this.id; } set { this.id  = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Specialization { get { return this.specialization; } set { this.specialization = value; } }
        public string PhoneNumber { get { return this.phoneNumber;} set { this.phoneNumber = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public int UserId { get { return this.userId; } set { this.userId = value; } }
    }
}
