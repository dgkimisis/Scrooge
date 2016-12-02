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
        //Categories may belong to other category.
        //Fex Rams Belong to Coputers and computers
        //belong to Technology category
        public int? ParentId { get; set; }
        public virtual Categories Parent { get; set; }
        public virtual ICollection<Categories> Children { get; set; }
        //Ever category has products.
        //Fex Ram has a Kingston Ram and s Corsair Ram
        public virtual ICollection<Products> Products { get; set; }
    }
}