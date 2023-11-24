using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class Appointment
    {
        private int Id {  get; set; }
        private DateTime AppointmentDateTime { get; set; }
        private int DoctorId {  get; set; }
        private int PatientId {  get; set; }

        public Appointment() { }

        public  Appointment( int doctorid, int patientid)
        {
            AppointmentDateTime = DateTime.Now;
            DoctorId = doctorid;
            PatientId = patientid;
        }

    }
}
