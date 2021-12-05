using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryMVC.Models
{
    public class Author
    {
        public int      Id              { get; set; }
        [Display(Name = "First Name")]
        public String   firstName       { get; set; }
        [Display(Name = "Last Name")]
        public String   lastName        { get; set; }
        [Display(Name = "Rating")]
        [Range(1, 10, ErrorMessage = "Rating cant be less than 1 and more than 10!")]
        public int      rating          { get; set; }
        [Display(Name = "Age")]
        public int      age             { get; set; }
        [Display(Name = "Is the Author still alive?")]
        public bool     isAthorAlive    { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DOB             { get; set; }

        public virtual  ICollection<Book> Books { get; set; }
    }
}