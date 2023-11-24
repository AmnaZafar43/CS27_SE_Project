using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class Surgeon
    {
        private int Id {  get; set; }
        private string Name { get; set; }
        private string Specialization { get; set; }
        private string PhoneNumber { get; set; }
        private string Email { get; set; }

        public Surgeon() { }

        public Surgeon( string name, string specialization,string phonenumber, string email)
        {
            Name = name;
            Specialization = specialization;
            PhoneNumber = phonenumber;
            Email = email;
        }
    }
}
