using PartOfHospitalManagments.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOfHospitalManagments.AppointmentService
{
    internal class AppService : IAppointmentService
    {
       
        public List<Appointment> appointments = new List<Appointment>();
        public int nextID = 0;  
        
        public void AddAppointment(string patientName, string doctorName, DateTime startDate)
        {
            Appointment appointment = new Appointment()
            {
                ID = nextID++,
                PatientName = patientName,
                DoctorName = doctorName,
                StartDate = startDate
            };
            appointments.Add(appointment);
            Console.WriteLine($"Appointment yaradfildi: {appointment}");
        }

        public void EndAppointment(int ID)
        {
            foreach (Appointment appointment in appointments)
            {
                if (appointment.ID == ID)
                {
                    appointment.EndDate = DateTime.Now;
                }
             
            }
            //throw new Exception();
        }


        public void GetAppointment(int ID)
        {
            foreach(Appointment appointment in appointments)
            {
                if(appointment.ID == ID)
                {
                    Console.WriteLine(appointment); 
                }

            }
            //throw new Exception();

        }

        public List<Appointment> GetAllAppointments()
        {
            foreach(Appointment appointment in appointments)
            {
                Console.WriteLine(appointment);
            }
            return appointments;    
        }
        public List<Appointment> GetWeeklyAppointments()
        {
            foreach (Appointment appointment in appointments)
            {
                if (appointment.StartDate.Day <= DateTime.Now.Day - 7)
            }
            return appointments;
        } /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////TimeSpan
        /// </summary>
        /// <returns></returns>
        public List<Appointment> GetTodaysAppointments()
        {
            foreach (Appointment appointment in appointments)
            {
                if (appointment.StartDate.Day == DateTime.Now.Day) ;
            }
            return appointments;    
        }

        public void GetAllContinuingAppointments()
        {
            foreach (var item in appointments)
            {
                if (item.EndDate !=null )
                {
                    Console.WriteLine(item.EndDate);    
                }
            }
        }

        Appointment IAppointmentService.GetAppointment(int id)
        {
            throw new NotImplementedException();
        }

        List<Appointment> IAppointmentService.GetAllContinuingAppointments()
        {
            throw new NotImplementedException();
        }
    }
}


//foreach (Appointment appointment in appointments)
//{
//    if (item.StartDate.Day == DateTime.Now.Day)
//    {

//    }
//}