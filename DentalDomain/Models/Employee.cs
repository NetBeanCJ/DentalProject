using System;
using System.Collections.Generic;

namespace DentalProjectDomain.Models
{
    public class Employee : Person
    {
        public DateTime EmploymentDate { get; set; }
        public ICollection<Phone> Phones { get; set; } = new List<Phone>();
    }
}
