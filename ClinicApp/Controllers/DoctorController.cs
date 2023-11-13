using ClinicApp.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApp.Controllers
{
    [Route("ClinicApp/[controller]")]
    [ApiController]

    public class DoctorController : ControllerBase
    {
        public static List<Doctor> doctorsList = new List<Doctor>
        {new Doctor(){ name="rohi Grosman", idNumber="215225588"
            ,dateOfBirth=new DateTime(1967,5,2) ,workingHoursAmount=10} };
        // GET: api/<DoctorController>
        [HttpGet]

        public IEnumerable<Doctor> Get()
        {
            return doctorsList;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Doctor? Get(int id)
        {
            foreach (var item in doctorsList)
            {
                if (item.id == id) { return item; };
            }
            Console.WriteLine("No such a doctor id");
            return null;
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor value)
        {
            doctorsList.Add(value);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor value)
        {
            foreach (var item in doctorsList)
            {
                if (item.id == id) 
                {
                    item.idNumber=value.idNumber;
                    item.name=value.name;
                    item.workingHoursAmount=value.workingHoursAmount;
                    item.dateOfBirth=value.dateOfBirth;
                };

            }
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (var item in doctorsList)
            {
                if (item.id == id)
                {
                    doctorsList.Remove(item);
                    return;
                };

            }
        }


    }
}
