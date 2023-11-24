using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class Patient
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private string CNIC { get; set; }
        private string Phone_Number { get; set; }


        public Patient()
        {
            this.Id = 0;
            this.Name = "abc";
            this.Address = "abc-xyz";
            this.CNIC = "33555222227744";
            this.Phone_Number = "1234567890";
        }

        public Patient(string name, string address, string cNIC, string phone_Number)
        {
            Name = name;
            Address = address;
            CNIC = cNIC;
            Phone_Number = phone_Number;
        }
    }
}
