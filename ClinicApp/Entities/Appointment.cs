namespace ClinicApp.Entities
{
    public class Appointment
    {
        static int count = 0;
        public int id { get; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        public string causeOfReferral { get; set; }//סיבת הפניה

        public DateTime appointmentDate { get; set; }
        public int durationInMinutes { get; set; }

        public List<Appointment> appointments = new List<Appointment>()
{
    new Appointment()
    {
        doctor = new Doctor()
        {
            name = "Rohi Grosman",
            idNumber = "215225588",
            dateOfBirth = new DateTime(1967, 5, 2)
        },
        patient = new Patient()
        {
            name = "Yossi Cohen",
            idNumber = "32658874",
            dateOfBirth = new DateTime(2000, 11, 4),
            HMO = HMO.Meuchedet
        },
        appointmentDate = new DateTime(2023, 11, 12, 18, 0, 0),
        causeOfReferral = "sore throat",
        durationInMinutes = 10
    }
};

        Appointment()
        {
            this.id = ++count;
        }



    }
}
