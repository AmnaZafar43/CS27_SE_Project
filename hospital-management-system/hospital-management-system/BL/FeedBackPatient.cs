using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_management_system.BL
{
    public class FeedBackPatient
    {
        private int Id {  get; set; }
        private string Feedback { get; set; }
        private string Rating { get; set; }
        private string PatientId;
        public FeedBackPatient() { }
        public FeedBackPatient( string feedback, string rating, string patientId)
        {
            Feedback = feedback;
            Rating = rating;
            PatientId = patientId;
        }
    }
}
