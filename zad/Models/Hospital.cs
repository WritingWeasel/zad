using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace zad.Models
{
    public class Hospital
    {
        [Key]
        public int ID { get; set; }

        public string Image { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
    }
}