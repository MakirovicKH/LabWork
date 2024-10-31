using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOfHospitalManagments.Model
{
    internal class Appointment
    {
        public int ID { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            return $"Appointment(ID: {ID}, Patient: {PatientName}, Doctor: {DoctorName}, Start: {StartDate}, End: {EndDate})";
        }
    }
}
