using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zad.Models
{
    public class Doctor
    {
        public Doctor()
        {
            hospitals = new List<Hospital>();
            patients = new List<Patient>();
        }

        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string HospitalName { get; set; }

        public virtual ICollection<Hospital> hospitals { get; set; }

        public virtual ICollection<Patient> patients { get; set; }
    }
}