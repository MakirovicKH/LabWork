using PartOfHospitalManagments.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOfHospitalManagments.AppointmentService
{
    internal interface IAppointmentService
    {
       public void AddAppointment(Appointment appointment);
        public void EndAppointment(int id);
        Appointment GetAppointment(int id);
        List<Appointment> GetAllAppointments();
        List<Appointment> GetWeeklyAppointments();
        List<Appointment> GetTodaysAppointments();
        List<Appointment> GetAllContinuingAppointments();
    }
}
