using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class OperationTheater
    {
        private int Id {  get; set; }
        private string Name { get; set; }
        private bool AvailabilityStatus { get; set; }

        public OperationTheater() { }

        public OperationTheater( string name, bool availabilityStatus)
        {
            Name = name;
            AvailabilityStatus = availabilityStatus;
        }
    }
}
