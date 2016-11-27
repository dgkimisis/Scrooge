using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrooge.Models
{
    public class Sellers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Products> Products { get; set; }
    }
}