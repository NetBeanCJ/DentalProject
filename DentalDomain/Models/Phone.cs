using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace DentalProjectDomain.Models
{
   public class Phone 
    {
        public int PhoneId { get; set; }
      
        public int PatientId { get; set; }
        public int PersonId { get; set; }
        public string HomeNr { get; set; }
        public string MobileNr { get; set; }
        
        
        public Person Person { get; set; }

    }
}
