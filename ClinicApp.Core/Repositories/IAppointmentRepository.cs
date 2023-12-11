using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Core.Repositories
{
    public interface IAppointmentRepository
    {
        List<Appointment> Get();

        Appointment GetById(int id);

        void Add(Appointment appointment);

        void Update(int id, Appointment appointment);

        void Delete(int id);

    }
}
