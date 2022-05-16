using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Code_FirstApproach.Models
{
    public class ApplicationDbContext:DbContext
    {

        public DbSet<Category> categories { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}