using ClinicApp.Core.Repositories;
using ClinicApp.Core.Services;
using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Data.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DataContext _dataContext;

        public PatientRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Add(Patient patient)
        {
            _dataContext.patientsList.Add(patient);
        }

        public void Delete(int id)
        {
            _dataContext.patientsList.Remove(_dataContext.patientsList.Find(p => p.id == id));

        }

        public List<Patient> Get()
        {
           return _dataContext.patientsList;
        }

        public Patient GetById(int id)
        {
            return _dataContext.patientsList.Find(p => p.id == id);
        }

        public void Update(int id, Patient patient)
        {
            var updatePatient= _dataContext.patientsList.Find(p => p.id == id);
            if (updatePatient != null)
            {
                updatePatient.status = patient.status;
                updatePatient.name = patient.name;
                updatePatient.idNumber = patient.idNumber;
                updatePatient.dateOfBirth= patient.dateOfBirth;
                updatePatient.HMO=updatePatient.HMO;


            }

        }
        public void UpdateStatus(bool status, int pid, Patient patient)
        {
            var updatePatient = _dataContext.patientsList.Find(p => p.id == pid);
            updatePatient.status= status;
        }
    }

}
