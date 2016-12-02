using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scrooge.Models
{
    public class Prices
    {
        //Price firstly refers to a specific item with attributes from
        //Products, ItemValues and ItemKeys
        [Key, ForeignKey("ItemValues"), Column(Order = 0)]
        public int ItemValuesId { get; set; }
        public virtual ItemValues ItemValues { get; set; }

        //An item is being sold by one or more Sellers
        [Key, ForeignKey("Sellers"), Column(Order = 1)]
        public int SellersId { get; set; }
        public virtual Sellers Sellers { get; set; }
        //Price
        public int Pricetag { get; set; }

        public string Currency { get; set; }

        }


    }
}