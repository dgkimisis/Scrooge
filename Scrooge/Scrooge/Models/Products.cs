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
        //Every Product belongs to a category
        public virtual Categories Categories { get; set; }
        //Every product has different characteristics which 
        //will be shown in the ItemValues table
        public virtual ICollection<ItemValues> ItemValues { get; set; }
    }
}