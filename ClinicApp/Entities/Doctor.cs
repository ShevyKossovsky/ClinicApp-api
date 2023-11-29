namespace ClinicApp.Entities
{
    public class Doctor : Person
    {
        public int workingHoursAmount { get; set; }

        public Doctor(int workingHoursAmount)
        {
            this.workingHoursAmount = workingHoursAmount;
        }

        public Doctor()
        {
        }
    }
}
