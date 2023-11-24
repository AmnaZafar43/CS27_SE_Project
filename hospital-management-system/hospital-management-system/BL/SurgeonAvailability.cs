using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class SurgeonAvailability
    {
        private int Id {  get; set; }
        private int SurgeonId {  get; set; }
        private bool AvialabilityStatus {  get; set; }

        public SurgeonAvailability() { }

        public SurgeonAvailability( int surgeonId, bool avialabilityStatus)
        {
            SurgeonId = surgeonId;
            AvialabilityStatus = avialabilityStatus;
        }
    }
}
