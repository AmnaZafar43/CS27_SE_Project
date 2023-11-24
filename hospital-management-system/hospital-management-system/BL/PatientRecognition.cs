using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class PatientRecognition
    {
        private int AddmisionId {  get; set; }
        private int PatientId {  get; set; }
        private DateTime AddmissionDate {  get; set; }
        private DateTime DischargeDate {  get; set; }

        public PatientRecognition() { }

        public PatientRecognition(int addmisionId, int patientId, DateTime addmissionDate, DateTime dischargeDate)
        {
            AddmisionId = addmisionId;
            PatientId = patientId;
            AddmissionDate = addmissionDate;
            DischargeDate = dischargeDate;
        }
    }
}
