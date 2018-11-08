using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
   public class Patient
    {
        public int PatientId { get; set; }
        public string  SocialSecurityNumber { get; set; }
        public string  FirstName{ get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public int Number { get; set; }

    }
}
