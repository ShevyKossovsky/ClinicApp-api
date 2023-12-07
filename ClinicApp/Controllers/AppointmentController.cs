
using ClinicApp.Core.Services;
using ClinicApp.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApp.Controllers
{
    [Route("ClinicApp/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
       private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        // GET: api/<AppointmentController>
        [HttpGet]
        public IEnumerable<Appointment> Get() {
            return _appointmentService.Get();
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public Appointment? Get(int id)
        {
            return _appointmentService.GetById(id); 
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Post([FromBody] Appointment value)
        {
           _appointmentService.Add(value);  
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Appointment value)
        {
            _appointmentService.Update(id, value);  
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _appointmentService.Delete(id);
        }
    }
}
