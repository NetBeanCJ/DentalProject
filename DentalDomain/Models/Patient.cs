using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
   public class Patient
    {
        public int PatientId { get; set; }
        public string  SSNR { get; set; }
        public string  FirstName{ get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public int StrieetNr { get; set; }
        public string City { get; set; }
        public int PostCode { get; set;} 
       public int JournalId { get; set; }
    }
}
