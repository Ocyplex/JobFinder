using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class JobOffer
    {
        public int id { get; set; }

        public string jobTitle { get; set; }

        public string jobLocation { get; set; }

        public string description { get; set; }

        public string salary { get; set; }

        public DateTime startDate { get; set; }
    }
}
