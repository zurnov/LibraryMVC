using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryMVC.Models
{
    public class Book
    {
        public int      Id              { get; set; }
        [Display(Name = "Title")]
        public String   title           { get; set; }
        [Display(Name = "Rating")]
        [Range(1,10, ErrorMessage = "Rating cant be less than 1 and more than 10!")]
        public int      rating          { get; set; }
        [Display(Name = "Price")]
        public int      price           { get; set; }
        [Display(Name = "Is the book aveilable")]
        public bool     isBookAvailable { get; set; }
        [Display(Name = "Reliase Date of the book")]
        public DateTime reliaseDate     { get; set; }

        public virtual  Author Author   { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

    }
}