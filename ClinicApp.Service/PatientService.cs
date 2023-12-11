using ClinicApp.Core.Services;
using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Service
{
    public class PatientService : IPatientService
    {
        private readonly IPatientService _patientService;
        public PatientService(IPatientService patientService)
        {
            _patientService = patientService;
        }
        public void Add(Patient patient)
        {
            _patientService.Add(patient);
        }

        public void Delete(int id)
        {
           _patientService.Delete(id);
        }

        public List<Patient> Get()
        {
           return _patientService.Get();
        }

        public Patient GetById(int id)
        {
          return _patientService.GetById(id);
        }

        public void Update(int id, Patient patient)
        {
            _patientService.Update(id, patient);     
        }

        public void UpdateStatus(bool status, int pid, Patient patient)
        {
          _patientService.UpdateStatus(status, pid, patient);
        }
    }
}
