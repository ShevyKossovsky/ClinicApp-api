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


    }
}
