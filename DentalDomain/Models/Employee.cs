using System;
using System.Collections.Generic;

namespace DentalProjectDomain.Models
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public DateTime EntemploymentDate { get; set; }


        public ICollection<Phone> Phones { get; set; } = new List<Phone>();
        public ICollection<Employee> Employees { get; set; }

    }
}
