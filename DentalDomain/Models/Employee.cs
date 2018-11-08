using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
    public class Employee
    {
        public int EmployeetId { get; set; }
        public string SSRN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string StreetName { get; set; }
        public int StreetNr { get; set; }
        public string City { get; set; }
        public int Number { get; set; }

    }
}
