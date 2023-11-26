using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class Patient
    {
        private int id { get; set; }
        private string name { get; set; }
        private string address { get; set; }
        private string cNIC { get; set; }
        private string phone_Number { get; set; }
        private int userId { get; set; }


        public Patient()
        {
            this.Id = 0;
            this.Name = "abc";
            this.Address = "abc-xyz";
            this.CNIC = "33555222227744";
            this.Phone_Number = "1234567890";
        }

        public Patient(string name, string address, string cNIC, string phone_Number, int userid)
        {
            Name = name;
            Address = address;
            CNIC = cNIC;
            Phone_Number = phone_Number;

        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public string CNIC { get { return this.cNIC; } set { this.cNIC = value; } }
        public string Phone_Number { get {  return this.phone_Number; } set { this.phone_Number = value; } }
        public int UserId { get { return this.userId; } set { this.userId = value; } }

    }
}
