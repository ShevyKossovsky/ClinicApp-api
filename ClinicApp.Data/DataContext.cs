using ClinicApp.Core.Entities;
using ClinicApp.Entities;

namespace ClinicApp.Core.Repositories;

public class DataContext
{

    public List<Doctor> doctorsList { get; set; }
    public  List<Patient> patientsList { get; set; }
    public  List<Appointment> appointmentsList { get; set; }

    public DataContext()
    {
        doctorsList = new List<Doctor>() {
         new Doctor()
            {
                name = "rohi Grosman",
                idNumber = "215225588",
                dateOfBirth = new DateTime(1967, 5, 2),
                workingHoursAmount = 10 }
            };
        patientsList = new List<Patient>()
        {

          new Patient()
         {
             name = "Yossi cohen",
             idNumber = "32658874",
             dateOfBirth = new DateTime(2000,5,5),
             HMO = HMO.Meuchedet }
        };
        appointmentsList = new List<Appointment>() { 
        
            new Appointment()
            {
                appointmentDate = new DateTime(2023,2,5),
                patient= new Patient(){idNumber="512544453"},
                durationInMinutes=10,
                doctor= new Patient(){idNumber="2665845225"},
                causeOfReferral="headace"
            }

        };

    }


}
