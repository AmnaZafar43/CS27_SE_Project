using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class Nurse
    {
        private int id {  get; set; }
        private string name { get; set; }
        private string qualification { get; set; }
        private string phoneNumber { get; set; }
        private string email { get; set; }
        private int userId {  get; set; }

        public Nurse() 
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.Qualification = string.Empty;
            this.PhoneNumber = string.Empty;
            this.Email = string.Empty;
        }

        public Nurse( string name, string qualification, string phoneNumber, string email, int userid)
        {
            Name = name;
            Qualification = qualification;
            PhoneNumber = phoneNumber;
            Email = email;
            UserId = userid;
        }
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Qualification { get { return this.qualification; } set { this.Qualification = value; } }
        public string PhoneNumber { get { return this.phoneNumber; } set { this.phoneNumber = value; } }
        public string Email {  get { return this.email; } set { this.email = value; } }
        public int UserId { get { return this.userId; } set { this.userId = value; } }
    }
}
