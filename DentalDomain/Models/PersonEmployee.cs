using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
   public class PersonEmployee
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }


        public int EmployeeId { get; set; }
        public Employee Employee { get; set;}
    }
}
