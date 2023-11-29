using ClinicApp.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApp.Controllers
{
    [Route("ClinicApp/[controller]")]
    [ApiController]

    public class DoctorController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public DoctorController()
        {
            _dataContext = new DataContext();
        }
        // GET: api/<DoctorController>
        [HttpGet]

        public IEnumerable<Doctor> Get()
        {
            return _dataContext.doctorsList;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Doctor? Get(int id)
        {
            foreach (var item in _dataContext.doctorsList)
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
            _dataContext.doctorsList.Add(value);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor value)
        {
            foreach (var item in _dataContext.doctorsList)
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
            foreach (var item in _dataContext.doctorsList)
            {
                if (item.id == id)
                {
                    _dataContext.doctorsList.Remove(item);
                    return;
                };

            }
        }


    }
}
