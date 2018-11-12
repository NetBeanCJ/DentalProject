using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
    public class Patient : Person
    {
        public int PatientId { get; set; }


        public ICollection<Phone> Phones { get; set; } = new List<Phone>();
        public Journal Journal { get; set; }

    }
}
    
    

       
 