using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_FirstApproach.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price{ get; set; }
        public int Quantity { get; set; }
        public string Disripation  { get; set; }
        public Category Category { get; set; }

    }
}