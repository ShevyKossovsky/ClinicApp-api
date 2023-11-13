using ClinicApp.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        public static List<Appointment> appointmentsList = new List<Appointment>() { };

        // GET: api/<AppointmentController>
        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
            return appointmentsList;
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public Appointment? Get(int id)
        {
            foreach (var item in appointmentsList)
            {
                if(item.id == id)
                    return item;
            }
            return null;
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Post([FromBody] Appointment value)
        {
            appointmentsList.Add(value);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Appointment value)
        {
            foreach (var item in appointmentsList) 
            { 
                if(item.id == id)
                {
                    item.patient = value.patient;
                    item.doctor=value.doctor;
                    item.durationInMinutes = value.durationInMinutes;
                    item.appointmentDate = value.appointmentDate;   
                      
                }
            }
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach
                (Appointment appointment in appointmentsList)
            {
                if(appointment.id==id)
                {
                    appointmentsList.Remove(appointment);
                    return;
                }

            }
        }
    }
}
