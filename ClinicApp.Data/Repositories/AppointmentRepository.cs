using ClinicApp.Core.Repositories;
using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Data.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DataContext _dataContext;

        public AppointmentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Appointment> Get()
        {
            return _dataContext.appointmentsList;
        }

        public Appointment GetById(int id)
        {
            return _dataContext.appointmentsList.Find(a => a.id == id);
        }
        public void Add(Appointment appointment)
        {
            _dataContext.appointmentsList.Add(appointment);
        }



        public void Update(int id, Appointment appointment)
        {
            var updateAppointment = _dataContext.appointmentsList.Find(a => a.id == id);
            if (updateAppointment != null)
            {
                updateAppointment.patient = appointment.patient;
                updateAppointment.doctor = appointment.doctor;
                updateAppointment.appointmentDate = appointment.appointmentDate;
                updateAppointment.causeOfReferral = appointment.causeOfReferral;
                updateAppointment.durationInMinutes = appointment.durationInMinutes;
            }
        }
        public void Delete(int id)
        {
            _dataContext.appointmentsList.Remove(_dataContext.appointmentsList.Find(a => a.id == id));
        }


    }
}
