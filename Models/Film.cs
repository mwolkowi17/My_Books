using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBooks.Models
{
    public class Film
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Data wydania")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Director")]
        public string Artist { get; set; }
        public string Genre { get; set; }
        [Display(Name = "Długość")]
        public int Lenght { get; set; }
        public string MojaOcena { get; set; }

    }
}
