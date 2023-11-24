using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class Doctor
    {
        private int Id { get; set; }
        private string Name {  get; set; }
        private string Specialization { get; set; }
        private string PhoneNumber { get; set; }
        private string Email { get; set; }

        public Doctor() 
        {
            Name = "";
            Specialization = "";
            PhoneNumber = "1234567890";
            Email = "abc@gmail.com";
        }

        public Doctor(string name, string specialization, string phoneNumber, string email)
        {
            Name = name;
            Specialization = specialization;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
