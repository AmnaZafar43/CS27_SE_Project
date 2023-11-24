using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class PatientEmergencyHistory
    {
        private int Id {  get; set; }
        private int PatientId {  get; set; }
        private string Condition { get; set; }
        private DateTime OperationDate {  get; set; }

        public PatientEmergencyHistory() { }

        public PatientEmergencyHistory( int patientId, string condition, DateTime operationDate)
        {
            PatientId = patientId;
            Condition = condition;
            OperationDate = operationDate;
        }
    }
}
