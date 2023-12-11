using System.Reflection.Metadata.Ecma335;

namespace ClinicApp.Entities
{
    public enum HMO
    {
        Maccabi,
        Meuchedet,
        Leumit
    }
    public class Patient : Person
    {

        public HMO HMO { get; set; }
        public bool status { get; set; }

        public Patient(HMO hMO,bool status)
        {
            HMO = hMO;
            this.status = status;
        }

        public Patient()
        {
        }
    }
}
