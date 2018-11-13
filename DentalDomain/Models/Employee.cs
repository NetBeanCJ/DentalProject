using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
    public class Employee : Person
    {
        public int EmpoyeeId { get; set; } 
        public DateTime EmpoymentDate { get; set;}


        public ICollection<PersonEmployee> PersonEmployees { get; set; } = new List<PersonEmployee>();

        // public ICollection<Phone> Phones { get; }


    }
}
