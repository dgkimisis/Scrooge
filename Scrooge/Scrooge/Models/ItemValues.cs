using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrooge.Models
{

    public class ItemValues
    {
        [Key, ForeignKey("Products"), Column(Order = 0)]
        public int ProductsId { get; set; }
        public virtual Products Products { get; set; }

        [Key, ForeignKey("ItemKeys"), Column(Order = 1)]
        public int ItemKeysId { get; set; }
        public virtual ItemKeys ItemKeys { get; set; }
        //Values refer to the capacity of a product.
        //Fex a ram has a frequency of 1666 MHz.
        //Value refers to 1666 and MHz comes from table ItemKeys
        public string Value { get; set; }
    }
}