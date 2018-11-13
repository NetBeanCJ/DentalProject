using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
   public  class PersonPatient
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
