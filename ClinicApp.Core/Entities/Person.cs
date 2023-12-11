namespace ClinicApp.Entities
{
    public class Person
    {
        static int count = 0;
        public int id { get; }
        public string name { get; set; }
        public string idNumber { get; set; }
        public DateTime dateOfBirth { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - dateOfBirth.Year;
        }

        public Person(int id, string name, string idNumber, DateTime dateOfBirth)
        {
            this.id = ++count;
            this.name = name;
            this.idNumber = idNumber;
            this.dateOfBirth = dateOfBirth;
        }

        public Person()
        {
            id = ++count;
        }

    }
}
