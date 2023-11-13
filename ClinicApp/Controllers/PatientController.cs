using ClinicApp.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApp.Controllers
{
    [Route("ClinicApp/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public static List<Patient> sickPatientsList = new List<Patient>(){};
        public static List<Patient> patientsList = new List<Patient>() 

        { new Patient() { name = "Yossi cohen", idNumber = "32658874",
            dateOfBirth = new DateTime(2000,5,5)
            , HMO = HMO.Meuchedet } 
        };
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return patientsList;
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public Patient? Get(int id)
        {
            foreach (var item in patientsList)
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
            patientsList.Add(value);    
        }

        
        


        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient value)
        {
            foreach(var item in patientsList)
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
        [HttpPut("/status")]
        public void UpdateStatus([FromBody] Patient patient)
        {
            sickPatientsList.Add(patient);
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (var item in patientsList)
            {
                if (item.id == id)
                {
                    patientsList.Remove(item);

                    return;
                }
            }
        }
    }
}
