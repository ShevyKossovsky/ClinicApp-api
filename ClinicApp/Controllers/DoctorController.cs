using ClinicApp.Core.Entities;
using ClinicApp.Core.Services;
using ClinicApp.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApp.Controllers
{
    [Route("ClinicApp/[controller]")]
    [ApiController]

    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
           _doctorService = doctorService;
        }
        // GET: api/<DoctorController>
        [HttpGet]

        public IEnumerable<Doctor> Get()
        {
            return (IEnumerable<Doctor>)_doctorService.Get();
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Doctor? Get(int id)
        {
           return _doctorService.GetById(id);
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor value)
        {
            _doctorService.Add(value);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor value)
        {
            _doctorService.Update(id, value);
        }
        

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _doctorService.Delete(id);
        }


    }
}
