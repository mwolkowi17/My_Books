using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBooks.Models
{
    public class Book
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Data wydania")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        [Display(Name ="Liczba stron")]
        public int NumberPages { get; set; }
        public string MojaOcena { get; set; }
        

    }
}
