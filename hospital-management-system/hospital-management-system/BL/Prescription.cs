using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class Prescription
    {
        private int Id {get;set;}
        private string MedicineName { get;set;}
        private string Description { get;set;}
        private DateTime PrescriptionDate { get;set;}
        private int DoctorId {  get;set;}
        private int PatientId { get;set;}

        public Prescription() { }

        public Prescription( string medicineName, string description, int doctorId, int patientId)
        {
            MedicineName = medicineName;
            Description = description;
            PrescriptionDate = DateTime.Now;
            DoctorId = doctorId;
            PatientId = patientId;
        }
    }
}
