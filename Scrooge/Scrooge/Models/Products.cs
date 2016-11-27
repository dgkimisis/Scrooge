using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrooge.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Categories Category { get; set; }

    }
}