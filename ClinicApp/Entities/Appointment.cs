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

        public Appointment(Patient patient, Doctor doctor, string causeOfReferral, DateTime appointmentDate, int durationInMinutes)
        {
            this.id = ++count;
            this.patient = patient;
            this.doctor = doctor;
            this.causeOfReferral = causeOfReferral;
            this.appointmentDate = appointmentDate;
            this.durationInMinutes = durationInMinutes;
        }

        public Appointment()
        {
            this.id = ++count;
        }



    }
}
