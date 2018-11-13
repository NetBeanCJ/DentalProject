using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
   public class Journal
    {
        public int JournalId { get; set; }
        public string Text { get; set;}

        public int PatientId { get; set; }

       // public Patient Patient { get; set; } // skapar object

    }
}
