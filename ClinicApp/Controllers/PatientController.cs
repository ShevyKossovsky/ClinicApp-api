using ClinicApp.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApp.Controllers
{
    [Route("ClinicApp/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PatientController()
        {
            _dataContext=new DataContext();
        }
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _dataContext.patientsList;
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public Patient? Get(int id)
        {
            foreach (var item in _dataContext.patientsList)
            {
                if (item.id == id) { return item; };
            }
            Console.WriteLine("No such a patient id");
            return null;
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] Patient value)
        {
            _dataContext.patientsList.Add(value);    
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient value)
        {
            foreach(var item in _dataContext.patientsList)
            {
                if (item.id == id)
                {
                    item.dateOfBirth = value.dateOfBirth;
                    item.name = value.name;
                    item.idNumber = value.idNumber;
                    item.HMO = value.HMO;

                }
            }
        }
        [HttpPut("{pid}/{status}")]
        public void UpdateStatus(bool status, int pid, [FromBody] Patient patient)
        {
            Patient pa = _dataContext.patientsList.Find(p => p.id == pid);
            if (pa != null)
                pa.status = pa.status;
        }
     
        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (var item in _dataContext.patientsList)
            {
                if (item.id == id)
                {
                    _dataContext.patientsList.Remove(item);

                    return;
                }
            }
        }
    }
}
