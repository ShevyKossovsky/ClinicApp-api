using ClinicApp.Core.Entities;
using ClinicApp.Core.Services;
using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Service
{
    public class DoctorService : IDoctorService
    {

        private readonly IDoctorService _doctorService;

        public DoctorService(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        public void Add(Doctor doctor)
        {
            _doctorService.Add(doctor);
        }

        public void Delete(int id)
        {
           _doctorService.Delete(id);
        }

        public List<Doctor> Get()
        {
           return _doctorService.Get(); 
        }

        public Doctor GetById(int id)
        {
            return _doctorService.GetById(id);
        }

        public void Update(int id, Doctor doctor)
        {
            _doctorService.Update(id, doctor);
        }
    }
}
