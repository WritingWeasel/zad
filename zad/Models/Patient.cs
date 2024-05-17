using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace zad.Models
{
    public class Patient
    {
        [Key]
        public int ID { get; set; }

        [Required, Range(10000, 99999, ErrorMessage = "Patient code must be 5 digits.")]

        public int PatientCode { get; set; }

        [Required]
        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
    }
}