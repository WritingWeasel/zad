1. Klasi vo models pishuvanje, nad ID-to pishuvame key
2. Vo Identity models modelot,  vo poslednata klasa pishuvame listi od klasite
public DbSet<Client> Clients {get; set;}
3.  
(Tools->PackageManager->Console)
Enable-Migrations
---> pri sekoja promena
Add-Migration Initial
update-database
4. AddController -> treta opcija na kontroler ->
5. (View -> server Explorer -> Tables)
6. Klasa ClientMovie samo za relacija ->Vo clients i movies stavame
public virtual ICollection<Movie> movies {get; set;} + konstruktor ->Povtoruvame cekor 3


Client
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, 99, ErrorMessage ="Invalid age")]
        public int Age { get; set; }
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }


    }
}

Movie

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Name { get; set; }
        public int Url { get; set; }
        public int Rating { get; set; }
        

    }
}
