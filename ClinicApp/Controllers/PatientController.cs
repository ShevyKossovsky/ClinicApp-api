using ClinicApp.Core.Services;
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
        private readonly  IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _patientService.Get();
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public Patient? Get(int id)
        {
            return _patientService.GetById(id);
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] Patient value)
        {
            _patientService.Add(value); 
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient value)
        {
            _patientService.Update(id, value);  
        }
        [HttpPut("{pid}/{status}")]
        public void UpdateStatus(bool status, int pid, [FromBody] Patient patient)
        {
            _patientService.UpdateStatus(status, pid, patient);
        }
     
        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
            _patientService.Delete(id); 
        }
    }
}
