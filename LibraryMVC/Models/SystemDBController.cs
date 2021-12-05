using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryMVC.Models
{
    public class SystemDBController : DbContext
    {
        public DbSet<Author> Authors    { get; set; }
        public DbSet<Book>   Books      { get; set; }
        public DbSet<Client> Clients    { get; set; }
    }
}