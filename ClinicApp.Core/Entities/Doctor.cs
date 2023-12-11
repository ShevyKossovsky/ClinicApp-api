using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Core.Entities
{
    public class Doctor:Person
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
