using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class Nurse
    {
        private int Id {  get; set; }
        private string Name { get; set; }
        private string Qualification { get; set; }
        private string PhoneNumber { get; set; }
        private string Email { get; set; }
        public Nurse() 
        {
            this.Id = 0;
            this.Name = string.Empty;
            this.Qualification = string.Empty;
            this.PhoneNumber = string.Empty;
            this.Email = string.Empty;
        }

        public Nurse( string name, string qualification, string phoneNumber, string email)
        {
            Name = name;
            Qualification = qualification;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
