using ClinicApp.Core.Entities;
using ClinicApp.Core.Repositories;
using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext _dataContext;
        public DoctorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Add(Doctor doctor)
        {
            _dataContext.doctorsList.Add(doctor);

        }

        public void Delete(int id)
        {
            _dataContext.doctorsList.Remove(_dataContext.doctorsList.Find(d => d.id == id));
        }

        public List<Doctor> Get()
        {
            return _dataContext.doctorsList;
        }

        public Doctor GetById(int id)
        {
            return _dataContext.doctorsList.Find(d => d.id == id);
        }

        public void Update(int id, Doctor doctor)
        {
            var updateDoctor = _dataContext.doctorsList.Find(d => d.id == id);
            if (updateDoctor != null)
            {
                updateDoctor.name=doctor.name;
                updateDoctor.dateOfBirth=doctor.dateOfBirth;
                updateDoctor.workingHoursAmount=doctor.workingHoursAmount;
            }
        }
    }
}
