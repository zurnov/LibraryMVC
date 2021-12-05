using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryMVC.Models
{
    public class Client
    {
        public int      Id          { get; set; }

        [Display(Name = "First Name")]
        public String   firstName   { get; set; }
        [Display(Name = "Last Name")]
        public String   lastName    { get; set; }
        [Display(Name = "Address")]
        public String   address     { get; set; }
        [Display(Name = "Age")]
        public int      age         { get; set; }
        [Display(Name = "Is subscription Active?")]
        public bool     isSubActive { get; set; }
        [Display(Name = "Date of birth")]
        public DateTime DOB         { get; set; }

        public virtual  Book Book   { get; set; }

   
    }
}