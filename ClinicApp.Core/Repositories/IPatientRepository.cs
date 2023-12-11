using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Core.Repositories
{
    public interface IPatientRepository
    {
        List<Patient> Get();

        Patient GetById(int id);

        void Add(Patient patient);

        void Update(int id, Patient patient);

        void Delete(int id);
    }
}
