﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DentalProjectDomain.Models
{
   public class Treatment
    {
        public int TreatmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
