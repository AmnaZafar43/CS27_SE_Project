using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace hospital_management_system.BL
{
    public class OpertaionSchedule
    {
        private DateTime Date_Time {  get; set; }
        private int Id {  get; set; }
        private int SurgeonId { get; set; }
        private int PatientId {  get; set; }

        public OpertaionSchedule() { }

        public OpertaionSchedule( int surgeonId, int patientId)
        {
            Date_Time = DateTime.Now;
            SurgeonId = surgeonId;
            PatientId = patientId;
        }
    }
}
