using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrooge.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoriesId { get; set; }
        public virtual Categories Categories { get; set; }
        public virtual ICollection<Distinctions> Distinctions { get; set; }
    }
}