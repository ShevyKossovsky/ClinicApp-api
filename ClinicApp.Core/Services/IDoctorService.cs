using ClinicApp.Core.Entities;
using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Core.Services
{
    public interface IDoctorService
    {
        List<Doctor> Get();

        Doctor GetById(int id);

        void Add(Doctor doctor);

        void Update(int id, Doctor doctor);

        void Delete(int id);
    }
}
