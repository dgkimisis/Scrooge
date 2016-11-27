using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrooge.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public virtual Categories Parent { get; set; }
        public virtual ICollection<Categories> Children { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}